using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationSportSearch
{
    public partial class Enter : System.Web.UI.Page
    {
        string user = "Dima";
        string pass = "12345";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == user)
            {
               if (TextBox2.Text == pass)
               {
                    Response.Redirect("/Main.aspx");
               }
            }
            else
            {
                Label1.Text = "Неверный логин или пароль!";
            }
        }
    }
}