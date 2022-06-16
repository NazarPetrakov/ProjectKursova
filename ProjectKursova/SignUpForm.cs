using Projects.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectKursova
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void lblClearSignInFields_Click(object sender, EventArgs e)
        {
            tbSignUpLogin.Clear();
            tbSignUpName.Clear();
            tbSignUpSurname.Clear();
            dtpSignUpBirthday.Value = DateTime.Now;
            tbSignUpLogin.Focus();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (tbSignUpName.Text == "")
                MessageBox.Show("Enter a name first");
            if (tbSignUpSurname.Text == "")
                MessageBox.Show("Enter a surname first");
            if (tbSignUpLogin.Text == "")
                MessageBox.Show("Enter a Login first");
            if (tbSignUpName.Text != "" && tbSignUpLogin.Text != "" && tbSignUpSurname.Text != "")
            {
                if (Performer.Items.Values.Where(pf => pf.Login == tbSignUpLogin.Text).ToList().Count() == 0)
                {
                    new Performer() { Name = tbSignUpName.Text, Surname = tbSignUpSurname.Text, Login = tbSignUpLogin.Text, Birthday = dtpSignUpBirthday.Value };
                    this.Close();
                }
                else
                    MessageBox.Show("This Login already exists");

            }
            
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
