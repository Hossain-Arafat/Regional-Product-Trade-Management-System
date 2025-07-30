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
    public partial class AdminDashboard: Form
    {
        
        public AdminDashboard()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseForm dbf = new DatabaseForm();
            dbf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminViewProduct avp = new AdminViewProduct();
            avp.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            AdminViewRequest avr = new AdminViewRequest();
            avr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminViewOrder avo = new AdminViewOrder();
            avo.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit the application?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
