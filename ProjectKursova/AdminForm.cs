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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            lbUser.DataSource = Performer.Items.Values.ToList();
        }

        private void ToUserForm_Click(object sender, EventArgs e)
        {
            if (Performer.Items.Values.Where(pf => pf.Login == ((Performer)lbUser.SelectedItem).Login).ToList().Count() == 0)
            {
                Performer user = new Performer() { Login = ((Performer)lbUser.SelectedItem).Login };
                DataBank.Performer = user;
            }
            else
                DataBank.Performer = Performer.Items.Values.Single(pf => pf.Login == ((Performer)lbUser.SelectedItem).Login);
            new UserForm().ShowDialog();
        }

        private void lbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFullName.Text = ((Performer)lbUser.SelectedItem).GetFullName();
            if (lbUser.SelectedItem != null)
            {
                Performer u = ((Performer)lbUser.SelectedItem);
                tbNewUserLogin.Text = u.Login;
                tbNewUserName.Text = u.Name;
                tbNewUserSurname.Text = u.Surname;
                dtpBirthday.Value = u.Birthday;

            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (tbNewUserName.Text == "")
                MessageBox.Show("Enter a name first");
            if (tbNewUserSurname.Text == "")
                MessageBox.Show("Enter a surname first");
            if (tbNewUserLogin.Text == "")
                MessageBox.Show("Enter a Login first");
            if (tbNewUserName.Text != "" && tbNewUserLogin.Text != "" && tbNewUserSurname.Text != "")
            {

                new Performer() { Name = tbNewUserName.Text, Surname = tbNewUserSurname.Text, Login = tbNewUserLogin.Text, Birthday = dtpBirthday.Value};
                
            }
            RefreshUser();
        }
        private void RefreshUser()
        {

            //lbUser.DataSource = null;
            lbUser.DataSource = Performer.Items.Values.ToList();

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (tbNewUserName.Text == "")
                MessageBox.Show("Enter a name first");
            if (tbNewUserSurname.Text == "")
                MessageBox.Show("Enter a surname first");
            if (tbNewUserLogin.Text == "")
                MessageBox.Show("Enter a Login first");
            if (lbUser.SelectedItem != null && tbNewUserName.Text != "" && tbNewUserLogin.Text != "" && tbNewUserSurname.Text != "")
            {
                ((Performer)lbUser.SelectedItem).Name = tbNewUserName.Text;
                ((Performer)lbUser.SelectedItem).Login = tbNewUserLogin.Text;
                ((Performer)lbUser.SelectedItem).Surname = tbNewUserSurname.Text;
                ((Performer)lbUser.SelectedItem).Birthday = dtpBirthday.Value;

            }

            RefreshUser();
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {

            if (lbUser.SelectedItem != null)
                Performer.Items.Remove(((Performer)lbUser.SelectedItem).Id);
            else
                MessageBox.Show("There is no one left to remove");
            RefreshUser();
        }

        private void lblClearAdminFields_Click(object sender, EventArgs e)
        {
            tbNewUserLogin.Clear();
            tbNewUserName.Clear();
            tbNewUserSurname.Clear();
            dtpBirthday.Value = DateTime.Now;
            tbNewUserLogin.Focus();
        }
    }
}
