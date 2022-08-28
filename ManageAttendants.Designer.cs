
namespace ManagementSystem
{
    partial class ManageAttendants
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
            this.addAttendant = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.atten_name = new System.Windows.Forms.TextBox();
            this.atten_password = new System.Windows.Forms.TextBox();
            this.atten_email = new System.Windows.Forms.TextBox();
            this.updateAttendant = new System.Windows.Forms.Button();
            this.deleteAttendant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addAttendant
            // 
            this.addAttendant.BackColor = System.Drawing.Color.Black;
            this.addAttendant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addAttendant.ForeColor = System.Drawing.Color.White;
            this.addAttendant.Location = new System.Drawing.Point(250, 216);
            this.addAttendant.Name = "addAttendant";
            this.addAttendant.Size = new System.Drawing.Size(129, 40);
            this.addAttendant.TabIndex = 1;
            this.addAttendant.Text = "Add Attendant";
            this.addAttendant.UseVisualStyleBackColor = false;
            this.addAttendant.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 176);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(40, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage Attendants";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Attendant Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Attendant Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Attendant Password";
            // 
            // atten_name
            // 
            this.atten_name.Location = new System.Drawing.Point(250, 99);
            this.atten_name.Name = "atten_name";
            this.atten_name.Size = new System.Drawing.Size(442, 26);
            this.atten_name.TabIndex = 7;
            this.atten_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // atten_password
            // 
            this.atten_password.Location = new System.Drawing.Point(250, 141);
            this.atten_password.Name = "atten_password";
            this.atten_password.Size = new System.Drawing.Size(442, 26);
            this.atten_password.TabIndex = 8;
            // 
            // atten_email
            // 
            this.atten_email.Location = new System.Drawing.Point(250, 180);
            this.atten_email.Name = "atten_email";
            this.atten_email.Size = new System.Drawing.Size(442, 26);
            this.atten_email.TabIndex = 9;
            this.atten_email.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // updateAttendant
            // 
            this.updateAttendant.BackColor = System.Drawing.Color.ForestGreen;
            this.updateAttendant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateAttendant.ForeColor = System.Drawing.Color.White;
            this.updateAttendant.Location = new System.Drawing.Point(394, 216);
            this.updateAttendant.Name = "updateAttendant";
            this.updateAttendant.Size = new System.Drawing.Size(131, 40);
            this.updateAttendant.TabIndex = 10;
            this.updateAttendant.Text = "Update Details";
            this.updateAttendant.UseVisualStyleBackColor = false;
            // 
            // deleteAttendant
            // 
            this.deleteAttendant.BackColor = System.Drawing.Color.Red;
            this.deleteAttendant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteAttendant.ForeColor = System.Drawing.Color.White;
            this.deleteAttendant.Location = new System.Drawing.Point(531, 216);
            this.deleteAttendant.Name = "deleteAttendant";
            this.deleteAttendant.Size = new System.Drawing.Size(161, 40);
            this.deleteAttendant.TabIndex = 11;
            this.deleteAttendant.Text = "Delete Attendant";
            this.deleteAttendant.UseVisualStyleBackColor = false;
            // 
            // ManageAttendants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteAttendant);
            this.Controls.Add(this.updateAttendant);
            this.Controls.Add(this.atten_email);
            this.Controls.Add(this.atten_password);
            this.Controls.Add(this.atten_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addAttendant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageAttendants";
            this.Text = "ManageAttendants";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addAttendant;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox atten_name;
        private System.Windows.Forms.TextBox atten_password;
        private System.Windows.Forms.TextBox atten_email;
        private System.Windows.Forms.Button updateAttendant;
        private System.Windows.Forms.Button deleteAttendant;
    }
}