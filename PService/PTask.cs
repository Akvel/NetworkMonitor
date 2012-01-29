using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Windows.Forms;
using PService.monitorDataSetTableAdapters;
using PService.sender;
using PService.tests;

namespace PService
{
    class PTask
    {
        public bool needStop = false;
        private long predRefresh = 0;
        public monitorDataSet mset1;
        private PService.monitorDataSetTableAdapters.usersTableAdapter _usersTableAdapter;
        private PService.monitorDataSetTableAdapters.hardware_mail_listTableAdapter hardware_mails;
        private PService.monitorDataSetTableAdapters.software_mail_listTableAdapter software_mails;
        private PService.monitorDataSetTableAdapters.hardwaresTableAdapter hardwaresTableAdapter;
        private PService.monitorDataSetTableAdapters.softwareTableAdapter softwareTableAdapter;
        private PService.monitorDataSetTableAdapters.monitoringTableAdapter _monitoringTableAdapter;

        private readonly FMain fMain;

        List<Task<PResult>> tasks = new List<Task<PResult>>();

        private Dictionary<int, long> lastStart = new Dictionary<int, long>();
        private Dictionary<int, int> taskId = new Dictionary<int, int>();
        private monitorDataSetTableAdapters.TableAdapterManager tableAdapterManager;

        public PTask(FMain fMain)
        {

            this.mset1 = new PService.monitorDataSet();
            this.mset1.DataSetName = "monitorDataSet";
            this.mset1.EnforceConstraints = false;
            this.mset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;

            hardware_mails = new PService.monitorDataSetTableAdapters.hardware_mail_listTableAdapter();
            software_mails = new PService.monitorDataSetTableAdapters.software_mail_listTableAdapter();
            hardwaresTableAdapter = new PService.monitorDataSetTableAdapters.hardwaresTableAdapter();
            softwareTableAdapter = new PService.monitorDataSetTableAdapters.softwareTableAdapter();
            _monitoringTableAdapter = new monitoringTableAdapter();
            _usersTableAdapter = new usersTableAdapter();

            tableAdapterManager =  new PService.monitorDataSetTableAdapters.TableAdapterManager();
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.hardware_mail_listTableAdapter = null;
            this.tableAdapterManager.hardwaresTableAdapter = null;
            this.tableAdapterManager.monitoringTableAdapter = _monitoringTableAdapter;
            this.tableAdapterManager.software_mail_listTableAdapter = null;
            this.tableAdapterManager.softwareTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PService.monitorDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;

            this.fMain = fMain;
        }


        private void AddToListBox(object oo)
        {
            fMain.Invoke(new MethodInvoker(
                           delegate { fMain.lbLog.Items.Add(oo); }
                           ));
        }


        public void scan()
        {
            needStop = false;
            predRefresh = 0;
            lastStart.Clear();
            taskId.Clear();
            tasks.Clear();

            AddToListBox("Старт мониторинга");
            while (!needStop)
            {
                if ((DateTime.Now.Ticks - predRefresh) > Properties.Settings.Default.db_refresh * 10000000)
                {
                    AddToListBox("Конфигурация обновляется..." + (DateTime.Now.Ticks - predRefresh) + " " + (Properties.Settings.Default.db_refresh * 10000000));
                    predRefresh = DateTime.Now.Ticks;
                    hardwaresTableAdapter.Fill(mset1.hardwares);
                    softwareTableAdapter.Fill(mset1.software);
                    hardware_mails.Fill(mset1.hardware_mail_list);
                    software_mails.Fill(mset1.software_mail_list);
                    _usersTableAdapter.Fill(mset1.users);

                    AddToListBox("Конфигурация обновлена");
                    //AddToListBox("Количество тестов:" + mset1.software.Count);
                }


                foreach (monitorDataSet.softwareRow l in mset1.software.Rows)
                {
                    if (!taskId.ContainsValue(l.id) && (!lastStart.ContainsKey(l.id) || ((DateTime.Now.Ticks - lastStart[l.id]) > l.req_interval_sec * 10000000)))
                    {
                        ITest test;
                        switch (l.id_check_type)
                        {
                            case 1 :
                                {
                                    test = new TPing(l.hardwaresRow.ip_address);
                                    break;
                                }
                            case 2 :
                                {
                                    test = new TTracert(l.hardwaresRow.ip_address);
                                    break;
                                }
                            case 3 :
                                {
                                    test = new TWMIDriver(l.hardwaresRow.ip_address, l.login, l.password);
                                    break;
                                }
                            case 4 :
                                {
                                  
                                    test = new TSNMPcheck(l.hardwaresRow.ip_address, l.comment, mset1.hardwares.Select(r => r.ip_address).ToList());
                                    break
                                    ;
                                }
                            case 5 :
                                {
                                    test = new TPort(l.hardwaresRow.ip_address, l.port);
                                    break;
                                }
                            case 6 :
                                {
                                    test = new TSql(l.hardwaresRow.ip_address, l.port, l.login, l.password, l.comment);
                                    break;

                                }
                                
                        }


                        Task<PResult> tt = Task<PResult>.Factory.StartNew(new TPing(l.hardwaresRow.ip_address).getTest);

                        taskId.Add(tt.Id, l.id);
                        tasks.Add(tt)
                            ;
                        if (lastStart.ContainsKey(l.id))
                        {
                            lastStart.Remove(l.id);
                        }
                        lastStart.Add(l.id, DateTime.Now.Ticks);
                        ;
                        AddToListBox(tt.Id + " "+ l.id + " "  + l.hardwaresRow.ip_address);
                    }
                }

                List<Task<PResult>> rr = new List<Task<PResult>>(tasks);

                foreach (Task<PResult> task in rr)
                 {
                    if (task.Status == TaskStatus.RanToCompletion)
                    {
                        PResult result = task.Result;
                        AddToListBox(task.Id + " " + result);
                        


                        if (result.errCode != 0)
                        {
                            monitorDataSet.monitoringRow row = mset1.monitoring.NewmonitoringRow();
                            row.dt = DateTime.Now;
                            row.id_software = taskId[task.Id];
                            row.is_active = 1;
                            row.valuee = result.errCode;
                            row.id_action = 1;
                            row.comment = result.message + (result.exception != null ? result.exception.Message : "");
                            mset1.monitoring.Rows.Add((row));
                            tableAdapterManager.UpdateAll(this.mset1);

                            try
                            {
                                SGmail mail = new SGmail(Properties.Settings.Default.system_mail, Properties.Settings.Default.mail_password, Properties.Settings.Default.smtp_server, Properties.Settings.Default.smpt_port);

                                foreach (monitorDataSet.software_mail_listRow sMail in mset1.software_mail_list.Where(a => a.id_software == taskId[task.Id]))
                                {
                                    mail.send(sMail.usersRow.mail, result.message + (result.exception != null ? result.exception.Message : ""));
                                }
                               }catch(Exception e)
                            {
                                AddToListBox("Cant send mail " + e.Message);
                            }

                        }
                        taskId.Remove(task.Id);
                        tasks.Remove(task);

                    }else
                    {
                        //AddToListBox(task.Id + " " + task.Status);
                    }
                 }


                Thread.Sleep(100);
            }
            ;


           
            AddToListBox("Стоп мониторинга");
        } 



    }
}
