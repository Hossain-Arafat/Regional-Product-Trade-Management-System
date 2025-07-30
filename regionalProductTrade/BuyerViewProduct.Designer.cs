namespace regionalProductTrade
{
    partial class BuyerViewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyerViewProduct));
            this.ShowProducttextBox = new System.Windows.Forms.TextBox();
            this.ShowProductbutton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowProducttextBox
            // 
            this.ShowProducttextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShowProducttextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowProducttextBox.Location = new System.Drawing.Point(921, 199);
            this.ShowProducttextBox.Name = "ShowProducttextBox";
            this.ShowProducttextBox.Size = new System.Drawing.Size(280, 33);
            this.ShowProducttextBox.TabIndex = 13;
            this.ShowProducttextBox.TextChanged += new System.EventHandler(this.ShowProducttextBox_TextChanged);
            // 
            // ShowProductbutton
            // 
            this.ShowProductbutton.BackColor = System.Drawing.Color.LimeGreen;
            this.ShowProductbutton.FlatAppearance.BorderSize = 0;
            this.ShowProductbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowProductbutton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowProductbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShowProductbutton.Location = new System.Drawing.Point(921, 254);
            this.ShowProductbutton.Name = "ShowProductbutton";
            this.ShowProductbutton.Size = new System.Drawing.Size(280, 41);
            this.ShowProductbutton.TabIndex = 12;
            this.ShowProductbutton.Text = "Show Product Details";
            this.ShowProductbutton.UseVisualStyleBackColor = false;
            this.ShowProductbutton.Click += new System.EventHandler(this.showprofilebutton_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.LimeGreen;
            this.searchbutton.FlatAppearance.BorderSize = 0;
            this.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbutton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchbutton.Location = new System.Drawing.Point(697, 49);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(138, 43);
            this.searchbutton.TabIndex = 11;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtextBox.Location = new System.Drawing.Point(374, 54);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(317, 33);
            this.searchtextBox.TabIndex = 10;
            this.searchtextBox.TextChanged += new System.EventHandler(this.searchtextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(374, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(461, 520);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(915, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter Product Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BuyerViewProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::regionalProductTrade.Properties.Resources.datagridview2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowProducttextBox);
            this.Controls.Add(this.ShowProductbutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "BuyerViewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyerViewProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ShowProducttextBox;
        private System.Windows.Forms.Button ShowProductbutton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}