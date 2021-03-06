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
            Performer us1 = new Performer() { Name = "Nazar", Surname = "Petrakov", Birthday = new DateTime(2004, 9, 6), Login = "nazarPetrakov11" };
            Performer us2 = new Performer() { Name = "Volodimyr", Surname = "Zelenskiy", Birthday = new DateTime(1978, 1, 25), Login = "prezidentN1" };
            Performer us3 = new Performer() { Name = "Vlad", Surname = "Valerko", Birthday = new DateTime(2004, 6, 26), Login = "vladvp" };

            ProjectList list1 = new ProjectList() { Name = "Game Dota 3", Performer = us1 };
            ProjectList list2 = new ProjectList() { Name = "House", Performer = us1 };
            ProjectList list21 = new ProjectList() { Name = "Infrastructure", Performer = us2 };
            ProjectList list22 = new ProjectList() { Name = "GreenCounry", Performer = us2 };
                    
            ListTask el1 = new ListTask() { Name = "Models", ProjectList = list1, };
            ListTask el2 = new ListTask() { Name = "Grapgics", ProjectList = list1, };
            ListTask el3 = new ListTask() { Name = "Animation", ProjectList = list1, };
            ListTask ele1 = new ListTask() { Name = "Foundation", ProjectList = list2, };
            ListTask ele2 = new ListTask() { Name = "Walls", ProjectList = list2, };
            ListTask ele3 = new ListTask() { Name = "Windows", ProjectList = list2, };
            ListTask ele4 = new ListTask() { Name = "Roof", ProjectList = list2, };
            ListTask elem1 = new ListTask() { Name = "Build", ProjectList = list21, };
            ListTask eleme1 = new ListTask() { Name = "Trees", ProjectList = list22, };
            

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
           
            if (tbLogin.Text != "")
            {
                if (Performer.Items.Values.Where(pf => pf.Login == tbLogin.Text).ToList().Count() == 0)
                {
                    MessageBox.Show("The Login you entered is incorrect");
                    

                }
                else
                {
                    DataBank.Performer = Performer.Items.Values.Single(pf => pf.Login == tbLogin.Text);
                    tbLogin.Clear();
                    new UserForm().ShowDialog();
                }
                

            }
            else
                MessageBox.Show("The Login you entered is incorrect");

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == "admin")
            {
                tbLogin.Clear();
                new AdminForm().ShowDialog();
            }
            else
                MessageBox.Show("Enter an administration Login first");
        }


        private void lblToSignUp_Click(object sender, EventArgs e)
        {
            new SignUpForm().ShowDialog();
        }
    }
}
