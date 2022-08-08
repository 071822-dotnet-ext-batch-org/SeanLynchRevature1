namespace Project1Form
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
            this.btnRegLogin = new System.Windows.Forms.Button();
            this.Reg_Login = new System.Windows.Forms.Label();
            this.NewUSRBox = new System.Windows.Forms.CheckBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRegLogin
            // 
            this.btnRegLogin.Location = new System.Drawing.Point(387, 226);
            this.btnRegLogin.Name = "btnRegLogin";
            this.btnRegLogin.Size = new System.Drawing.Size(75, 23);
            this.btnRegLogin.TabIndex = 0;
            this.btnRegLogin.Text = "Login";
            this.btnRegLogin.UseVisualStyleBackColor = true;
            this.btnRegLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reg_Login
            // 
            this.Reg_Login.Location = new System.Drawing.Point(362, 13);
            this.Reg_Login.Name = "Reg_Login";
            this.Reg_Login.Size = new System.Drawing.Size(100, 23);
            this.Reg_Login.TabIndex = 1;
            this.Reg_Login.Text = "Register/Login";
            this.Reg_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewUSRBox
            // 
            this.NewUSRBox.AutoSize = true;
            this.NewUSRBox.Location = new System.Drawing.Point(365, 180);
            this.NewUSRBox.Name = "NewUSRBox";
            this.NewUSRBox.Size = new System.Drawing.Size(77, 17);
            this.NewUSRBox.TabIndex = 2;
            this.NewUSRBox.Text = "New user?";
            this.NewUSRBox.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(365, 88);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblFirstname
            // 
            this.lblFirstname.Location = new System.Drawing.Point(259, 85);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(100, 23);
            this.lblFirstname.TabIndex = 4;
            this.lblFirstname.Text = "First Name";
            this.lblFirstname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(259, 111);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 23);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(365, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblFirstname);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.NewUSRBox);
            this.Controls.Add(this.Reg_Login);
            this.Controls.Add(this.btnRegLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegLogin;
        private System.Windows.Forms.Label Reg_Login;
        private System.Windows.Forms.CheckBox NewUSRBox;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox textBox1;
    }
}

