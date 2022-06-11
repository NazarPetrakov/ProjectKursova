using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projects.Data;

namespace ProjectKursova
{
    public partial class FormLists : Form
    {
        public FormLists()
        {
            InitializeComponent();
        }
        
        private void FormLists_Load(object sender, EventArgs e)
        {
            lbLists.DataSource = ProjectList.Items.Values.ToList();
        }
    }
}
