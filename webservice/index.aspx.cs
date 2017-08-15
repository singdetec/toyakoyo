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
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            singde_webservice.WebService_index a = new singde_webservice.WebService_index();
            string g = a.getosql();
            TextBox1.Text = g;

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}