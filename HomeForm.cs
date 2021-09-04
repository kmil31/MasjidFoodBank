using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace god_does_it
{

    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            openChildForm(new RegisterForm());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new SearchForm());

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void childFormPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
