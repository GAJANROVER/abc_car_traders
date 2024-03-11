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
    public partial class Parts : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Personal\projects\abc_car_traders\abc_car_traders\abc_car_traders\Database2.mdf;Integrated Security=True;";


        public Parts()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Parts_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDahsboard = new AdminDashboard();
            this.Hide();
            adminDahsboard.Show();
        }

        private void partSave_Click(object sender, EventArgs e)
        {
            string name = partName.Text;
            string number = partNumber.Text;
            string model = partCarModel.Text;
            string price = partPrice.Text;

            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(number) && string.IsNullOrEmpty(model) && string.IsNullOrEmpty(price))
            {
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
                SqlCommand cmd = new SqlCommand("INSERT INTO parts (part_name, part_number, part_car_model, part_price) VALUES (@part_name, @part_number, @part_car_model, @part_price)", con);
                cmd.Parameters.AddWithValue("@part_name", name);
                cmd.Parameters.AddWithValue("@part_number", number);
                cmd.Parameters.AddWithValue("@part_car_model", model);
                cmd.Parameters.AddWithValue("@part_price", int.Parse(price));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Part Added Successfully", "Success");

                // Refresh DataGridView
                partDetails_Click(sender, e);

                partName.Text = string.Empty;
                partNumber.Text = string.Empty;
                partCarModel.Text = string.Empty;
                partPrice.Text = string.Empty;
            }

        }

        private void partUpdate_Click(object sender, EventArgs e)
        {
            common common = new common();
            string price = partPrice.Text;

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
                int custoId = Convert.ToInt32(selectedRow.Cells["part_id"].Value);

                // Open connection
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Define the SQL command
                    string query = "UPDATE parts SET part_name = @part_name, part_number = @part_number, part_car_model = @part_car_model, part_price = @part_price WHERE part_id = @part_id";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Add parameters
                    cmd.Parameters.AddWithValue("@part_id", custoId);
                    cmd.Parameters.AddWithValue("@part_name", partName.Text);
                    cmd.Parameters.AddWithValue("@part_number", partNumber.Text);
                    cmd.Parameters.AddWithValue("@part_car_model", partCarModel.Text);
                    cmd.Parameters.AddWithValue("@part_price", int.Parse(partPrice.Text));

                    // Execute the command
                    cmd.ExecuteNonQuery();

                    // Refresh DataGridView
                    partDetails_Click(sender, e);

                    partName.Text = string.Empty;
                    partNumber.Text = string.Empty;
                    partCarModel.Text = string.Empty;
                    partPrice.Text = string.Empty;

                    // Display success message
                    MessageBox.Show("Part Updated Successfully", "Success");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update", "Warning");
            }
        }



        private void partDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the ID of the selected row
                int custoId = Convert.ToInt32(selectedRow.Cells["part_id"].Value);

                // Open connection
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Define the SQL command
                    string query = "DELETE FROM parts WHERE part_id = @part_id";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Add parameters
                    cmd.Parameters.AddWithValue("@part_id", custoId);

                    // Execute the command
                    cmd.ExecuteNonQuery();

                    // Refresh DataGridView
                    partDetails_Click(sender, e);

                    partName.Text = string.Empty;
                    partNumber.Text = string.Empty;
                    partCarModel.Text = string.Empty;
                    partPrice.Text = string.Empty;

                    // Display success message
                    MessageBox.Show("Part Deleted Successfully", "Success");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete", "Warning");
            }
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

        private void selectParts(object sender, EventArgs e)
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

        private void reset_Click(object sender, EventArgs e)
        {
            partName.Text = string.Empty;
            partNumber.Text = string.Empty;
            partCarModel.Text = string.Empty;
            partPrice.Text = string.Empty;
        }
    }
}
