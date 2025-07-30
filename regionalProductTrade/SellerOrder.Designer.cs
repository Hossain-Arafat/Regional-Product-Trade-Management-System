namespace regionalProductTrade
{
    partial class SellerOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerOrder));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderidtextBox = new System.Windows.Forms.TextBox();
            this.statustextBox = new System.Windows.Forms.TextBox();
            this.UpdateStatusbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Paymen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 117);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(849, 521);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // selectbutton
            // 
            this.selectbutton.BackColor = System.Drawing.Color.LimeGreen;
            this.selectbutton.FlatAppearance.BorderSize = 0;
            this.selectbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectbutton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectbutton.Location = new System.Drawing.Point(934, 195);
            this.selectbutton.Margin = new System.Windows.Forms.Padding(2);
            this.selectbutton.Name = "selectbutton";
            this.selectbutton.Size = new System.Drawing.Size(230, 45);
            this.selectbutton.TabIndex = 1;
            this.selectbutton.Text = "Show Status";
            this.selectbutton.UseVisualStyleBackColor = false;
            this.selectbutton.Click += new System.EventHandler(this.selectbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(928, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Order ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OrderidtextBox
            // 
            this.OrderidtextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderidtextBox.Location = new System.Drawing.Point(933, 149);
            this.OrderidtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.OrderidtextBox.Name = "OrderidtextBox";
            this.OrderidtextBox.Size = new System.Drawing.Size(230, 33);
            this.OrderidtextBox.TabIndex = 3;
            this.OrderidtextBox.TextChanged += new System.EventHandler(this.OrderidtextBox_TextChanged);
            // 
            // statustextBox
            // 
            this.statustextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statustextBox.Location = new System.Drawing.Point(932, 307);
            this.statustextBox.Margin = new System.Windows.Forms.Padding(2);
            this.statustextBox.Name = "statustextBox";
            this.statustextBox.Size = new System.Drawing.Size(230, 33);
            this.statustextBox.TabIndex = 4;
            // 
            // UpdateStatusbutton
            // 
            this.UpdateStatusbutton.BackColor = System.Drawing.Color.LimeGreen;
            this.UpdateStatusbutton.FlatAppearance.BorderSize = 0;
            this.UpdateStatusbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateStatusbutton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateStatusbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateStatusbutton.Location = new System.Drawing.Point(933, 354);
            this.UpdateStatusbutton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateStatusbutton.Name = "UpdateStatusbutton";
            this.UpdateStatusbutton.Size = new System.Drawing.Size(230, 45);
            this.UpdateStatusbutton.TabIndex = 5;
            this.UpdateStatusbutton.Text = "Update Status";
            this.UpdateStatusbutton.UseVisualStyleBackColor = false;
            this.UpdateStatusbutton.Click += new System.EventHandler(this.UpdateStatusbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(928, 275);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Update Order Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(929, 425);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Order ID";
            // 
            // Paymen
            // 
            this.Paymen.BackColor = System.Drawing.Color.LimeGreen;
            this.Paymen.FlatAppearance.BorderSize = 0;
            this.Paymen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Paymen.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paymen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Paymen.Location = new System.Drawing.Point(934, 505);
            this.Paymen.Margin = new System.Windows.Forms.Padding(2);
            this.Paymen.Name = "Paymen";
            this.Paymen.Size = new System.Drawing.Size(230, 45);
            this.Paymen.TabIndex = 8;
            this.Paymen.Text = "Payment Details";
            this.Paymen.UseVisualStyleBackColor = false;
            this.Paymen.Click += new System.EventHandler(this.Paymen_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(933, 457);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 33);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(928, 568);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Payment Status";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(933, 600);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 33);
            this.textBox2.TabIndex = 11;
            // 
            // SellerOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::regionalProductTrade.Properties.Resources.buyer_dashboard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Paymen);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UpdateStatusbutton);
            this.Controls.Add(this.statustextBox);
            this.Controls.Add(this.OrderidtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectbutton);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "SellerOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerOrder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button selectbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OrderidtextBox;
        private System.Windows.Forms.TextBox statustextBox;
        private System.Windows.Forms.Button UpdateStatusbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Paymen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
    }
}