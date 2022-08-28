
namespace ManagementSystem
{
    partial class Form2
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
            this.login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Tan;
            this.login.Location = new System.Drawing.Point(343, 302);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 28);
            this.login.TabIndex = 0;
            this.login.Text = "Log In";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(262, 228);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(253, 26);
            this.password.TabIndex = 2;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(262, 181);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(253, 26);
            this.user.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(339, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Log In";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.user);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}