using MyDoctor.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyDoctor
{
    public partial class RegisterVisit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cbVip_CheckedChanged(object sender, EventArgs e)
        {
            tbVipNumber.Visible = cbVip.Checked;
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            if (Page.IsValid) //czy fromularz zawiera poprawne dane
            {
                VisitData data = new VisitData();
                data.FirstName = tbFName.Text;
                data.LastName = tbLName.Text;
                data.Email = tbMail.Text;
                data.PESEL = tbPesel.Text;
                data.CardNumber = tbVipNumber.Text;
                data.DateVisit = calVisitDate.SelectedDate;
                data.DoctorId = Convert.ToInt32(ddDoctor.SelectedValue);

                Session["RegForm"] = data; //zebranie w koszyk powyższych danych

                //przerzucenie użytkownika na inna stronę

                Response.Redirect("~/RegisterVisit2.aspx"); //good practice = ~/
            }
        }
    }
}