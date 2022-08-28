
namespace ManagementSystem
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.input_user = new System.Windows.Forms.TextBox();
            this.input_password = new System.Windows.Forms.TextBox();
            this.user_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.email = new System.Windows.Forms.TextBox();
            this.input_email = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmpassword = new System.Windows.Forms.TextBox();
            this.input_role = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(411, 450);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(772, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(564, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sign Up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // input_user
            // 
            this.input_user.Location = new System.Drawing.Point(493, 131);
            this.input_user.Name = "input_user";
            this.input_user.Size = new System.Drawing.Size(264, 26);
            this.input_user.TabIndex = 4;
            this.input_user.Text = "hbfh";
            this.input_user.TextChanged += new System.EventHandler(this.input_user_TextChanged);
            // 
            // input_password
            // 
            this.input_password.Location = new System.Drawing.Point(493, 183);
            this.input_password.Name = "input_password";
            this.input_password.Size = new System.Drawing.Size(264, 26);
            this.input_password.TabIndex = 5;
            this.input_password.TextChanged += new System.EventHandler(this.input_password_TextChanged);
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Location = new System.Drawing.Point(489, 108);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(83, 20);
            this.user_label.TabIndex = 6;
            this.user_label.Text = "Username";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(489, 160);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(78, 20);
            this.password_label.TabIndex = 7;
            this.password_label.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Already have an account?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(645, 404);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 20);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log In.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(493, 79);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(264, 26);
            this.email.TabIndex = 10;
            this.email.Text = "h";
            this.email.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // input_email
            // 
            this.input_email.AutoSize = true;
            this.input_email.Location = new System.Drawing.Point(489, 56);
            this.input_email.Name = "input_email";
            this.input_email.Size = new System.Drawing.Size(48, 20);
            this.input_email.TabIndex = 11;
            this.input_email.Text = "Email";
            this.input_email.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Confirm Password";
            // 
            // confirmpassword
            // 
            this.confirmpassword.Location = new System.Drawing.Point(493, 235);
            this.confirmpassword.Name = "confirmpassword";
            this.confirmpassword.Size = new System.Drawing.Size(264, 26);
            this.confirmpassword.TabIndex = 13;
            this.confirmpassword.TextChanged += new System.EventHandler(this.confirmpassword_TextChanged);
            // 
            // input_role
            // 
            this.input_role.FormattingEnabled = true;
            this.input_role.ItemHeight = 20;
            this.input_role.Items.AddRange(new object[] {
            "Admin",
            "Attendant"});
            this.input_role.Location = new System.Drawing.Point(493, 293);
            this.input_role.Name = "input_role";
            this.input_role.Size = new System.Drawing.Size(120, 24);
            this.input_role.TabIndex = 14;
            this.input_role.Tag = "Admin";
            this.input_role.SelectedIndexChanged += new System.EventHandler(this.input_role_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Role";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.input_user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.input_role);
            this.Controls.Add(this.confirmpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_email);
            this.Controls.Add(this.email);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.input_password);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox input_user;
        private System.Windows.Forms.TextBox input_password;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label input_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmpassword;
        private System.Windows.Forms.ListBox input_role;
        private System.Windows.Forms.Label label3;
    }
}

