
namespace ManagementSystem
{
    partial class RecordTransaction
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.TextBox();
            this.qrcode = new System.Windows.Forms.TextBox();
            this.attendant = new System.Windows.Forms.TextBox();
            this.product_name = new System.Windows.Forms.TextBox();
            this.product_price = new System.Windows.Forms.TextBox();
            this.completeTransaction = new System.Windows.Forms.Button();
            this.generateReceipt = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.product_quantity = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.closeform = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(277, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Record a Transaction.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "QR code";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Product name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Attendant Name";
            // 
            // customer
            // 
            this.customer.Location = new System.Drawing.Point(245, 92);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(100, 26);
            this.customer.TabIndex = 7;
            // 
            // qrcode
            // 
            this.qrcode.Location = new System.Drawing.Point(245, 134);
            this.qrcode.Name = "qrcode";
            this.qrcode.Size = new System.Drawing.Size(100, 26);
            this.qrcode.TabIndex = 8;
            this.qrcode.TextChanged += new System.EventHandler(this.qrcode_TextChanged);
            // 
            // attendant
            // 
            this.attendant.Location = new System.Drawing.Point(247, 176);
            this.attendant.Name = "attendant";
            this.attendant.Size = new System.Drawing.Size(100, 26);
            this.attendant.TabIndex = 9;
            // 
            // product_name
            // 
            this.product_name.Location = new System.Drawing.Point(596, 95);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(100, 26);
            this.product_name.TabIndex = 10;
            // 
            // product_price
            // 
            this.product_price.Location = new System.Drawing.Point(596, 137);
            this.product_price.Name = "product_price";
            this.product_price.Size = new System.Drawing.Size(100, 26);
            this.product_price.TabIndex = 11;
            // 
            // completeTransaction
            // 
            this.completeTransaction.BackColor = System.Drawing.Color.Black;
            this.completeTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.completeTransaction.ForeColor = System.Drawing.Color.White;
            this.completeTransaction.Location = new System.Drawing.Point(217, 237);
            this.completeTransaction.Name = "completeTransaction";
            this.completeTransaction.Size = new System.Drawing.Size(187, 37);
            this.completeTransaction.TabIndex = 12;
            this.completeTransaction.Text = "Complete Transaction";
            this.completeTransaction.UseVisualStyleBackColor = false;
            this.completeTransaction.Click += new System.EventHandler(this.completeTransaction_Click);
            // 
            // generateReceipt
            // 
            this.generateReceipt.BackColor = System.Drawing.Color.Black;
            this.generateReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateReceipt.ForeColor = System.Drawing.Color.White;
            this.generateReceipt.Location = new System.Drawing.Point(475, 237);
            this.generateReceipt.Name = "generateReceipt";
            this.generateReceipt.Size = new System.Drawing.Size(153, 37);
            this.generateReceipt.TabIndex = 13;
            this.generateReceipt.Text = "Generate Receipt";
            this.generateReceipt.UseVisualStyleBackColor = false;
            this.generateReceipt.Click += new System.EventHandler(this.generateReceipt_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Quantity";
            // 
            // product_quantity
            // 
            this.product_quantity.Location = new System.Drawing.Point(596, 179);
            this.product_quantity.Name = "product_quantity";
            this.product_quantity.Size = new System.Drawing.Size(100, 26);
            this.product_quantity.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // closeform
            // 
            this.closeform.BackColor = System.Drawing.Color.White;
            this.closeform.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeform.ForeColor = System.Drawing.Color.Red;
            this.closeform.Location = new System.Drawing.Point(753, 12);
            this.closeform.Name = "closeform";
            this.closeform.Size = new System.Drawing.Size(35, 35);
            this.closeform.TabIndex = 17;
            this.closeform.Text = "X";
            this.closeform.UseVisualStyleBackColor = false;
            this.closeform.Click += new System.EventHandler(this.closeform_Click);
            // 
            // RecordTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeform);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.product_quantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.generateReceipt);
            this.Controls.Add(this.completeTransaction);
            this.Controls.Add(this.product_price);
            this.Controls.Add(this.product_name);
            this.Controls.Add(this.attendant);
            this.Controls.Add(this.qrcode);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecordTransaction";
            this.Text = "RecordTransaction";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customer;
        private System.Windows.Forms.TextBox qrcode;
        private System.Windows.Forms.TextBox attendant;
        private System.Windows.Forms.TextBox product_name;
        private System.Windows.Forms.TextBox product_price;
        private System.Windows.Forms.Button completeTransaction;
        private System.Windows.Forms.Button generateReceipt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox product_quantity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button closeform;
    }
}