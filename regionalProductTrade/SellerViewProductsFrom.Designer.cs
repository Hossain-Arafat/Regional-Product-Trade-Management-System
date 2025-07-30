namespace regionalProductTrade
{
    partial class SellerViewProductsFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellerViewProductsFrom));
            this.searchbutton = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NexttextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NextDetailPagebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.LimeGreen;
            this.searchbutton.FlatAppearance.BorderSize = 0;
            this.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbutton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchbutton.Location = new System.Drawing.Point(697, 72);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(118, 36);
            this.searchbutton.TabIndex = 11;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtextBox.Location = new System.Drawing.Point(356, 72);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(335, 33);
            this.searchtextBox.TabIndex = 10;
            this.searchtextBox.TextChanged += new System.EventHandler(this.searchtextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(356, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(459, 525);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NexttextBox
            // 
            this.NexttextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NexttextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NexttextBox.Location = new System.Drawing.Point(874, 191);
            this.NexttextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NexttextBox.Name = "NexttextBox";
            this.NexttextBox.Size = new System.Drawing.Size(231, 33);
            this.NexttextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(869, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter Product ID";
            // 
            // NextDetailPagebutton
            // 
            this.NextDetailPagebutton.BackColor = System.Drawing.Color.LimeGreen;
            this.NextDetailPagebutton.FlatAppearance.BorderSize = 0;
            this.NextDetailPagebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextDetailPagebutton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextDetailPagebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NextDetailPagebutton.Location = new System.Drawing.Point(874, 248);
            this.NextDetailPagebutton.Margin = new System.Windows.Forms.Padding(2);
            this.NextDetailPagebutton.Name = "NextDetailPagebutton";
            this.NextDetailPagebutton.Size = new System.Drawing.Size(231, 42);
            this.NextDetailPagebutton.TabIndex = 14;
            this.NextDetailPagebutton.Text = "Show Details";
            this.NextDetailPagebutton.UseVisualStyleBackColor = false;
            this.NextDetailPagebutton.Click += new System.EventHandler(this.NextDetailPagebutton_Click);
            // 
            // SellerViewProductsFrom
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::regionalProductTrade.Properties.Resources.sellerview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.NextDetailPagebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NexttextBox);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "SellerViewProductsFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerViewProductsFrom";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox NexttextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NextDetailPagebutton;
    }
}