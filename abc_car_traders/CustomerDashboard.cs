using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_car_traders
{
    public partial class CustomerDashboard : Form
    {
        private int loggedInUserId;
        public CustomerDashboard(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }

        private void checkOrders_Click(object sender, EventArgs e)
        {
            checkOrders checkOrders = new checkOrders(loggedInUserId);
            this.Hide();
            checkOrders.Show();
        }

        private void orderNewCar_Click(object sender, EventArgs e)
        {
            AddOrder CarOrder = new AddOrder(loggedInUserId);
            this.Hide();
            CarOrder.Show();
        }

        private void orderCarPart_Click(object sender, EventArgs e)
        {
            Orderpart Orderpart = new Orderpart(loggedInUserId);
            this.Hide();
            Orderpart.Show();
        }
    }
}
