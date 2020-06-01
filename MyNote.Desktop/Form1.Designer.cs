namespace MyNote.Desktop
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListNotes = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtApiUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstNotes = new System.Windows.Forms.ListBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // btnListNotes
            // 
            this.btnListNotes.Location = new System.Drawing.Point(341, 120);
            this.btnListNotes.Name = "btnListNotes";
            this.btnListNotes.Size = new System.Drawing.Size(140, 23);
            this.btnListNotes.TabIndex = 1;
            this.btnListNotes.Text = "List Notes";
            this.btnListNotes.UseVisualStyleBackColor = true;
            this.btnListNotes.Click += new System.EventHandler(this.btnListNotes_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(12, 120);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(153, 24);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Text = "kaanyrdkl@gmail.com";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(171, 120);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(153, 24);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Password1.";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtApiUrl
            // 
            this.txtApiUrl.Location = new System.Drawing.Point(87, 39);
            this.txtApiUrl.Name = "txtApiUrl";
            this.txtApiUrl.Size = new System.Drawing.Size(323, 24);
            this.txtApiUrl.TabIndex = 4;
            this.txtApiUrl.Text = "https://kaanyurdakul.tk/api/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "API URL";
            // 
            // lstNotes
            // 
            this.lstNotes.FormattingEnabled = true;
            this.lstNotes.ItemHeight = 18;
            this.lstNotes.Location = new System.Drawing.Point(12, 187);
            this.lstNotes.Name = "lstNotes";
            this.lstNotes.Size = new System.Drawing.Size(150, 166);
            this.lstNotes.TabIndex = 6;
            this.lstNotes.SelectedIndexChanged += new System.EventHandler(this.lstNotes_SelectedIndexChanged);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(171, 187);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(310, 166);
            this.txtNote.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 379);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lstNotes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApiUrl);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnListNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "MyNote.Desktop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListNotes;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtApiUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstNotes;
        private System.Windows.Forms.TextBox txtNote;
    }
}

