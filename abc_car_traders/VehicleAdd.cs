using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_car_traders
{
    public partial class VehicleAdd : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Personal\projects\abc_car_traders\abc_car_traders\abc_car_traders\Database2.mdf;Integrated Security=True;";

        public VehicleAdd()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void VehicleAdd_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDahsboard = new AdminDashboard();
            this.Hide();
            adminDahsboard.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
          
            string brand = carBrand.Text;
            string model = carModel.Text;
            string type = carType.Text;
            string chassisNo = carChassisNo.Text;
            string price = carPrice.Text;
            string color = carColor.Text;

            if (string.IsNullOrEmpty(brand) && string.IsNullOrEmpty(model) && string.IsNullOrEmpty(type) && string.IsNullOrEmpty(chassisNo) && string.IsNullOrEmpty(price) && string.IsNullOrEmpty(color)) {
                MessageBox.Show("Can't Save Empty Record", "Warning");
                return;
            }

            common common = new common();
            bool validPrice = common.ContainsOnlyNumbers(price);
            if (!validPrice && (!string.IsNullOrEmpty(price)))
            {
                MessageBox.Show("Part price should contain only numbers.", "Warning");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO cars (car_brand, car_model, car_type, car_chassis_no,car_price,car_color) " +
                    "VALUES (@car_brand, @car_model, @car_type, @car_chassis_no, @car_price, @car_color)", con);

                cmd.Parameters.AddWithValue("@car_brand", brand);
                cmd.Parameters.AddWithValue("@car_model", model);
                cmd.Parameters.AddWithValue("@car_type", type);
                cmd.Parameters.AddWithValue("@car_chassis_no", chassisNo);
                cmd.Parameters.AddWithValue("@car_price", int.Parse(price));
                cmd.Parameters.AddWithValue("@car_color", color);



                cmd.ExecuteNonQuery();

                MessageBox.Show("Car Added Successfully", "Success");

                // Refresh DataGridView
                details_Click(sender, e);

                // reset text field
                reset_Click(sender, e);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            common common = new common();
            string price = carPrice.Text;

            bool validPrice = common.ContainsOnlyNumbers(price);
            if (!validPrice && (!string.IsNullOrEmpty(price)))
            {
                MessageBox.Show("Part price should contain only numbers.", "Warning");
                return;
            }

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the ID of the selected row
                int custoId = Convert.ToInt32(selectedRow.Cells["car_id"].Value);

                // Open connection
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Define the SQL command
                    string query = "UPDATE cars SET car_brand = @car_brand, car_model = @car_model, car_type = @car_type, car_chassis_no = @car_chassis_no, car_price = @car_price, car_color = @car_color WHERE car_id = @car_id";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Add parameters
                    cmd.Parameters.AddWithValue("@car_id", custoId);
                    cmd.Parameters.AddWithValue("@car_brand", carBrand.Text);
                    cmd.Parameters.AddWithValue("@car_model", carModel.Text);
                    cmd.Parameters.AddWithValue("car_type", carType.Text);
                    cmd.Parameters.AddWithValue("@car_chassis_no", carChassisNo.Text);
                    cmd.Parameters.AddWithValue("@car_price", int.Parse(carPrice.Text));
                    cmd.Parameters.AddWithValue("@car_color", carColor.Text);


                    // Execute the command
                    cmd.ExecuteNonQuery();

                    // Refresh DataGridView
                    details_Click(sender, e);

                    // reset text field
                    reset_Click(sender, e);

                    // Display success message
                    MessageBox.Show("Car Updated Successfully", "Success");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update", "Warning");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the ID of the selected row
                int custoId = Convert.ToInt32(selectedRow.Cells["car_id"].Value);

                // Open connection
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Define the SQL command
                    string query = "DELETE FROM cars WHERE car_id = @car_id";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Add parameters
                    cmd.Parameters.AddWithValue("@car_id", custoId);

                    // Execute the command
                    cmd.ExecuteNonQuery();

                    // Refresh DataGridView
                    details_Click(sender, e);

                    // reset text field
                    reset_Click(sender, e);

                    // Display success message
                    MessageBox.Show("Car Deleted Successfully", "Success");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete", "Warning");
            }
        }

        private void details_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                sqlconn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM cars", sqlconn);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["car_id"].Visible = false;
                dataGridView1.ReadOnly = true;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            carBrand.Text = string.Empty;
            carModel.Text = string.Empty;
            carType.Text = string.Empty;
            carChassisNo.Text = string.Empty;
            carPrice.Text = string.Empty;
            carColor.Text = string.Empty;
        }

        private void SelectCar(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Populate text fields with values from the selected row
                carBrand.Text = Convert.ToString(selectedRow.Cells["car_brand"].Value);
                carModel.Text = Convert.ToString(selectedRow.Cells["car_model"].Value);
                carType.Text = Convert.ToString(selectedRow.Cells["car_type"].Value);
                carChassisNo.Text = Convert.ToString(selectedRow.Cells["car_chassis_no"].Value);
                carPrice.Text = Convert.ToString(selectedRow.Cells["car_price"].Value);
                carColor.Text = Convert.ToString(selectedRow.Cells["car_color"].Value);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
