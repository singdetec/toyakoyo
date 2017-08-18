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
        public string Request_AllItems()
        {
            string path = string.Empty;  //宣告回傳變數
            SqlDataReader myDataReader = null;  //宣告容器
            String sql = @"select * from TestDB.dbo.Image";  //宣告SQL
            try{
                SQLcmd.Query(sql, ref myDataReader);
                while (myDataReader.Read()) {
                    if (myDataReader["ImageLink"].ToString() != "") path += myDataReader["ImageLink"].ToString();
                }
            }
            catch (Exception ex){return ex.Message;}
            return path;
        } //getosql()

    }
}