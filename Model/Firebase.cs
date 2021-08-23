using System;
using System.Collections.Generic;
using System.Text;

namespace god_does_it.Model
{
    class Firebase
    {
        private Firebase() { }
        private static Firebase instance = null;
        public static Firebase Instance
        {
            get
            {
                if (instance == null)
                    instance = new Firebase();
                return instance;
            }

        }




    }
}
