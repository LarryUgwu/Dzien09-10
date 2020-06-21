using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppExample.App_Code
{
    public class City
    {
        int id;
        string name;

        public City(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id { get { return id; } }
        public string Name { get {return name; } }
    }
}