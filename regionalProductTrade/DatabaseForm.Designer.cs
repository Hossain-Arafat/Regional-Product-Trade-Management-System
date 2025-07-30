namespace regionalProductTrade
{
    partial class DatabaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseForm));
            this.showprofilebutton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showProfiletextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // showprofilebutton
            // 
            this.showprofilebutton.BackColor = System.Drawing.Color.LimeGreen;
            this.showprofilebutton.FlatAppearance.BorderSize = 0;
            this.showprofilebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showprofilebutton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showprofilebutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showprofilebutton.Location = new System.Drawing.Point(1001, 221);
            this.showprofilebutton.Name = "showprofilebutton";
            this.showprofilebutton.Size = new System.Drawing.Size(251, 42);
            this.showprofilebutton.TabIndex = 7;
            this.showprofilebutton.Text = "Show Profile";
            this.showprofilebutton.UseVisualStyleBackColor = false;
            this.showprofilebutton.Click += new System.EventHandler(this.showprofilebutton_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.LimeGreen;
            this.searchbutton.FlatAppearance.BorderSize = 0;
            this.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbutton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchbutton.Location = new System.Drawing.Point(807, 47);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(151, 43);
            this.searchbutton.TabIndex = 6;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // searchtextBox
            // 
            this.searchtextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtextBox.Location = new System.Drawing.Point(295, 52);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(506, 33);
            this.searchtextBox.TabIndex = 5;
            this.searchtextBox.TextChanged += new System.EventHandler(this.searchtextBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(295, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(663, 535);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // showProfiletextBox
            // 
            this.showProfiletextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showProfiletextBox.Location = new System.Drawing.Point(1001, 161);
            this.showProfiletextBox.Name = "showProfiletextBox";
            this.showProfiletextBox.Size = new System.Drawing.Size(251, 33);
            this.showProfiletextBox.TabIndex = 8;
            this.showProfiletextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(996, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter User Id:";
            // 
            // DatabaseForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::regionalProductTrade.Properties.Resources.datagridview2;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showProfiletextBox);
            this.Controls.Add(this.showprofilebutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "DatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatabaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showprofilebutton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox showProfiletextBox;
        private System.Windows.Forms.Label label1;
    }
}