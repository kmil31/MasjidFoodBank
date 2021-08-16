using god_does_it.Model;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace god_does_it
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
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
            var db = FakeDatabase.GetRecipients();
            var x = from recipient in db
                    where recipient.Name.Contains(textBox2.Text)
                    select recipient;
            foreach (var z in x)
            {
                Console.WriteLine(z.Name + "is Found");
            }
        }
    }
}
