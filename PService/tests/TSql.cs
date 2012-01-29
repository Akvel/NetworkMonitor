using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PService.tests
{
    public class TSql : ITest
    {
        private String ip;
        private int port;
        private string login;
        private string password;
        private string db;

        public TSql(String ip, int port, string login, string password, string db)
        {
            this.ip = ip;
            this.port = port;

            this.login = login;
            this.password = password;
            this.db = db;
        }


        public PResult getTest()
        {
             try{

                System.Data.SqlClient.SqlConnection conn;
                conn = new System.Data.SqlClient.SqlConnection();
                 conn.ConnectionString =
                     "Data Source=" + ip + "," + port + ";Network Library=DBMSSOCN;Initial Catalog="+db+";User ID="+login+";Password=" + password;

                 conn.Open();

                 conn.Close();

                 PResult rr = new PResult();
                 rr.errCode = 0;
                 rr.message = "Ok";

                 return rr;

             }catch( Exception e)
            {
                PResult rr = new PResult();
                rr.errCode = -1;
                rr.exception = e;
                rr.message = e.Message;

                return rr;
            }
        }
    }
}
