using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static regionalProductTrade.Login;
using static System.Collections.Specialized.BitVector32;

namespace regionalProductTrade
{
    public partial class buyerDashboard: Form
    {
        int id;
        public buyerDashboard(int userId)
        {
            InitializeComponent();
            id = userId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            BuyerViewProduct f4 = new BuyerViewProduct(id);
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
            RateSeller f7 = new RateSeller(id);
            f7.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BuyerOrder f9 = new BuyerOrder(id);
            f9.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RequestProduct f12 = new RequestProduct(id);
            f12.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateProfile up1 = new UpdateProfile(id);
            up1.Show();
        }
    }
}
