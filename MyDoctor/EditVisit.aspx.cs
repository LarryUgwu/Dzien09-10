using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyDoctor
{
    public partial class EditVisit : System.Web.UI.Page
    {
        String cs = ConfigurationManager.ConnectionStrings["edoctorConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                if(Request.Params["id"] != null)
                {
                    int rowId;
                    if (!Int32.TryParse(Request.Params["id"], out rowId))
                    {
                        Response.Redirect("~/VisitList.aspx");
                    }
                    else
                    {
                        //odczyt z tablicy
                        using (MySqlConnection conn = new MySqlConnection(cs))
                        {
                            conn.Open();
                            String sql = "select * from visits where id=" + rowId;
                            MySqlDataAdapter adapter = new MySqlDataAdapter();
                            adapter.SelectCommand = new MySqlCommand(sql, conn);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if(table.Rows.Count==0)
                            {
                                Response.Redirect("~/VisitList.aspx");
                            }
                            else
                            {
                                tbHiddenId.Value = rowId.ToString();
                            }
                        }
                    }
                }
                else
                {
                    Response.Redirect("~/VisitList.aspx");
                }
            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            int status = Convert.ToInt32(ddlStatus.SelectedValue);
            if (status == 0)
            {
                lblStatus.Text = "Wybierz status";
            }
            else
            {
                String sql = "update visits set status={0} where id={1}";
                sql = String.Format(sql, status, Convert.ToUInt32(tbHiddenId.Value));

                using (MySqlConnection conn = new MySqlConnection(cs))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    Response.Redirect("~/VisitList.aspx");
                }
            }
        }
    }
}