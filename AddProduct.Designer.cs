
namespace ManagementSystem
{
    partial class AddProduct
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
            this.p_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.p_price = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.closeaddproduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a new Product";
            // 
            // p_name
            // 
            this.p_name.BackColor = System.Drawing.SystemColors.Menu;
            this.p_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.p_name.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.p_name.Location = new System.Drawing.Point(71, 75);
            this.p_name.Multiline = true;
            this.p_name.Name = "p_name";
            this.p_name.Size = new System.Drawing.Size(196, 23);
            this.p_name.TabIndex = 1;
            this.p_name.Text = "Name your Product here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // category
            // 
            this.category.Location = new System.Drawing.Point(71, 152);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(157, 26);
            this.category.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // p_price
            // 
            this.p_price.Location = new System.Drawing.Point(71, 244);
            this.p_price.Name = "p_price";
            this.p_price.Size = new System.Drawing.Size(157, 26);
            this.p_price.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(68, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save Product";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // closeaddproduct
            // 
            this.closeaddproduct.AutoSize = true;
            this.closeaddproduct.Location = new System.Drawing.Point(253, 399);
            this.closeaddproduct.Name = "closeaddproduct";
            this.closeaddproduct.Size = new System.Drawing.Size(58, 20);
            this.closeaddproduct.TabIndex = 7;
            this.closeaddproduct.Text = "Cancel";
            this.closeaddproduct.Click += new System.EventHandler(this.closeaddproduct_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.closeaddproduct);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.p_price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.category);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p_name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox p_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox p_price;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label closeaddproduct;
    }
}