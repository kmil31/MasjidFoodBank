using god_does_it.Model;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace god_does_it
{
    public partial class SearchForm : Form
    {
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Hello_World = textBox2.Text;
            htmlPanel1.Text = GenerateNewHTML(textBox2.Text).Normalize() ;
            textBox2.Text = null;
           /* var db = FakeDatabase.GetRecipients();
            var x = from recipient in db
                    where recipient.Name.Contains(textBox2.Text)
                    select recipient;
            foreach (var z in x)
            {
                Console.WriteLine(z.Name + "is Found");
            }*/
        }

        private void htmlPanel1_Click(object sender, EventArgs e)
        {

        }
        private String GenerateNewHTML(string x)
        {
            Recipient SomeOne = Firebase.QueryRecipient(x).Result;

            var htmltext2 = $@"
            <style>
                h1 {{ text-align:center; }}
                body {{ background-color : #1abc9c; }}
            </style>
            <body>
                <p><h1>{SomeOne.Name}</h1></p></br>
                <div>
                    Address : {SomeOne.Address}</br>
                    IC      : {SomeOne.IdNumber}</br>
                    Phone Number: {SomeOne.PhoneNumber}</br>
                </div>
            </body>";

            return htmltext2;
        }
    }
}
