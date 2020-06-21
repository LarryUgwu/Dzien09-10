using MyDoctor.App_Code;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyDoctor
{
    public partial class RegisterVisit2 : System.Web.UI.Page
    {
        VisitData data = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                data = Session["RegForm"] as VisitData;
                lblDescr.Text = String.Format("{0} {1}", data.FirstName, data.LastName);
                //czyszczenie sesji
                //Session["RegForm"] = null;

            } 
            catch(Exception exc)
            {
                Response.Redirect("~/RegisterVisit.aspx");
            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            String filename = null;
            bool isOk = true;

            if (fuImage.HasFile)
            {
                if(fuImage.PostedFile.ContentType=="image/png")
                {
                    if(fuImage.PostedFile.ContentLength<500000)
                    {
                        //upload do wskazanego miejsca w aplikacji
                        //nie hardkodujemy sciezki, tylko uzywamy server.mappath
                        //robimy unikalność plików tzw guid (n oznacza, ze chcemy mieć tylko znaki, bez spacji

                        filename = Guid.NewGuid().ToString("N") + "-" + Path.GetFileName(fuImage.FileName);

                        fuImage.SaveAs(Server.MapPath("~/Uploads/") + filename);
                        lblResult.Text = "OK";
                        lblResult.ForeColor = Color.Black;


                    } else
                    {
                        lblResult.Text = "Zbyt duży plik (max 500kb)";
                        lblResult.ForeColor = Color.Red;
                        isOk = false;
                    }
                } else
                {
                    lblResult.Text = "Nieprawidłowy format pliku";
                    lblResult.ForeColor = Color.Red;
                    isOk = false;
                }
            }

            //realizacja zapisu danych do bazy
            if (isOk)
            {
                //rozpocznij zapis do bazy
                String cs = "Server=127.0.0.1;Port=3306;Database=edoctor;Uid=root;Pwd=sasa";
                using (MySqlConnection conn = new MySqlConnection(cs))
                {
                    conn.Open();
                    String sql = @"
                        INSERT INTO visits
                         (fname, lname, email, pesel, doctor, visit_date, descr, image, card)
                        VALUES
                        (@fname, @lname, @email, @pesel, @doctor, @visit_date, @descr, @image, @card)
                    ";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.Add("@fname", MySqlDbType.VarChar, 50).Value = data.FirstName;
                    cmd.Parameters.Add("@lname", MySqlDbType.VarChar, 50).Value = data.LastName;
                    cmd.Parameters.Add("@email", MySqlDbType.VarChar, 250).Value = data.Email;
                    cmd.Parameters.Add("@pesel", MySqlDbType.VarChar, 20).Value = data.PESEL;
                    cmd.Parameters.Add("@doctor", MySqlDbType.Int32).Value = data.DoctorId;
                    cmd.Parameters.Add("@visit_date", MySqlDbType.Date).Value = data.DateVisit;
                    cmd.Parameters.Add("@descr", MySqlDbType.Text).Value = tbDesc.Text;
                    cmd.Parameters.Add("@image", MySqlDbType.VarChar, 1024).Value = filename;
                    cmd.Parameters.Add("@card", MySqlDbType.VarChar, 10).Value = data.CardNumber;

                    cmd.ExecuteNonQuery();

                    lblResult.Text = "Dziękujemy za zgłoszenie";
                    btnOk.Enabled = false;
                    Session.Remove("RegForm");
                }
            }
        }
    }
}