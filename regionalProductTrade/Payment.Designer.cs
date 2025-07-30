namespace regionalProductTrade
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.rolecomboBox = new System.Windows.Forms.ComboBox();
            this.amounttextBox = new System.Windows.Forms.TextBox();
            this.orderidtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paybutton = new System.Windows.Forms.Button();
            this.selectbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rolecomboBox
            // 
            this.rolecomboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolecomboBox.FormattingEnabled = true;
            this.rolecomboBox.Location = new System.Drawing.Point(584, 396);
            this.rolecomboBox.Name = "rolecomboBox";
            this.rolecomboBox.Size = new System.Drawing.Size(256, 33);
            this.rolecomboBox.TabIndex = 25;
            // 
            // amounttextBox
            // 
            this.amounttextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amounttextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amounttextBox.Location = new System.Drawing.Point(584, 330);
            this.amounttextBox.Name = "amounttextBox";
            this.amounttextBox.Size = new System.Drawing.Size(256, 33);
            this.amounttextBox.TabIndex = 24;
            // 
            // orderidtextBox
            // 
            this.orderidtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderidtextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderidtextBox.Location = new System.Drawing.Point(584, 220);
            this.orderidtextBox.Name = "orderidtextBox";
            this.orderidtextBox.Size = new System.Drawing.Size(256, 33);
            this.orderidtextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(406, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "Payment Method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(490, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(485, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "Order ID";
            // 
            // paybutton
            // 
            this.paybutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.paybutton.BackColor = System.Drawing.Color.LimeGreen;
            this.paybutton.FlatAppearance.BorderSize = 0;
            this.paybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paybutton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paybutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.paybutton.Location = new System.Drawing.Point(523, 526);
            this.paybutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.paybutton.Name = "paybutton";
            this.paybutton.Size = new System.Drawing.Size(223, 53);
            this.paybutton.TabIndex = 26;
            this.paybutton.Text = "Pay Now";
            this.paybutton.UseVisualStyleBackColor = false;
            this.paybutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // selectbutton
            // 
            this.selectbutton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.selectbutton.FlatAppearance.BorderSize = 0;
            this.selectbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectbutton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectbutton.Location = new System.Drawing.Point(584, 258);
            this.selectbutton.Margin = new System.Windows.Forms.Padding(2);
            this.selectbutton.Name = "selectbutton";
            this.selectbutton.Size = new System.Drawing.Size(162, 40);
            this.selectbutton.TabIndex = 27;
            this.selectbutton.Text = "Show amount";
            this.selectbutton.UseVisualStyleBackColor = false;
            this.selectbutton.Click += new System.EventHandler(this.selectbutton_Click);
            // 
            // Payment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::regionalProductTrade.Properties.Resources.payment;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.selectbutton);
            this.Controls.Add(this.paybutton);
            this.Controls.Add(this.rolecomboBox);
            this.Controls.Add(this.amounttextBox);
            this.Controls.Add(this.orderidtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox rolecomboBox;
        private System.Windows.Forms.TextBox amounttextBox;
        private System.Windows.Forms.TextBox orderidtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button paybutton;
        private System.Windows.Forms.Button selectbutton;
    }
}