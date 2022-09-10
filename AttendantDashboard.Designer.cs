
namespace ManagementSystem
{
    partial class AttendantDashboard
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
            this.close_atten_dashboard = new System.Windows.Forms.Button();
            this.attendant_menu = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.Products = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.logout_attendant = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close_atten_dashboard
            // 
            this.close_atten_dashboard.BackColor = System.Drawing.Color.White;
            this.close_atten_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close_atten_dashboard.ForeColor = System.Drawing.Color.Red;
            this.close_atten_dashboard.Location = new System.Drawing.Point(762, 1);
            this.close_atten_dashboard.Name = "close_atten_dashboard";
            this.close_atten_dashboard.Size = new System.Drawing.Size(38, 38);
            this.close_atten_dashboard.TabIndex = 0;
            this.close_atten_dashboard.Text = "X";
            this.close_atten_dashboard.UseVisualStyleBackColor = false;
            this.close_atten_dashboard.Click += new System.EventHandler(this.close_atten_dashboard_Click);
            // 
            // attendant_menu
            // 
            this.attendant_menu.BackColor = System.Drawing.Color.Black;
            this.attendant_menu.Location = new System.Drawing.Point(0, 0);
            this.attendant_menu.Name = "attendant_menu";
            this.attendant_menu.Size = new System.Drawing.Size(236, 450);
            this.attendant_menu.TabIndex = 1;
            this.attendant_menu.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sales Inventory\r\n System";
            // 
            // Products
            // 
            this.Products.BackColor = System.Drawing.Color.Black;
            this.Products.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Products.ForeColor = System.Drawing.Color.White;
            this.Products.Location = new System.Drawing.Point(57, 65);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(130, 32);
            this.Products.TabIndex = 3;
            this.Products.Text = "Products";
            this.Products.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Products.UseVisualStyleBackColor = false;
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(57, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Transactions";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(57, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "Categories";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(57, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "Tills";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // logout_attendant
            // 
            this.logout_attendant.BackColor = System.Drawing.Color.Black;
            this.logout_attendant.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logout_attendant.ForeColor = System.Drawing.Color.White;
            this.logout_attendant.Location = new System.Drawing.Point(48, 406);
            this.logout_attendant.Name = "logout_attendant";
            this.logout_attendant.Size = new System.Drawing.Size(130, 32);
            this.logout_attendant.TabIndex = 7;
            this.logout_attendant.Text = "Logout";
            this.logout_attendant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_attendant.UseVisualStyleBackColor = false;
            this.logout_attendant.Click += new System.EventHandler(this.logout_attendant_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.IndianRed;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(277, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 75);
            this.button4.TabIndex = 8;
            this.button4.Text = "Products";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Location = new System.Drawing.Point(285, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "0";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(438, 56);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 75);
            this.button5.TabIndex = 10;
            this.button5.Text = "Categories";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Location = new System.Drawing.Point(446, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "0";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SteelBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(599, 56);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 75);
            this.button6.TabIndex = 12;
            this.button6.Text = "Transactions";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Location = new System.Drawing.Point(607, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "0";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MidnightBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(277, 167);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(132, 75);
            this.button7.TabIndex = 14;
            this.button7.Text = "Tills";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MidnightBlue;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Location = new System.Drawing.Point(285, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "0";
            // 
            // AttendantDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.logout_attendant);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attendant_menu);
            this.Controls.Add(this.close_atten_dashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttendantDashboard";
            this.Text = "AttendantDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close_atten_dashboard;
        private System.Windows.Forms.Splitter attendant_menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Products;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button logout_attendant;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
    }
}