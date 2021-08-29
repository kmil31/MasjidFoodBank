using System;
using System.Collections.Generic;
using System.Text;
using Realms;
using god_does_it.Model;
using god_does_it.Resources.Models;
using System.Windows.Forms;

namespace god_does_it.Model
{
    public class RealmOps
    {
        static RealmOps() { }
        Realm realm = Realm.GetInstance();


        public bool createNewObject(string name, string ic, string tele, string address)
        {
            
            try
            {
                realm.Write(() =>
                {
                    realm.Add(new User()
                    {
                        Name = name,
                        IC = ic,
                        Telephone = tele,
                        Address = address,

                    }); ;

                }
                    );
                MessageBox.Show("Data successfuly entered");
                return true;
            }
            catch (Realms.Exceptions.RealmDuplicatePrimaryKeyValueException)
            {
                MessageBox.Show("Duplicate Primary Key nigga");
                return false;
            }
        }

    }
}
