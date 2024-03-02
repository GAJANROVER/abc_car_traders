using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_car_traders
{
    public partial class AddOrder : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Personal\projects\abc_car_traders\abc_car_traders\abc_car_traders\Database2.mdf;Integrated Security=True;";
        private int loggedInUserId;
        public AddOrder(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
        }

        private void carDetails_Click(object sender, EventArgs e)
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

        private void viewCarDetails(object sender, EventArgs e)
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

        private void AddOrder_Load(object sender, EventArgs e)
        {

        }

        private void order_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the ID of the selected row
                int carId = Convert.ToInt32(selectedRow.Cells["car_id"].Value);
                // Open connection
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Insert into order table
                    SqlCommand cmdOrder = new SqlCommand("INSERT INTO [order] (customer_id, order_date_time, order_status) " +
                         "VALUES (@customer_id, GETDATE(), 'Ordered'); SELECT SCOPE_IDENTITY();", con);
                    cmdOrder.Parameters.AddWithValue("@customer_id", loggedInUserId);
                    int orderId = Convert.ToInt32(cmdOrder.ExecuteScalar()); // Get the inserted order_id


                    // Insert into order details table
                    SqlCommand cmdOrderDetails = new SqlCommand("INSERT INTO [order details] (order_id, car_id, uni_price) " +
                            "VALUES (@order_id, @car_id, @car_price)", con);
                    cmdOrderDetails.Parameters.AddWithValue("@order_id", orderId); // Use the retrieved order_id
                    cmdOrderDetails.Parameters.AddWithValue("@car_id", carId);
                    cmdOrderDetails.Parameters.AddWithValue("@car_price", carPrice.Text);
                    cmdOrderDetails.ExecuteNonQuery();

                    // Clear the text fields
                    reset();

                    // Display success message
                    MessageBox.Show("Car Ordered Successfully", "Success");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to Order", "Warning");
            }
        }

        private void reset() {
            carBrand.Text = string.Empty;
            carModel.Text = string.Empty;
            carType.Text = string.Empty;
            carChassisNo.Text = string.Empty;
            carPrice.Text = string.Empty;
            carColor.Text = string.Empty;
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            CustomerDashboard CustomerDashboard = new CustomerDashboard(loggedInUserId);
            this.Hide();
            CustomerDashboard.Show();
        }
    }
}
