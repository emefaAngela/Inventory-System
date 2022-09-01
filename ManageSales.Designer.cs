
using System;

namespace ManagementSystem
{
    partial class ManageSales
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
            this.startsale = new System.Windows.Forms.Button();
            this.endSale = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.currentDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // startsale
            // 
            this.startsale.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startsale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startsale.ForeColor = System.Drawing.Color.White;
            this.startsale.Location = new System.Drawing.Point(198, 171);
            this.startsale.Name = "startsale";
            this.startsale.Size = new System.Drawing.Size(133, 33);
            this.startsale.TabIndex = 0;
            this.startsale.Text = "Start a Sale";
            this.startsale.UseVisualStyleBackColor = false;
            this.startsale.Click += new System.EventHandler(this.startsale_Click);
            // 
            // endSale
            // 
            this.endSale.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.endSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.endSale.ForeColor = System.Drawing.Color.White;
            this.endSale.Location = new System.Drawing.Point(475, 171);
            this.endSale.Name = "endSale";
            this.endSale.Size = new System.Drawing.Size(133, 33);
            this.endSale.TabIndex = 1;
            this.endSale.Text = "End Sale";
            this.endSale.UseVisualStyleBackColor = false;
            this.endSale.Click += new System.EventHandler(this.endSale_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sale Status";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(630, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 173);
            this.dataGridView1.TabIndex = 4;
            // 
            // currentDate
            // 
            this.currentDate.Location = new System.Drawing.Point(407, 139);
            this.currentDate.Name = "currentDate";
            this.currentDate.Size = new System.Drawing.Size(100, 26);
            this.currentDate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(319, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(322, 26);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2022, 8, 29, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ManageSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.currentDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endSale);
            this.Controls.Add(this.startsale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageSales";
            this.Text = "ManageSales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startsale;
        private System.Windows.Forms.Button endSale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox currentDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private readonly EventHandler dateTimePicker1_ValueChanged;
    }
}