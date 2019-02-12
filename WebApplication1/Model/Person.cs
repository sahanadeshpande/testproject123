using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Model
{
    public class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }

        private DateTime _dobvalue;
        public string DOB
        {
            get { return _dobvalue.ToString(); }
            set { DateTime.TryParse(value, out _dobvalue); }
        }

        public string Address { get; set; }
    }
}