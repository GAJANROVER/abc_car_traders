using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_car_traders
{
    public partial class Parts : Form
    {
        private object dtglist;

        public Parts()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            // Save Part Details
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Personal\projects\login\login\Database1.mdf;Integrated Security=True"))
            {
                string query = "Insert into car WHERE car_brand = '" + textBox1.Text.Trim() + "' AND car_model = '" + textBox2.Text.Trim() + "' AND car_type = '" + textBox3.Text.Trim() + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dta = new DataTable();
                sda.Fill(dta);
                MessageBox.Show("Part Added Successfully");
           
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            // Update Part Details
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Personal\projects\login\login\Database1.mdf;Integrated Security=True"))
            {
                string query = "update car SET car_brand = '" + textBox1.Text.Trim() + "' AND car_model = '" + textBox2.Text.Trim() + "' AND car_type = '" + textBox3.Text.Trim() + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dta = new DataTable();
                sda.Fill(dta);
                MessageBox.Show("Part Updated Successfully");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Delete Part Details
            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Personal\projects\login\login\Database1.mdf;Integrated Security=True"))
            {
                string query = "DELETE FROM car WHERE car_id = '" + textBox1.Text.Trim()+ "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dta = new DataTable();
                sda.Fill(dta);
                MessageBox.Show("Part Deleted Successfully");

            }
        }
    }
}
