using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static regionalProductTrade.Login;

namespace regionalProductTrade
{
    public partial class SellerDashboard: Form
    {
        int Id;
        public SellerDashboard(int userId)
        {
            InitializeComponent();
            Id = userId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SellerAddProduct f4 = new SellerAddProduct(Id);
            f4.Show();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout from the application?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                SessionManager.ClearSession();
                Application.Restart();
                Login l1 = new Login();
                l1.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SellerViewProductsFrom f4 = new SellerViewProductsFrom(Id);
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewRating f8 = new ViewRating(Id);
            f8.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SellerOrder f10 = new SellerOrder(Id);
            f10.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateProfile up2 = new UpdateProfile(Id);
            up2.Show();
        }
    }
}
