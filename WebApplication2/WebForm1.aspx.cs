using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WcfService1;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var clients = new WcfService1.WebService1();

            Label1.Text = clients.GetSum(int.Parse(TextBox1.Text), int.Parse(TextBox2.Text)).ToString();
        }
    }
}