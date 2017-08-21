using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;

namespace webservice
{
    public partial class index : System.Web.UI.Page
    {
        singde_webservice.WebService_index WebserviceFuntion = new singde_webservice.WebService_index();

        
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string test = WebserviceFuntion.Request_AllItems();
            TextBox1.Text = test;
            WebserviceFuntion.Log("撈取資料:Request_AllItems()");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void regsiter(object sender, EventArgs e)
        {
            string account = TextBox2.Text.ToString();
            string password = TextBox3.Text.ToString();

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            // 欲加密的原文。
            string orgText = account;

            // 加密。
            byte[] orgData_account = Encoding.Default.GetBytes(account);
            byte[] encryptedData_account = rsa.Encrypt(orgData_account, false);
            byte[] orgData_password = Encoding.Default.GetBytes(password);
            byte[] encryptedData_password = rsa.Encrypt(orgData_password, false);

        }
    }
}