using System;
using System.Collections.Generic;
using System.Text;
using Realms;

namespace god_does_it.Resources.Models
{
    public class User : RealmObject
    {
        [PrimaryKey]
        public string IC { get; set; }

        [Required]
        public string Name { get; set; }
        public string Address { get; set; }

        public string Telephone { get; set; }

        public IList<string> Dates{get;}


}   

   

}
