using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq.SqlClient;

namespace WebApplicationSportSearch
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            sportDBDataContext dbb = new sportDBDataContext();

            MainSport spp = new MainSport();

            spp.Имя = TextBox1.Text;
            spp.Фамилия = TextBox2.Text;
            spp.Возраст = TextBox3.Text;
            spp.Вес = TextBox4.Text;
            spp.КолТравм = TextBox5.Text;
            spp.Соревнование = TextBox6.Text;

            dbb.MainSport.InsertOnSubmit(spp);
            dbb.SubmitChanges();

            Response.Redirect("/Main.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string Имя = TextBox1.Text;
            string Фамилия = TextBox2.Text;
            string Возраст = TextBox3.Text;
            string Вес = TextBox4.Text;
            string КолТравм = TextBox5.Text;
            string Соревнование = TextBox6.Text;
            string Filter = "";
            
            if (Имя != "") { Filter = Filter + " Имя like '%" + Имя + "%' and ";}
            if (Фамилия != "") { Filter = Filter + " Фамилия like '%" + Фамилия + "%' and "; }
            if (Возраст != "") { Filter = Filter + " Возраст like '%" + Возраст + "%' and "; }
            if (Вес != "") { Filter = Filter + " Вес like '%" + Вес + "%' and "; }
            if (КолТравм != "") { Filter = Filter + " КолТравм like '%" + КолТравм + "%' and "; }
            if (Соревнование != "") { Filter = Filter + " Соревнование like '%" + Соревнование + "%' and "; }

            if (Filter.Length > 0)
            { 
                string FinalFilter = Filter.Remove(Filter.Length - 4, 3);
                SqlDataSource1.FilterExpression = FinalFilter;
            }
            else 
            {
                GridView1.DataBind();
            }
        }
    }
}