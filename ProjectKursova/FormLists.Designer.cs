
namespace ProjectKursova
{
    partial class FormLists
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
            this.SuspendLayout();
            // 
            // lbLists
            // 
            this.lbLists.FormattingEnabled = true;
            this.lbLists.ItemHeight = 16;
            this.lbLists.Location = new System.Drawing.Point(64, 76);
            this.lbLists.Name = "lbLists";
            this.lbLists.Size = new System.Drawing.Size(120, 244);
            this.lbLists.TabIndex = 0;
            // 
            // FormLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbLists);
            this.Name = "FormLists";
            this.Text = "FormLists";
            this.Load += new System.EventHandler(this.FormLists_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbLists;
    }
}