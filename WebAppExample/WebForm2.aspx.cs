using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebAppExample.App_Code;

namespace WebAppExample
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        List<City> cities = new List<City>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cache["lista"] == null)
            { 
            cities.Add(new City(1, "Gdańsk"));
            cities.Add(new City(2, "Poznań"));
            cities.Add(new City(3, "Warszawa"));

                Cache.Add("lista", cities, null, System.Web.Caching.Cache.NoAbsoluteExpiration,
                    new TimeSpan(0, 30, 0), System.Web.Caching.CacheItemPriority.Default, null);
            } else
            {
                cities = (List<City>)Cache["lista"];
            }


            int dd1 = -1;
            if (Page.IsPostBack)
            {
                dd1 = DropDownList1.SelectedIndex;
            }

            DropDownList1.DataSource = cities;
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataBind();
            if (Page.IsPostBack)
            {
                DropDownList1.SelectedIndex = dd1;
            }

            //odczyt kontrolek
            if (Page.IsPostBack)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("checkbox = " + CheckBox1.Checked + "<br/>");
                foreach (ListItem item in CheckBoxList1.Items)
                {
                    if(item.Selected)
                    {
                        sb.Append("check box list =" + item.Value + "<br/>");
                    }
                }

                sb.Append("textbox = " + TextBox1.Text + "<br/>");

                sb.Append("drop down list 1 =" + DropDownList1.SelectedValue + "<br/>");
                sb.Append("drop down list 2 =" + DropDownList2.SelectedValue + "<br/>");

                sb.Append("listbox = " + ListBox1.SelectedValue + "<br/>");

                sb.Append("radio button list = " + RadioButtonList1.SelectedValue + "<br/>");

                Label1.Text = sb.ToString();
            }
        }
    }
}