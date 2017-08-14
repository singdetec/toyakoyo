using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace webservice
{
    /// <summary>
    ///WebService_index 的摘要描述
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允許使用 ASP.NET AJAX 從指令碼呼叫此 Web 服務，請取消註解下列一行。
    // [System.Web.Script.Services.ScriptService]
    public class WebService_index : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int xilian(int a,int b)
        {
            return  (a+b);
        }


        [WebMethod]
        public string getosql()
        {
            string strConn = "server=//192.168.0.77,59086;database=master;User ID=singde;Password=citymulti1234;Trusted_Connection=True;";
            string path = "";
            //建立連接
            SqlConnection myConn = new SqlConnection(strConn);


            //打開連接
            myConn.Open();


            String strSQL = @"select * from TestDB.dbo.Image";


            //建立SQL命令對象
            SqlCommand myCommand = new SqlCommand(strSQL, myConn);


            //得到Data結果集
            SqlDataReader myDataReader = myCommand.ExecuteReader();



            //讀取結果
            while (myDataReader.Read())
            {
                if (myDataReader["ImageLink"].ToString() != "")
                {
                    path += myDataReader["ImageLink"].ToString();
                    
                }
            }

            return path;
        }

    }
}
