using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyDoctor
{
    public partial class VisitList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["auth-user"]==null)
            {
                Response.Redirect("~/Login");
            }
        }

        protected void gridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                if(e.Row.Cells[8].Text=="0")
                {
                    e.Row.Cells[8].Text = "Nowy";
                }

                if (e.Row.Cells[8].Text == "1")
                {
                    e.Row.Cells[8].Text = "Akceptacja";
                }

                if (e.Row.Cells[8].Text == "-1")
                {
                    e.Row.Cells[8].Text = "Anulowano";
                }
            }
        }

        public String GetDoctor(int doctorId)
        {
            switch (doctorId)
            {
                case 1:
                    return "Jan Kowalski";
                case 2:
                    return "Jaroslaw Ziętek";
                case 3:
                    return "Adam Nowak";
                default:
                    return "-----------";
            }
        }

        String cs = ConfigurationManager.ConnectionStrings["edoctorConnectionString"].ConnectionString;
        protected void gridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName=="DeleteRow")
            {
                //usuwamy rekord
                int rowId = Convert.ToInt32(e.CommandArgument);
                using (MySqlConnection conn = new MySqlConnection(cs))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("Delete from visits where id=" + rowId, conn);
                    cmd.ExecuteNonQuery();
                    //odświeżenie grida
                    gridView.DataBind();
                }
            }
        }
    }
}