using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppExample
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblInfo.Text = "Nagłówki HTTP<br>";

            foreach (string key in Request.Headers.AllKeys)
            {
                lblInfo.Text += String.Format("{0} - {1}<br>", key, Request.Headers[key]);
            }

            lblInfo.Text += "Metoda Http: " + Request.HttpMethod + "<br/>";
            lblInfo.Text += "Query String: " + Request.QueryString + "<br/>";
            lblInfo.Text += "Raw URL: " + Request.RawUrl + "<br/>";

            lblInfo.Text += "Ciasteczka: <br/>";
            foreach (string key in Request.Cookies.AllKeys)
            {
                lblInfo.Text += String.Format("{0} - {1}<br>", key, Request.Cookies[key].Value);
            }
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            lblName.Text = "Twoje imie to: " + tbName.Text;
            Response.SetCookie(new HttpCookie("ts", DateTime.Now.ToString()));
        }
    }
}