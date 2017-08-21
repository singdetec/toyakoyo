using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

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
        public static string strConn = WebConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString.ToString();
        [WebMethod]
        public string Request_AllItems()
        {
            string path = string.Empty;  //宣告回傳變數
            SqlDataReader myDataReader = null;  //宣告容器
            String sql = @"select * from TestDB.dbo.Image";  //宣告SQL
            try{
                SqlConnection myConn = new SqlConnection(strConn);
                myConn.Open();
                SqlCommand myCommand = new SqlCommand(sql, myConn);
                myDataReader = myCommand.ExecuteReader();
                while (myDataReader.Read()) {
                    if (myDataReader["ImageLink"].ToString() != "") path += myDataReader["ImageLink"].ToString();
                }
                myConn.Close();
            }
            catch (Exception ex){return ex.Message;}
            return path;
        } //Request_AllItems()


        [WebMethod]
        public void Log(string Description) {
            string sql = @"Insert into TestDB.dbo.WebLog (comname,description) Values(@comname,@description)";
            try
            {
                SqlConnection myConn = new SqlConnection(strConn);
                myConn.Open();
                SqlCommand myCommand = new SqlCommand(sql, myConn);
                myCommand.Parameters.AddWithValue("@comname", Environment.MachineName);
                myCommand.Parameters.AddWithValue("@description", Description);
                myCommand.ExecuteNonQuery();
                myConn.Close();
            }
            catch (Exception ex) { }
        }//Log()


        [WebMethod]
        public string CheckMemberAccount(string account) {


            return "f";
        }//CheckMemberAccount()


        [WebMethod]
        public string RegisterAccount(byte[] account,byte[] password) {
            string result = string.Empty;
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            
      
      // 解密。
       byte[] decryptedData_account = rsa.Decrypt(account, false);
       string decryptedText_account = Encoding.Default.GetString(decryptedData_account);
       byte[] decryptedData_password = rsa.Decrypt(password, false);
       string decryptedText_password = Encoding.Default.GetString(decryptedData_password);



            return decryptedText_account + "," + decryptedText_password;
        }//RegisterAccount()

    }
}