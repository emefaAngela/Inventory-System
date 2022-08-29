
namespace ManagementSystem
{
    partial class ManageProducts
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.total_products = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.updateproduct = new System.Windows.Forms.Button();
            this.deleteproduct = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.product_id = new System.Windows.Forms.TextBox();
            this.product_name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.product_des = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.product_code = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.product_price = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.reorder_level = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.product_quantity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Inventory";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(193, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Products";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Out of Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Items";
            // 
            // total_products
            // 
            this.total_products.AutoSize = true;
            this.total_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.total_products.ForeColor = System.Drawing.Color.RosyBrown;
            this.total_products.Location = new System.Drawing.Point(263, 34);
            this.total_products.Name = "total_products";
            this.total_products.Size = new System.Drawing.Size(23, 25);
            this.total_products.TabIndex = 6;
            this.total_products.Text = "0";
            this.total_products.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.RosyBrown;
            this.label6.Location = new System.Drawing.Point(397, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.RosyBrown;
            this.label7.Location = new System.Drawing.Point(525, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "0";
            // 
            // updateproduct
            // 
            this.updateproduct.BackColor = System.Drawing.Color.ForestGreen;
            this.updateproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateproduct.ForeColor = System.Drawing.Color.White;
            this.updateproduct.Location = new System.Drawing.Point(333, 227);
            this.updateproduct.Name = "updateproduct";
            this.updateproduct.Size = new System.Drawing.Size(144, 29);
            this.updateproduct.TabIndex = 10;
            this.updateproduct.Text = "Update Product";
            this.updateproduct.UseVisualStyleBackColor = false;
            this.updateproduct.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteproduct
            // 
            this.deleteproduct.BackColor = System.Drawing.Color.Red;
            this.deleteproduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteproduct.ForeColor = System.Drawing.Color.White;
            this.deleteproduct.Location = new System.Drawing.Point(495, 227);
            this.deleteproduct.Name = "deleteproduct";
            this.deleteproduct.Size = new System.Drawing.Size(138, 29);
            this.deleteproduct.TabIndex = 11;
            this.deleteproduct.Text = "Delete Product";
            this.deleteproduct.UseVisualStyleBackColor = false;
            this.deleteproduct.Click += new System.EventHandler(this.deleteproduct_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Product ID";
            // 
            // product_id
            // 
            this.product_id.Location = new System.Drawing.Point(162, 68);
            this.product_id.Name = "product_id";
            this.product_id.Size = new System.Drawing.Size(169, 26);
            this.product_id.TabIndex = 13;
            // 
            // product_name
            // 
            this.product_name.Location = new System.Drawing.Point(162, 106);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(169, 26);
            this.product_name.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Product des.";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // product_des
            // 
            this.product_des.Location = new System.Drawing.Point(162, 150);
            this.product_des.Name = "product_des";
            this.product_des.Size = new System.Drawing.Size(169, 26);
            this.product_des.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Product name";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // product_code
            // 
            this.product_code.Location = new System.Drawing.Point(530, 68);
            this.product_code.Name = "product_code";
            this.product_code.Size = new System.Drawing.Size(169, 26);
            this.product_code.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(401, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Product code";
            // 
            // product_price
            // 
            this.product_price.Location = new System.Drawing.Point(530, 106);
            this.product_price.Name = "product_price";
            this.product_price.Size = new System.Drawing.Size(169, 26);
            this.product_price.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(401, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Product price";
            // 
            // reorder_level
            // 
            this.reorder_level.Location = new System.Drawing.Point(530, 150);
            this.reorder_level.Name = "reorder_level";
            this.reorder_level.Size = new System.Drawing.Size(169, 26);
            this.reorder_level.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(401, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Reorder level";
            // 
            // product_quantity
            // 
            this.product_quantity.Location = new System.Drawing.Point(162, 195);
            this.product_quantity.Name = "product_quantity";
            this.product_quantity.Size = new System.Drawing.Size(169, 26);
            this.product_quantity.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Product quantity";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 161);
            this.dataGridView1.TabIndex = 26;
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.product_quantity);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.reorder_level);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.product_price);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.product_code);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.product_des);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.product_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.product_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deleteproduct);
            this.Controls.Add(this.updateproduct);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.total_products);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProducts";
            this.Text = "ManageProducts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label total_products;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button updateproduct;
        private System.Windows.Forms.Button deleteproduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox product_id;
        private System.Windows.Forms.TextBox product_name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox product_des;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox product_code;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox product_price;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox reorder_level;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox product_quantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}