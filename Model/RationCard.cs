using System;
using System.Collections.Generic;
using System.Text;

namespace god_does_it.Model
{
    class RationCard
    {
        private List<DateTime> DatesReceived;





        public void AddStampToDates(DateTime x)
        {
            DatesReceived.Add(x);
        }
    }
}
