using god_does_it.Model;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using god_does_it.Resources.Models;

namespace god_does_it
{
    public partial class SearchForm : Form
    {
        public RealmOps realmops = new RealmOps();
        private static string Hello_World = "Yes";
        private static String htmltext = $@"
            <style>
                h1 {{ text-align:center; }}
                body {{ background-color : #1abc9c; }}
            </style>
            <body>
                <p><h1>{Hello_World}</h1>This is html rendered text</p>
            </body>";


        public SearchForm()
        {
            InitializeComponent();
            htmlPanel1.Text = htmltext.Normalize();
        }


        private void SearchForm_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {


            htmlPanel1.Text = GenerateNewHTML(realmops.QueryUserData(textBox2.Text));
            textBox2.Text = null;
          
            

        }

        private void htmlPanel1_Click(object sender, EventArgs e)
        {

        }
        private string GenerateNewHTML(User user)
        {
            var IC = String.Empty;
            var Telephone = String.Empty;
            var Address = String.Empty;
            var table = String.Empty;
            var temp = String.Empty;
            string htmltext2 = string.Empty;
            if (user.Dates != null)
            {
                foreach (var x in user.Dates)
                {
                    temp = "<tr>" + "<td>" + x + "</td>" + "</tr>";
                    table += temp;
                }

                /*RealmOps realmops = new RealmOps();
                User d = realmops.QueryUserData(x);*/
                htmltext2 = $@"
            <style>
                h1 {{ text-align:center; }}
                body {{ background-color : #1abc9c; }}
            </style>
            <body>
                <p><h1>{Name = user.Name}</h1></p></br>
                <div>
                    Address : {Address = user.Address} </br>
                    IC      : {IC = user.IC}</br>
                    Phone Number:{Telephone = user.Telephone} </br>
                </div>
                <div>
                    <table>
                        {table}
                    </table>
                </div>
            </body>";
            }
            


            return htmltext2;


        }




    }
}

