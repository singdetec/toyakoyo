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
         

            // 建立 CspParameters 物件，並指定 KeyContainerName
            CspParameters cspPara = new CspParameters();
            cspPara.KeyContainerName = "test secret key";
            cspPara.Flags = CspProviderFlags.UseMachineKeyStore;
            // 建立 RSA 演算法物件的執行個體，並將金鑰保存在 CSP 中
            RSACryptoServiceProvider rsaProvider = new RSACryptoServiceProvider(1024,cspPara);
            rsaProvider.PersistKeyInCsp = true;         //將金鑰存到金鑰容器

            // 將資料加密
            byte[] bytePlain = Encoding.UTF8.GetBytes(TextBox2.Text.ToString());
            byte[] byteCipher = rsaProvider.Encrypt(bytePlain, false);

            // 將加密後的資料，轉 Base64 格式輸入
           string account = Convert.ToBase64String(byteCipher);
            TextBox4.Text = WebserviceFuntion.RegisterAccount(account);
        }
    }
}