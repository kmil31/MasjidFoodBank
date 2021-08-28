using System;
using System.Collections.Generic;
using System.Text;
using Realms;
using god_does_it.Model;
using god_does_it.Resources.Models;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;

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
        
        public User QueryUserData(String IC)
        {
            var oldDogs =   from user in realm.All<User>()
                                         where user.IC.Equals(IC)
                                         select user;

            foreach(var x in oldDogs)
            Console.WriteLine(x);                                                                                     
            return oldDogs.FirstOrDefault() ;
                

            
        }
    }
}
