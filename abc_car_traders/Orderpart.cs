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
    public partial class Orderpart : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Personal\projects\abc_car_traders\abc_car_traders\abc_car_traders\Database2.mdf;Integrated Security=True;";
        private int loggedInUserId;
        public Orderpart(int userId)
        {
            InitializeComponent();
            loggedInUserId = userId;
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            CustomerDashboard CustomerDashboard = new CustomerDashboard(loggedInUserId);
            this.Hide();
            CustomerDashboard.Show();
        }

        private void Orderpart_Load(object sender, EventArgs e)
        {

        }

        private void partDetails_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                sqlconn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM parts", sqlconn);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["part_id"].Visible = false;
                dataGridView1.ReadOnly = true;
            }
        }

        private void order_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the ID of the selected row
                int partId = Convert.ToInt32(selectedRow.Cells["part_id"].Value);
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
                    SqlCommand cmdOrderDetails = new SqlCommand("INSERT INTO [order details] (order_id, part_id, uni_price) " +
                            "VALUES (@order_id, @part_id, @part_price)", con);
                    cmdOrderDetails.Parameters.AddWithValue("@order_id", orderId); // Use the retrieved order_id
                    cmdOrderDetails.Parameters.AddWithValue("@part_id", partId);
                    cmdOrderDetails.Parameters.AddWithValue("@part_price", partPrice.Text);
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
        private void reset()
        {
            partName.Text = string.Empty;
            partNumber.Text = string.Empty;
            partCarModel.Text = string.Empty;
            partPrice.Text = string.Empty;
        }

        private void viewPart(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Populate text fields with values from the selected row
                partName.Text = Convert.ToString(selectedRow.Cells["part_name"].Value);
                partNumber.Text = Convert.ToString(selectedRow.Cells["part_number"].Value);
                partCarModel.Text = Convert.ToString(selectedRow.Cells["part_car_model"].Value);
                partPrice.Text = Convert.ToString(selectedRow.Cells["part_price"].Value);

            }
        }
    }
}
