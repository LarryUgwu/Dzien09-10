using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyDoctor.App_Code
{
    public class VisitData
    {
        //pamiętać, aby po utworzeniu clasy zmienić build action na compile

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PESEL { get; set; }
        public string CardNumber { get; set; } = "";
        public int DoctorId { get; set; }
        public DateTime DateVisit { get; set; }

    }
}