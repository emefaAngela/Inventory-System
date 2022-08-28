
namespace ManagementSystem
{
    partial class AddAttendant
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
            this.button1 = new System.Windows.Forms.Button();
            this.atten_name = new System.Windows.Forms.TextBox();
            this.atten_email = new System.Windows.Forms.TextBox();
            this.atten_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(87, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Attendant";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // atten_name
            // 
            this.atten_name.Location = new System.Drawing.Point(158, 99);
            this.atten_name.Name = "atten_name";
            this.atten_name.Size = new System.Drawing.Size(123, 26);
            this.atten_name.TabIndex = 1;
            // 
            // atten_email
            // 
            this.atten_email.Location = new System.Drawing.Point(158, 160);
            this.atten_email.Name = "atten_email";
            this.atten_email.Size = new System.Drawing.Size(123, 26);
            this.atten_email.TabIndex = 2;
            // 
            // atten_password
            // 
            this.atten_password.Location = new System.Drawing.Point(158, 218);
            this.atten_password.Name = "atten_password";
            this.atten_password.Size = new System.Drawing.Size(123, 26);
            this.atten_password.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(82, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add an Attendant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // AddAttendant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 368);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.atten_password);
            this.Controls.Add(this.atten_email);
            this.Controls.Add(this.atten_name);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAttendant";
            this.Text = "AddAttendant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox atten_name;
        private System.Windows.Forms.TextBox atten_email;
        private System.Windows.Forms.TextBox atten_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}