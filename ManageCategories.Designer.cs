
namespace ManagementSystem
{
    partial class ManageCategories
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
            this.addcategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.updatecategory = new System.Windows.Forms.Button();
            this.deletecategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.category_name = new System.Windows.Forms.TextBox();
            this.category_des = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.category_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addcategory
            // 
            this.addcategory.BackColor = System.Drawing.Color.Black;
            this.addcategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addcategory.ForeColor = System.Drawing.Color.White;
            this.addcategory.Location = new System.Drawing.Point(263, 198);
            this.addcategory.Name = "addcategory";
            this.addcategory.Size = new System.Drawing.Size(132, 32);
            this.addcategory.TabIndex = 1;
            this.addcategory.Text = "Add a Category";
            this.addcategory.UseVisualStyleBackColor = false;
            this.addcategory.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Categories";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(132, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(551, 193);
            this.dataGridView1.TabIndex = 4;
            // 
            // updatecategory
            // 
            this.updatecategory.BackColor = System.Drawing.Color.ForestGreen;
            this.updatecategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updatecategory.ForeColor = System.Drawing.Color.White;
            this.updatecategory.Location = new System.Drawing.Point(411, 198);
            this.updatecategory.Name = "updatecategory";
            this.updatecategory.Size = new System.Drawing.Size(140, 32);
            this.updatecategory.TabIndex = 5;
            this.updatecategory.Text = "Update Category";
            this.updatecategory.UseVisualStyleBackColor = false;
            this.updatecategory.Click += new System.EventHandler(this.updatecategory_Click);
            // 
            // deletecategory
            // 
            this.deletecategory.BackColor = System.Drawing.Color.Red;
            this.deletecategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deletecategory.ForeColor = System.Drawing.Color.White;
            this.deletecategory.Location = new System.Drawing.Point(570, 198);
            this.deletecategory.Name = "deletecategory";
            this.deletecategory.Size = new System.Drawing.Size(132, 32);
            this.deletecategory.TabIndex = 6;
            this.deletecategory.Text = "Delete Category";
            this.deletecategory.UseVisualStyleBackColor = false;
            this.deletecategory.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Category name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Category description";
            // 
            // category_name
            // 
            this.category_name.Location = new System.Drawing.Point(263, 77);
            this.category_name.Name = "category_name";
            this.category_name.Size = new System.Drawing.Size(439, 26);
            this.category_name.TabIndex = 9;
            // 
            // category_des
            // 
            this.category_des.Location = new System.Drawing.Point(263, 122);
            this.category_des.Name = "category_des";
            this.category_des.Size = new System.Drawing.Size(439, 26);
            this.category_des.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Category ID";
            // 
            // category_id
            // 
            this.category_id.Location = new System.Drawing.Point(263, 162);
            this.category_id.Name = "category_id";
            this.category_id.Size = new System.Drawing.Size(439, 26);
            this.category_id.TabIndex = 12;
            this.category_id.Tag = "";
            // 
            // ManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.category_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.category_des);
            this.Controls.Add(this.category_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deletecategory);
            this.Controls.Add(this.updatecategory);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addcategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCategories";
            this.Text = "ManageCategories";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addcategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button updatecategory;
        private System.Windows.Forms.Button deletecategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox category_name;
        private System.Windows.Forms.TextBox category_des;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox category_id;
    }
}