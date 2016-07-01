using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationSportSearch
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SportDBDataContext db = new SportDBDataContext();

            MainSport sp = new MainSport();

            sp.Имя = TextBox1.Text;
            sp.Фамилия = TextBox2.Text;
            sp.Возраст = Convert.ToInt32(TextBox3.Text);
            sp.Вес = Convert.ToInt32(TextBox4.Text);
            sp.КолТравм = Convert.ToInt32(TextBox5.Text);
            sp.Соревнование = TextBox6.Text;

            db.MainSport.InsertOnSubmit(sp);
            db.SubmitChanges();

            Response.Redirect("/Main.aspx");
        }
    }
}