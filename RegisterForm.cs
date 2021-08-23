using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using god_does_it.Model;


namespace god_does_it
{
    public partial class RegisterForm : Form
    {
        
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void submitRegistrationBtn_Click(object sender, EventArgs e)
        {
            //need to check validity of data
            if(CheckValidity(textBox5.Text, textBox6.Text, textBox7.Text) == false)
            {
                MessageBox.Show("Make sure IC or Name is properly put. Address is optional ", "Data Input Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FakeDatabase.AddtoListRecipients(textBox5.Text, textBox6.Text, textBox7.Text);
                var list = FakeDatabase.GetRecipients();
                foreach (Recipient person in list)
                {
                    Console.WriteLine(person.Name + " " + person.IdNumber + " " + person.Address);
                }
                textBox5.Text = null;
                textBox6.Text = null;
                textBox7.Text = null;
            }
            

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private Boolean CheckValidity(String name, String IC, String Address)
        {
            if(String.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("False");
                return false;
            }
            else if (String.IsNullOrWhiteSpace(IC))
            {
                Console.WriteLine("No IC value");
                return false;

            }
            else { return true; }
        }
    }
}
