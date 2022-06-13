
namespace ProjectKursova
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbLists = new System.Windows.Forms.ListBox();
            this.lblProjects = new System.Windows.Forms.Label();
            this.lbTasks = new System.Windows.Forms.ListBox();
            this.lblTasks = new System.Windows.Forms.Label();
            this.btnAddProjectcs = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbProjects = new System.Windows.Forms.TextBox();
            this.tbTasks = new System.Windows.Forms.TextBox();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.lblYourLogin = new System.Windows.Forms.Label();
            this.btnStartTask = new System.Windows.Forms.Button();
            this.btnCompiteTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLists
            // 
            this.lbLists.FormattingEnabled = true;
            this.lbLists.ItemHeight = 16;
            this.lbLists.Location = new System.Drawing.Point(56, 141);
            this.lbLists.Name = "lbLists";
            this.lbLists.Size = new System.Drawing.Size(120, 212);
            this.lbLists.TabIndex = 0;
            this.lbLists.SelectedIndexChanged += new System.EventHandler(this.lbLists_SelectedIndexChanged);
            // 
            // lblProjects
            // 
            this.lblProjects.AutoSize = true;
            this.lblProjects.Location = new System.Drawing.Point(56, 104);
            this.lblProjects.Name = "lblProjects";
            this.lblProjects.Size = new System.Drawing.Size(92, 17);
            this.lblProjects.TabIndex = 1;
            this.lblProjects.Text = "Your projects";
            // 
            // lbTasks
            // 
            this.lbTasks.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbTasks.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbTasks.FormattingEnabled = true;
            this.lbTasks.ItemHeight = 16;
            this.lbTasks.Location = new System.Drawing.Point(293, 141);
            this.lbTasks.Name = "lbTasks";
            this.lbTasks.Size = new System.Drawing.Size(120, 212);
            this.lbTasks.TabIndex = 2;
            this.lbTasks.SelectedIndexChanged += new System.EventHandler(this.lbTasks_SelectedIndexChanged);
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Location = new System.Drawing.Point(293, 103);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(46, 17);
            this.lblTasks.TabIndex = 3;
            this.lblTasks.Text = "Tasks";
            // 
            // btnAddProjectcs
            // 
            this.btnAddProjectcs.Location = new System.Drawing.Point(55, 396);
            this.btnAddProjectcs.Name = "btnAddProjectcs";
            this.btnAddProjectcs.Size = new System.Drawing.Size(41, 42);
            this.btnAddProjectcs.TabIndex = 4;
            this.btnAddProjectcs.Text = "+";
            this.btnAddProjectcs.UseVisualStyleBackColor = true;
            this.btnAddProjectcs.Click += new System.EventHandler(this.btnAddProjectcs_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(103, 396);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(44, 42);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(153, 396);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(40, 42);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbProjects
            // 
            this.tbProjects.Location = new System.Drawing.Point(55, 368);
            this.tbProjects.Name = "tbProjects";
            this.tbProjects.Size = new System.Drawing.Size(120, 22);
            this.tbProjects.TabIndex = 7;
            // 
            // tbTasks
            // 
            this.tbTasks.Location = new System.Drawing.Point(293, 368);
            this.tbTasks.Name = "tbTasks";
            this.tbTasks.Size = new System.Drawing.Size(120, 22);
            this.tbTasks.TabIndex = 11;
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(391, 396);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(40, 42);
            this.btnRemoveTask.TabIndex = 10;
            this.btnRemoveTask.Text = "-";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // btnEditTask
            // 
            this.btnEditTask.Location = new System.Drawing.Point(341, 396);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(44, 42);
            this.btnEditTask.TabIndex = 9;
            this.btnEditTask.Text = "Edit";
            this.btnEditTask.UseVisualStyleBackColor = true;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(293, 396);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(41, 42);
            this.btnAddTask.TabIndex = 8;
            this.btnAddTask.Text = "+";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // lblYourLogin
            // 
            this.lblYourLogin.AutoSize = true;
            this.lblYourLogin.Location = new System.Drawing.Point(22, 20);
            this.lblYourLogin.Name = "lblYourLogin";
            this.lblYourLogin.Size = new System.Drawing.Size(40, 17);
            this.lblYourLogin.TabIndex = 12;
            this.lblYourLogin.Text = "Hello";
            // 
            // btnStartTask
            // 
            this.btnStartTask.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStartTask.Location = new System.Drawing.Point(515, 308);
            this.btnStartTask.Name = "btnStartTask";
            this.btnStartTask.Size = new System.Drawing.Size(75, 65);
            this.btnStartTask.TabIndex = 13;
            this.btnStartTask.Text = "Start";
            this.btnStartTask.UseVisualStyleBackColor = false;
            this.btnStartTask.Click += new System.EventHandler(this.btnStartTask_Click);
            // 
            // btnCompiteTask
            // 
            this.btnCompiteTask.Location = new System.Drawing.Point(609, 308);
            this.btnCompiteTask.Name = "btnCompiteTask";
            this.btnCompiteTask.Size = new System.Drawing.Size(75, 65);
            this.btnCompiteTask.TabIndex = 14;
            this.btnCompiteTask.Text = "Comlete";
            this.btnCompiteTask.UseVisualStyleBackColor = true;
            this.btnCompiteTask.Click += new System.EventHandler(this.btnCompiteTask_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCompiteTask);
            this.Controls.Add(this.btnStartTask);
            this.Controls.Add(this.lblYourLogin);
            this.Controls.Add(this.tbTasks);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.tbProjects);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddProjectcs);
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.lbTasks);
            this.Controls.Add(this.lblProjects);
            this.Controls.Add(this.lbLists);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLists;
        private System.Windows.Forms.Label lblProjects;
        private System.Windows.Forms.ListBox lbTasks;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.Button btnAddProjectcs;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbProjects;
        private System.Windows.Forms.TextBox tbTasks;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label lblYourLogin;
        private System.Windows.Forms.Button btnStartTask;
        private System.Windows.Forms.Button btnCompiteTask;
    }
}