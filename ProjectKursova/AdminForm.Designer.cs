
namespace ProjectKursova
{
    partial class AdminForm
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
            this.lbUsers = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.ListBox();
            this.ToUserForm = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.tbNewUserLogin = new System.Windows.Forms.TextBox();
            this.tbNewUserName = new System.Windows.Forms.TextBox();
            this.tbNewUserSurname = new System.Windows.Forms.TextBox();
            this.lblNewUserLogin = new System.Windows.Forms.Label();
            this.lblNewUserName = new System.Windows.Forms.Label();
            this.lblNewUserSurname = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblClearAdminFields = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUsers
            // 
            this.lbUsers.AutoSize = true;
            this.lbUsers.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUsers.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbUsers.Location = new System.Drawing.Point(69, 32);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(76, 29);
            this.lbUsers.TabIndex = 0;
            this.lbUsers.Text = "Users";
            // 
            // lbUser
            // 
            this.lbUser.BackColor = System.Drawing.Color.White;
            this.lbUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUser.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbUser.FormattingEnabled = true;
            this.lbUser.ItemHeight = 20;
            this.lbUser.Location = new System.Drawing.Point(12, 80);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(196, 222);
            this.lbUser.TabIndex = 1;
            this.lbUser.SelectedIndexChanged += new System.EventHandler(this.lbUser_SelectedIndexChanged);
            // 
            // ToUserForm
            // 
            this.ToUserForm.BackColor = System.Drawing.SystemColors.Highlight;
            this.ToUserForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToUserForm.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToUserForm.ForeColor = System.Drawing.Color.White;
            this.ToUserForm.Location = new System.Drawing.Point(514, 275);
            this.ToUserForm.Name = "ToUserForm";
            this.ToUserForm.Size = new System.Drawing.Size(108, 73);
            this.ToUserForm.TabIndex = 2;
            this.ToUserForm.Text = "Enter";
            this.ToUserForm.UseVisualStyleBackColor = false;
            this.ToUserForm.Click += new System.EventHandler(this.ToUserForm_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFullName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFullName.Location = new System.Drawing.Point(278, 39);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(124, 20);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Full Information";
            // 
            // tbNewUserLogin
            // 
            this.tbNewUserLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNewUserLogin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tbNewUserLogin.Location = new System.Drawing.Point(313, 96);
            this.tbNewUserLogin.Name = "tbNewUserLogin";
            this.tbNewUserLogin.Size = new System.Drawing.Size(158, 20);
            this.tbNewUserLogin.TabIndex = 15;
            // 
            // tbNewUserName
            // 
            this.tbNewUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNewUserName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tbNewUserName.Location = new System.Drawing.Point(313, 142);
            this.tbNewUserName.Name = "tbNewUserName";
            this.tbNewUserName.Size = new System.Drawing.Size(158, 20);
            this.tbNewUserName.TabIndex = 16;
            // 
            // tbNewUserSurname
            // 
            this.tbNewUserSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNewUserSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNewUserSurname.ForeColor = System.Drawing.SystemColors.Highlight;
            this.tbNewUserSurname.Location = new System.Drawing.Point(313, 189);
            this.tbNewUserSurname.Name = "tbNewUserSurname";
            this.tbNewUserSurname.Size = new System.Drawing.Size(158, 20);
            this.tbNewUserSurname.TabIndex = 17;
            // 
            // lblNewUserLogin
            // 
            this.lblNewUserLogin.AutoSize = true;
            this.lblNewUserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewUserLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNewUserLogin.Location = new System.Drawing.Point(217, 97);
            this.lblNewUserLogin.Name = "lblNewUserLogin";
            this.lblNewUserLogin.Size = new System.Drawing.Size(55, 20);
            this.lblNewUserLogin.TabIndex = 18;
            this.lblNewUserLogin.Text = "Login";
            // 
            // lblNewUserName
            // 
            this.lblNewUserName.AutoSize = true;
            this.lblNewUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewUserName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNewUserName.Location = new System.Drawing.Point(217, 141);
            this.lblNewUserName.Name = "lblNewUserName";
            this.lblNewUserName.Size = new System.Drawing.Size(57, 20);
            this.lblNewUserName.TabIndex = 19;
            this.lblNewUserName.Text = "Name";
            // 
            // lblNewUserSurname
            // 
            this.lblNewUserSurname.AutoSize = true;
            this.lblNewUserSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewUserSurname.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblNewUserSurname.Location = new System.Drawing.Point(217, 191);
            this.lblNewUserSurname.Name = "lblNewUserSurname";
            this.lblNewUserSurname.Size = new System.Drawing.Size(83, 20);
            this.lblNewUserSurname.TabIndex = 20;
            this.lblNewUserSurname.Text = "Surname";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpBirthday.Location = new System.Drawing.Point(222, 237);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(221, 27);
            this.dtpBirthday.TabIndex = 21;
            // 
            // lblClearAdminFields
            // 
            this.lblClearAdminFields.AutoSize = true;
            this.lblClearAdminFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClearAdminFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClearAdminFields.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblClearAdminFields.Location = new System.Drawing.Point(276, 276);
            this.lblClearAdminFields.Name = "lblClearAdminFields";
            this.lblClearAdminFields.Size = new System.Drawing.Size(122, 24);
            this.lblClearAdminFields.TabIndex = 22;
            this.lblClearAdminFields.Text = "Clear Fields";
            this.lblClearAdminFields.Click += new System.EventHandler(this.lblClearAdminFields_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(222, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 2);
            this.panel1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(225, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 2);
            this.panel2.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Location = new System.Drawing.Point(222, 212);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 2);
            this.panel3.TabIndex = 40;
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUser.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUser.ForeColor = System.Drawing.Color.White;
            this.btnRemoveUser.Location = new System.Drawing.Point(373, 303);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(45, 45);
            this.btnRemoveUser.TabIndex = 43;
            this.btnRemoveUser.Text = "-";
            this.btnRemoveUser.UseVisualStyleBackColor = false;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditUser.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEditUser.Location = new System.Drawing.Point(298, 303);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(69, 45);
            this.btnEditUser.TabIndex = 42;
            this.btnEditUser.Text = "EDIT";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(247, 303);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(45, 45);
            this.btnAddUser.TabIndex = 41;
            this.btnAddUser.Text = "+";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(657, 380);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblClearAdminFields);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.lblNewUserSurname);
            this.Controls.Add(this.lblNewUserName);
            this.Controls.Add(this.lblNewUserLogin);
            this.Controls.Add(this.tbNewUserSurname);
            this.Controls.Add(this.tbNewUserName);
            this.Controls.Add(this.tbNewUserLogin);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.ToUserForm);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbUsers);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsers;
        private System.Windows.Forms.ListBox lbUser;
        private System.Windows.Forms.Button ToUserForm;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox tbNewUserLogin;
        private System.Windows.Forms.TextBox tbNewUserName;
        private System.Windows.Forms.TextBox tbNewUserSurname;
        private System.Windows.Forms.Label lblNewUserLogin;
        private System.Windows.Forms.Label lblNewUserName;
        private System.Windows.Forms.Label lblNewUserSurname;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lblClearAdminFields;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnAddUser;
    }
}