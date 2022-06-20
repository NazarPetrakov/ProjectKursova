
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
            this.lblYourLogin = new System.Windows.Forms.Label();
            this.btnStartTask = new System.Windows.Forms.Button();
            this.btnCompiteTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbLists
            // 
            this.lbLists.BackColor = System.Drawing.Color.White;
            this.lbLists.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLists.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbLists.FormattingEnabled = true;
            this.lbLists.ItemHeight = 20;
            this.lbLists.Location = new System.Drawing.Point(41, 131);
            this.lbLists.Name = "lbLists";
            this.lbLists.Size = new System.Drawing.Size(171, 202);
            this.lbLists.TabIndex = 0;
            this.lbLists.SelectedIndexChanged += new System.EventHandler(this.lbLists_SelectedIndexChanged);
            // 
            // lblProjects
            // 
            this.lblProjects.AutoSize = true;
            this.lblProjects.BackColor = System.Drawing.SystemColors.Window;
            this.lblProjects.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProjects.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblProjects.Location = new System.Drawing.Point(70, 95);
            this.lblProjects.Name = "lblProjects";
            this.lblProjects.Size = new System.Drawing.Size(91, 21);
            this.lblProjects.TabIndex = 1;
            this.lblProjects.Text = "PROJECTS";
            // 
            // lbTasks
            // 
            this.lbTasks.BackColor = System.Drawing.Color.White;
            this.lbTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTasks.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTasks.FormattingEnabled = true;
            this.lbTasks.ItemHeight = 18;
            this.lbTasks.Location = new System.Drawing.Point(236, 133);
            this.lbTasks.Name = "lbTasks";
            this.lbTasks.Size = new System.Drawing.Size(171, 200);
            this.lbTasks.TabIndex = 2;
            this.lbTasks.SelectedIndexChanged += new System.EventHandler(this.lbTasks_SelectedIndexChanged);
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblTasks.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTasks.ForeColor = System.Drawing.Color.White;
            this.lblTasks.Location = new System.Drawing.Point(288, 95);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(59, 21);
            this.lblTasks.TabIndex = 3;
            this.lblTasks.Text = "TASKS";
            // 
            // btnAddProjectcs
            // 
            this.btnAddProjectcs.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddProjectcs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProjectcs.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProjectcs.ForeColor = System.Drawing.Color.White;
            this.btnAddProjectcs.Location = new System.Drawing.Point(41, 406);
            this.btnAddProjectcs.Name = "btnAddProjectcs";
            this.btnAddProjectcs.Size = new System.Drawing.Size(45, 45);
            this.btnAddProjectcs.TabIndex = 4;
            this.btnAddProjectcs.Text = "+";
            this.btnAddProjectcs.UseVisualStyleBackColor = false;
            this.btnAddProjectcs.Click += new System.EventHandler(this.btnAddProjectcs_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEdit.Location = new System.Drawing.Point(92, 406);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(69, 45);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(167, 406);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(45, 45);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "-";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbProjects
            // 
            this.tbProjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbProjects.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbProjects.Location = new System.Drawing.Point(41, 348);
            this.tbProjects.Name = "tbProjects";
            this.tbProjects.Size = new System.Drawing.Size(171, 23);
            this.tbProjects.TabIndex = 7;
            this.tbProjects.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTasks
            // 
            this.tbTasks.BackColor = System.Drawing.Color.White;
            this.tbTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTasks.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbTasks.Location = new System.Drawing.Point(236, 348);
            this.tbTasks.Name = "tbTasks";
            this.tbTasks.Size = new System.Drawing.Size(171, 23);
            this.tbTasks.TabIndex = 11;
            this.tbTasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblYourLogin
            // 
            this.lblYourLogin.AutoSize = true;
            this.lblYourLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYourLogin.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblYourLogin.Location = new System.Drawing.Point(14, 38);
            this.lblYourLogin.Name = "lblYourLogin";
            this.lblYourLogin.Size = new System.Drawing.Size(91, 20);
            this.lblYourLogin.TabIndex = 12;
            this.lblYourLogin.Text = "User Login";
            // 
            // btnStartTask
            // 
            this.btnStartTask.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStartTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartTask.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartTask.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnStartTask.Location = new System.Drawing.Point(427, 277);
            this.btnStartTask.Name = "btnStartTask";
            this.btnStartTask.Size = new System.Drawing.Size(124, 42);
            this.btnStartTask.TabIndex = 13;
            this.btnStartTask.Text = "Start";
            this.btnStartTask.UseVisualStyleBackColor = false;
            this.btnStartTask.Click += new System.EventHandler(this.btnStartTask_Click);
            // 
            // btnCompiteTask
            // 
            this.btnCompiteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompiteTask.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCompiteTask.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCompiteTask.Location = new System.Drawing.Point(427, 230);
            this.btnCompiteTask.Name = "btnCompiteTask";
            this.btnCompiteTask.Size = new System.Drawing.Size(124, 41);
            this.btnCompiteTask.TabIndex = 14;
            this.btnCompiteTask.Text = "Complete";
            this.btnCompiteTask.UseVisualStyleBackColor = true;
            this.btnCompiteTask.Click += new System.EventHandler(this.btnCompiteTask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Login";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(40, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 2);
            this.panel2.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(238, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 2);
            this.panel1.TabIndex = 37;
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(236, 406);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(45, 45);
            this.btnAddTask.TabIndex = 4;
            this.btnAddTask.Text = "+";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnEditTask
            // 
            this.btnEditTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTask.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditTask.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEditTask.Location = new System.Drawing.Point(287, 406);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(69, 45);
            this.btnEditTask.TabIndex = 5;
            this.btnEditTask.Text = "EDIT";
            this.btnEditTask.UseVisualStyleBackColor = true;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRemoveTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTask.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTask.ForeColor = System.Drawing.Color.White;
            this.btnRemoveTask.Location = new System.Drawing.Point(362, 406);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(45, 45);
            this.btnRemoveTask.TabIndex = 6;
            this.btnRemoveTask.Text = "-";
            this.btnRemoveTask.UseVisualStyleBackColor = false;
            this.btnRemoveTask.Click += new System.EventHandler(this.btnRemoveTask_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Location = new System.Drawing.Point(12, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(121, 2);
            this.panel3.TabIndex = 38;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 480);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompiteTask);
            this.Controls.Add(this.btnStartTask);
            this.Controls.Add(this.lblYourLogin);
            this.Controls.Add(this.tbTasks);
            this.Controls.Add(this.tbProjects);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddTask);
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
        private System.Windows.Forms.Label lblYourLogin;
        private System.Windows.Forms.Button btnStartTask;
        private System.Windows.Forms.Button btnCompiteTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Panel panel3;
    }
}