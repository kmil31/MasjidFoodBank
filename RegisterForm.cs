using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Google.Cloud.Firestore;


namespace god_does_it
{

  

    public partial class RegisterForm : Form
    {

        FirestoreDb database;

        public RegisterForm()
        {
            InitializeComponent();
          
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            database = FirestoreDb.Create("foodbank-masjid");

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitRegistrationBtn_Click(object sender, EventArgs e)
        {

            createDocument();
            
        
        }

        void createDocument()
        {
            DocumentReference Doc = database.Collection("users").Document(IC.Text);
            Dictionary<string, object> data1 = new Dictionary<string, object>()
            {
                {"name",userName.Text },
                {"address",address.Text },
                {"date","21/shit/2021" }
            };

            Doc.SetAsync(data1);
            MessageBox.Show("Success!");

        }
    }
}
