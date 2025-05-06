using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Euro_2004_Tickets
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "admin@admin" && tbPassword.Text == "admin")
            {
                Euro2024Tickets Euro2024TicketsForm = new Euro2024Tickets();
                Euro2024TicketsForm.Show();
                this.Hide();
            }
            else
            {
                //tbEmail.Text = "ERROR : unvalid email or password";
                //tbEmail.ForeColor = System.Drawing.Color.Red;

                //tbPassword.Text = "ERROR : unvalid email or password";
                //tbPassword.ForeColor = System.Drawing.Color.Red;


            }

        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void emailLogin_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }
    }
}
