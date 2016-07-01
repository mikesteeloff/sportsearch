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

            MainSport spp = new MainSport();

            spp.Имя = TextBox1.Text;
            spp.Фамилия = TextBox2.Text;
            spp.Возраст = Convert.ToInt32(TextBox3.Text);
            spp.Вес = Convert.ToInt32(TextBox4.Text);
            spp.КолТравм = Convert.ToInt32(TextBox5.Text);
            spp.Соревнование = TextBox6.Text;

            db.MainSport.InsertOnSubmit(spp);
            db.SubmitChanges();

            Response.Redirect("/Main.aspx");
        }
    }
}