using System;
using System.Collections.Generic;
using System.Text;

namespace god_does_it.Model
{
    public sealed class FakeDatabase
    {
        private FakeDatabase() { }
        private static FakeDatabase instance = null;
        public static FakeDatabase Instance
        {
            get
            {
                if (instance == null)
                    instance = new FakeDatabase();
                return instance;
            }
            
        }

        public static void sendData()
        {

        }

        private static List<Recipient> recipients = new List<Recipient>();

        public static List<Recipient> GetRecipients()
        {
            return recipients;
        }

        public static void AddtoListRecipients(String x,String y,String z)
        {
            Recipient pol = new Recipient(x,y,z);
            recipients.Add(pol);

        }
    }
}
