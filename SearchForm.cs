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
           
            Hello_World = textBox2.Text;
            htmlPanel1.Text = GenerateNewHTML(textBox2.Text).Normalize() ;
            textBox2.Text = null;
         
        }

        private void htmlPanel1_Click(object sender, EventArgs e)
        {

        }
        private String GenerateNewHTML(string x)
        {
            

            var htmltext2 = $@"
            <style>
                h1 {{ text-align:center; }}
                body {{ background-color : #1abc9c; }}
            </style>
            <body>
                <p><h1></h1></p></br>
                <div>
                    Address : </br>
                    IC      : </br>
                    Phone Number: </br>
                </div>
            </body>";

            return htmltext2;
        }
    }
}
