using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace webservice
{
    public class SQLcmd
    {
        public static string strConn = WebConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString.ToString();
        
        public static void Query(string sql, ref SqlDataReader myDataReader)
        {
            try
            {
                SqlConnection myConn = new SqlConnection(strConn);
                myConn.Open();
                SqlCommand myCommand = new SqlCommand(sql, myConn);
                myDataReader = myCommand.ExecuteReader();
                myConn.Close();
            }
            catch (Exception ex){throw new System.ArgumentException(ex.Message);}
        } //NonQuery


        public void log(string Message) {


        }//log

    }
}