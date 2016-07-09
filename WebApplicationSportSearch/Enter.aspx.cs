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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PassDataContext bd = new PassDataContext();
            try
            {

                var userlogin = (from u in bd.Enter
                                 where u.Name == TextBox1.Text
                                 select u).ToArray();

                var userpass = (from u in bd.Enter
                                where u.Pass == TextBox2.Text
                                select u).ToArray();

                if (TextBox1.Text == userlogin[0].Name)
                {
                    if (TextBox2.Text == userpass[0].Pass)
                    {
                        Response.Redirect("/Main.aspx");
                    }

                }

            }
            catch (SystemException y) { Label1.Text = "Ошибка авторизации!"; }
        }
    }
}