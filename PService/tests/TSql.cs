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

        public TSql(String ip, int port)
        {
            this.ip = ip;
            this.port = port;
        }


        public PResult getTest()
        {
             try{

                System.Data.SqlClient.SqlConnection conn;
                conn = new System.Data.SqlClient.SqlConnection();
                 conn.ConnectionString =
                     "Data Source=" + ip + "," + port + ";Network Library=DBMSSOCN;Initial Catalog=monitor;User ID=sa;Password=12345678";

                 conn.Open();

                 conn.Close();

                 PResult rr = new PResult();
                 rr.errCode = 0;
                 //rr.exception = String.Empty;
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
