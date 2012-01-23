using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Application = System.Windows.Forms.Application;

namespace omtsClient.Managers {
    public class Reporter {
        //Microsoft.Office.Interop.Excel.Application oXL = new Microsoft.Office.Interop.Excel.Application();
       // Microsoft.Office.Interop.Excel.Workbook theWorkbook;
        //Microsoft.Office.Interop.Excel.Worksheet worksheet;

       //private readonly ConnectionManager cMan;

        public Reporter()//ConnectionManager cMan )
        {
           // this.cMan = cMan;
        }


       

        
        public bool generate(Task task, Elt[] elts, string templatePath)
        {

            Microsoft.Office.Interop.Excel.Application oXL = new Microsoft.Office.Interop.Excel.Application(); // The excel application.
            Microsoft.Office.Interop.Excel.Workbook theWorkbook = null;	// The workbook in the excel application.
            Microsoft.Office.Interop.Excel.Worksheet worksheet; // The worksheet in the workbook.
            //
            try {
                //
                // Declare the application, workbook, and worksheet variables.
                //
               
               
                //
                // Open the Excel template and get the workbook in the Excel file.
                //

                FileInfo fEx = new FileInfo(Application.ExecutablePath);
                string SavePath = fEx.Directory.ToString();

                theWorkbook = oXL.Workbooks.Open(SavePath + templatePath, 0, true, 5, "", "", true,
                                                 Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", true,
                                                 false, 0, true);
                if (theWorkbook.Worksheets.Count > 0) {
                    //
                    // Select the sheet that the report data will be placed on.
                    //
                    worksheet = (Microsoft.Office.Interop.Excel.Worksheet)theWorkbook.Sheets[1];
                    //
                    // Activate the worksheet so that the data will show up 
                    // on this sheet.
                    //
                    worksheet.Activate();
                    
                    //
                    // Get the data from the dataset created above 
                    // and populate the spreadsheet.
                    //
                    worksheet.Cells[7,8] = task.ID; //номер заявки
                    worksheet.Cells[8,8] = task.DATE_CREATE;

                    worksheet.Cells[8,1] = task.DATA_PERFORM;
                    worksheet.Cells[9,1] = task.userPerform != null ? task.userPerform.FIO1 : ""; //omts_perform
                    addSign(worksheet, 9, 3, task.userPerform);

                    worksheet.Cells[4,12] = task.userNU != null ? task.userNU.FIO1 : ""; //nu
                    addSign(worksheet, 4, 14, task.userNU);

                    worksheet.Cells[10,12] = task.userGI != null ? task.userGI.FIO1 : ""; //gi
                    addSign(worksheet, 10, 14, task.userGI);

                    worksheet.Cells[20,8] = task.userCreator != null ? task.userCreator.FIO1 : ""; //gi
                    addSign(worksheet, 20, 10, task.userCreator);
                    


                    int row_auto = 15;
                    int row_auto_shift = 0;
                    foreach (Elt elt in elts)
                    {
                        if (elt.IS_AGREGAT)
                            continue;

                        int row_index = row_auto + row_auto_shift++;

                        Microsoft.Office.Interop.Excel.Range rng = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[row_index, 1];
                        Microsoft.Office.Interop.Excel.Range row = rng.EntireRow;
                        row.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, false);

                        int column = 1;
                        worksheet.Cells[row_index, column++] = row_auto_shift; //п/п
                        //auto
                        worksheet.Cells[row_index, column++] = elt.auto.GARAJ;
                        worksheet.Cells[row_index, column++] = elt.auto.GOS_NOMER;
                        worksheet.Cells[row_index, column++] = elt.auto.MODEL;

                        worksheet.Cells[row_index, column++] = elt.component.CATALOG_CODE;
                        worksheet.Cells[row_index, column++] = elt.component.COMPONENT_NAME;
                        //component
                        worksheet.Cells[row_index, column++] = elt.R3_CODE;

                        //counts
                        worksheet.Cells[row_index, column++] = elt.COUNT_WANT;
                        worksheet.Cells[row_index, column++] = elt.COUNT_STORAGE;
                        worksheet.Cells[row_index, column++] = elt.COUNT_MOL;
                        worksheet.Cells[row_index, column++] = elt.COUNT_NU;
                        worksheet.Cells[row_index, column++] = elt.COMMENT;
                        worksheet.get_Range("L" + row_index, "N" + row_index).Merge();
                    }
                    //если нет автотранспорта то удаляем шапку для авто
                    if (row_auto_shift == 0)
                    {
                        Microsoft.Office.Interop.Excel.Range rng = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[row_auto - 1, 1];
                        Microsoft.Office.Interop.Excel.Range row = rng.EntireRow;
                        row.Delete(Microsoft.Office.Interop.Excel.XlDeleteShiftDirection.xlShiftUp);
                        row_auto_shift = -1;
                    }


                    int row_agregat = 18 + row_auto_shift;
                    int row_agregat_shift = 0;
                    foreach (Elt elt in elts) {
                        if (!elt.IS_AGREGAT)
                            continue;

                        int row_index = row_agregat + row_agregat_shift++;

                        Microsoft.Office.Interop.Excel.Range rng = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[row_index, 1];
                        Microsoft.Office.Interop.Excel.Range row = rng.EntireRow;
                        row.Insert(Microsoft.Office.Interop.Excel.XlInsertShiftDirection.xlShiftDown, false);

                        int column = 1;
                        worksheet.Cells[row_index, column++] = row_agregat_shift; //п/п
                        //auto
                        worksheet.Cells[row_index, column++] = "'" + elt.agregat.NAME_AGREGAT;
                        worksheet.get_Range("C"+row_index, "D"+row_index).Merge();
                        
                        worksheet.Cells[row_index, column++] = "'"+elt.agregat.MODEL;
                        column++;
                        //component
                        worksheet.Cells[row_index, column++] = "'" + elt.R3_CODE;
                        worksheet.Cells[row_index, column++] = "'" + elt.component.CATALOG_CODE;
                        worksheet.Cells[row_index, column++] = "'" + elt.component.COMPONENT_NAME;
                        //counts
                        worksheet.Cells[row_index, column++] = elt.COUNT_WANT;
                        worksheet.Cells[row_index, column++] = elt.COUNT_STORAGE;
                        worksheet.Cells[row_index, column++] = elt.COUNT_MOL;
                        worksheet.Cells[row_index, column++] = elt.COUNT_NU;
                        worksheet.Cells[row_index, column++] = elt.COMMENT;
                        worksheet.get_Range("L" + row_index, "N" + row_index).Merge();
                    }

                    //если нет агрегатов то удаляем шапку для агрегатов
                    if (row_agregat_shift == 0) {
                        Microsoft.Office.Interop.Excel.Range rng = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[row_agregat - 1, 1];
                        Microsoft.Office.Interop.Excel.Range row = rng.EntireRow;
                        row.Delete(Microsoft.Office.Interop.Excel.XlDeleteShiftDirection.xlShiftUp);
                    }

                    //
                    // Save the workbook.
                    //

                    //
                    // Set the Excel application to visible.  This is not necessary
                    // but makes it easier during debugging.
                    //
                    worksheet.Protect("why_u_hack_me?",
    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
    Type.Missing, Type.Missing, Type.Missing, Type.Missing, true, Type.Missing, Type.Missing);

                    oXL.Visible = true;

                    //theWorkbook.Close();
                    //oXL = null;
                    //
                    // Return value
                    //
                    return true;
                } else {
                    
                    return false;
                }
            } catch (Exception ex) {
              
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(theWorkbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(oXL);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }
            //
            // Force garbage collection.  This will unload the 
            // Excel object from memory.
            //

          
        }



        public void openReport(string path)
        {

        }
    }
}
