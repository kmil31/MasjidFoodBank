using System;
using System.Collections.Generic;
using System.Text;

namespace god_does_it
{
    public class Recipient
    {
        public String Name { get; set; }
        public String IdNumber { get; set; }
        public String Address { get; set; }
        private Boolean HasReceived { get; set; }
        private List<String> DatesReceived;
      

        public Recipient(string x, string y, string z)
        {
            this.Name = x;
            this.IdNumber = y;
            this.Address = z;
        }

        public void AddStampToDates(DateTime x)
        {
            DatesReceived.Add(x.ToShortDateString());
        }

    }
}
