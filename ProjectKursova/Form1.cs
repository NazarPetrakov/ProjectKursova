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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProjectList list1 = new ProjectList() { Name = "Dota3" };
            ListTask el1 = new ListTask() { Name = "Models", ProjectList = list1 };
            ListTask el2 = new ListTask() { Name = "Grapgics", ProjectList = list1 };
            ListTask el3 = new ListTask() { Name = "Animation", ProjectList = list1 };
        }

        private void btnLists_Click(object sender, EventArgs e)
        {
            new FormLists().ShowDialog();
        }
    }
}
