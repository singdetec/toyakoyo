using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
    }
}