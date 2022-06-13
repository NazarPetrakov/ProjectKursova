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
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Performer us1 = new Performer() { Name = "Nazar", SurName = "Petrakov", Age = 17, Login = "nazarPetrakov11" };
            Performer us2 = new Performer() { Name = "Volodimyr", SurName = "Zelenskiy", Age = 44, Login = "prezidentN1" };

            ProjectList list1 = new ProjectList() { Name = "Dota3", Performer = us1 };
            ListTask el1 = new ListTask() { Name = "Models", ProjectList = list1,};
            ListTask el2 = new ListTask() { Name = "Grapgics", ProjectList = list1,};
            ListTask el3 = new ListTask() { Name = "Animation", ProjectList = list1,};

            ProjectList list2 = new ProjectList() { Name = "House", Performer = us1 };
            ListTask ele1 = new ListTask() { Name = "Foundation", ProjectList = list2,};
            ListTask ele2 = new ListTask() { Name = "Walls", ProjectList = list2,};
            ListTask ele3 = new ListTask() { Name = "Windows", ProjectList = list2,};
            ListTask ele4 = new ListTask() { Name = "Roof", ProjectList = list2,};

            
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            DataBank.Text = tbLogin.Text;
            if (tbLogin.Text != "")
            {
                new UserForm().ShowDialog();
                new Performer() { Login = tbLogin.Text };
            }
            else
                MessageBox.Show("You did not enter a Login");
            
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == "admin")
            {
                new AdminForm().ShowDialog();
            }
            else
                MessageBox.Show("You did not enter an administration Login");
        }
    }
}
