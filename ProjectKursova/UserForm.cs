using Projects.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectKursova
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            lblYourLogin.Text = DataBank.Text;
            lbLists.DataSource = ProjectList.Items.Values.ToList();

        }
        private void lbLists_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbTasks.DataSource = ListTask.Items.Values.Where(lb => lb.ProjectList == lbLists.SelectedItem).ToList();
            if(lbLists.SelectedItem != null)
                tbProjects.Text = ((ProjectList)lbLists.SelectedItem).Name;
        }

        private void btnAddProjectcs_Click(object sender, EventArgs e)
        {
            new ProjectList() { Name = tbProjects.Text };
            RefreshList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbLists.SelectedItem != null)
                ((ProjectList)lbLists.SelectedItem).Name = tbProjects.Text;
            RefreshList();
        }
        private void RefreshList()
        {
            lbLists.DataSource = null;
            lbLists.DataSource = ProjectList.Items.Values.ToList();
        }
        

        private void btnRemove_Click(object sender, EventArgs e)
        {

            List<Guid> guidList = new List<Guid>();

            foreach (var lt in ListTask.Items)
            { 
                if (lt.Value.ProjectList == (ProjectList)lbLists.SelectedItem)
                {
                    guidList.Add(lt.Key);
                }
            }
            foreach (var g in guidList)
            {
                ListTask.Items.Remove(g);

            }
            ProjectList.Items.Remove(((ProjectList)lbLists.SelectedItem).Id);
            RefreshList();

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            
            new ListTask() { Name = tbTasks.Text, ProjectList = (ProjectList)lbLists.SelectedItem };
            RefreshTask();
        }
        private void RefreshTask()
        {
            lbTasks.DataSource = null;
            lbTasks.DataSource = ListTask.Items.Values.Where(lb => lb.ProjectList == lbLists.SelectedItem).ToList();
        }
        private void lbTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbTasks.SelectedItem != null)
                tbTasks.Text = ((ListTask)lbTasks.SelectedItem).Name;
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (lbTasks.SelectedItem != null)
                ((ListTask)lbTasks.SelectedItem).Name = tbTasks.Text;
            RefreshTask();
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            ListTask.Items.Remove(((ListTask)lbTasks.SelectedItem).Id);
            RefreshTask();
        }

        private void btnStartTask_Click(object sender, EventArgs e)
        {
            ((ListTask)lbTasks.SelectedItem).TaskStatus = "...";
            RefreshTask();
        }

        private void btnCompiteTask_Click(object sender, EventArgs e)
        {
            var competed = true;
            if (((ListTask)lbTasks.SelectedItem).TaskStatus == "...")
                ((ListTask)lbTasks.SelectedItem).TaskStatus = "+";
            else
                MessageBox.Show("Start the task first");

            foreach (var task in ListTask.Items.Values)
            {
                if (task.TaskStatus != "+")
                {
                    competed = false;
                }
                
            }
            if (competed)
                //Debug.WriteLine(lbLists);
                ProjectList.Items.Values.Where(it => it == lbLists.SelectedItem).First().TaskStatus = "+";

            RefreshTask();
        }
    }
}
