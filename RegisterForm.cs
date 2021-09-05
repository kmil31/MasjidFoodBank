using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
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
            RealmOps realmops = new RealmOps();
            //need to check validity of data
            if(CheckValidity(NameBox.Text, ICBox.Text, AddressBox.Text,ContactNumberBox.Text) == false)
            {
                MessageBox.Show("Make sure IC or Name is properly put. Address is optional ", "Data Input Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(realmops.createNewObject(NameBox.Text, ICBox.Text,  ContactNumberBox.Text, AddressBox.Text,DateTime.Now.ToString("dd MMMM yyyy")))
                {
                    NameBox.Text = null;
                    ICBox.Text = null;
                    AddressBox.Text = null;
                    ContactNumberBox.Text = null;
                    // clear the textboxes because of a successful transaction
                }
                else
                {
                    // don't clear the textbox because of error in the input.
                }
              
            }
            

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private Boolean CheckValidity(String name, String IC, String Address,String PhoneNum)
        {
            if(String.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("False");
                return false;
            }
            if (String.IsNullOrWhiteSpace(IC))
            {
                Console.WriteLine("No IC value");
                return false;

            }
            if(!Regex.IsMatch(IC, @"^[Z0-9]+$")){
                return false;
            }
            if(!Regex.IsMatch(PhoneNum, @"^[Z0-9]+$")){
               /* MessageBox.Show()*/
                return false;
            }
            else { return true; }
        }
    }
}
