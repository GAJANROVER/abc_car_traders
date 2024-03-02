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

    public partial class AdminDashboard : Form
    {

        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
      
        }

        private void orderDetails_Click(object sender, EventArgs e)
        {
            OrderDetailscs OrderDetailscs = new OrderDetailscs();
            this.Hide();
            OrderDetailscs.Show();
        }

        private void customerDetails_Click(object sender, EventArgs e)
        {
            CustomerRegistration customerRegistration = new CustomerRegistration();
            this.Hide();
            customerRegistration.Show();
        }

        private void carDetails_Click(object sender, EventArgs e)
        {
            VehicleAdd vehicles = new VehicleAdd();
            this.Hide();
            vehicles.Show();  
        }

        private void partsDetails_Click(object sender, EventArgs e)
        {
            Parts parts = new Parts();
            this.Hide();
            parts.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }
    }
}
