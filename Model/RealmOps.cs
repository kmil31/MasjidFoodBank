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


        public bool createNewObject(string name, string ic, string tele, string address,string date)
        {
            
            try
            {
                realm.Write(() =>
                {

                    var user = new User();

                    user.Name = name;
                    user.IC = ic;
                    user.Telephone = tele;
                    user.Address = address;
                    user.Dates.Add(date);
                    realm.Add(user);

                }
                    );
                MessageBox.Show("Data successfully entered");
                return true;
            }
            catch (Realms.Exceptions.RealmDuplicatePrimaryKeyValueException)
            {
                var thisUser = realm.Find<User>(ic);
                if (thisUser.Dates.Contains(date))
                {
                    MessageBox.Show("You cannot take food again for today! Come again tomorrow!");
                }
                else
                {

                    realm.Write(() =>
                    {
                        thisUser.Dates.Add(date);
                    });
                    MessageBox.Show("User already registed, added a new date");
                    return true;
                }
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


        public User searchUser(string ic)
        {
            var specificUser = realm.Find<User>(ic);
            return specificUser;
        }

    }
}
