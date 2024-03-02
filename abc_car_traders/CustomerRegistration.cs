using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace abc_car_traders
{
    public partial class CustomerRegistration : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Personal\projects\abc_car_traders\abc_car_traders\abc_car_traders\Database2.mdf;Integrated Security=True;";

        public CustomerRegistration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomerRegistration_Load(object sender, EventArgs e)
        {

        }


        // Customer Add
        private void customer_save_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO customer (custo_name, custo_address, custo_nic, custo_email, custo_pno, custo_pass) VALUES (@custo_name, @custo_address, @custo_nic, @custo_email, @custo_pno, @custo_pass)", con);
                cmd.Parameters.AddWithValue("@custo_name", textBox1Name.Text);
                cmd.Parameters.AddWithValue("@custo_address", textBox2Add.Text);
                cmd.Parameters.AddWithValue("@custo_nic", textBox3Nic.Text);
                cmd.Parameters.AddWithValue("@custo_email", textBox4Email.Text);
                cmd.Parameters.AddWithValue("@custo_pno", textBox5Pno.Text);
                cmd.Parameters.AddWithValue("@custo_pass", "custo123"); // Assuming you have a default password

                cmd.ExecuteNonQuery();

                MessageBox.Show("Customer Created Successfully", "Success");

                // Refresh DataGridView
                show_Click_1(sender, e);
            }
        }

        // Customer View Details
        private void show_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                sqlconn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM customer", sqlconn);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["custo_Id"].Visible = false;
                dataGridView1.ReadOnly = true;
            }
        }

        // Text Field Rest
        private void reset_Click_1(object sender, EventArgs e)
        {
            textBox1Name.Text = string.Empty;
            textBox2Add.Text = string.Empty;
            textBox3Nic.Text = string.Empty;
            textBox4Email.Text = string.Empty;
            textBox5Pno.Text = string.Empty;
        }

        // Customer Delete
        private void delete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the ID of the selected row
                int custoId = Convert.ToInt32(selectedRow.Cells["custo_Id"].Value);

                // Open connection
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Define the SQL command
                    string query = "DELETE FROM customer WHERE custo_Id = @custo_Id";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Add parameters
                    cmd.Parameters.AddWithValue("@custo_Id", custoId);

                    // Execute the command
                    cmd.ExecuteNonQuery();

                    // Refresh DataGridView
                    show_Click_1(sender, e);

                    // Display success message
                    MessageBox.Show("Customer Deleted Successfully", "Success");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete", "Warning");
            }
        }

        // Customer Update
        private void update_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Get the ID of the selected row
                int custoId = Convert.ToInt32(selectedRow.Cells["custo_Id"].Value);

                // Open connection
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Define the SQL command
                    string query = "UPDATE customer SET custo_name = @custo_name, custo_address = @custo_address, custo_nic = @custo_nic, custo_email = @custo_email, custo_pno = @custo_pno, custo_pass = @custo_pass WHERE custo_Id = @custo_Id";
                    SqlCommand cmd = new SqlCommand(query, con);

                    // Add parameters
                    cmd.Parameters.AddWithValue("@custo_Id", custoId);
                    cmd.Parameters.AddWithValue("@custo_name", textBox1Name.Text);
                    cmd.Parameters.AddWithValue("@custo_address", textBox2Add.Text);
                    cmd.Parameters.AddWithValue("@custo_nic", textBox3Nic.Text);
                    cmd.Parameters.AddWithValue("@custo_email", textBox4Email.Text);
                    cmd.Parameters.AddWithValue("@custo_pno", int.Parse(textBox5Pno.Text));
                    cmd.Parameters.AddWithValue("@custo_pass", textBox1Pw.Text);

                    // Execute the command
                    cmd.ExecuteNonQuery();

                    // Refresh DataGridView
                    show_Click_1(sender, e);

                    // Display success message
                    MessageBox.Show("Customer Updated Successfully", "Success");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update", "Warning");
            }
        }


 

        private void SelectCustomer(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Populate text fields with values from the selected row
                textBox1Name.Text = Convert.ToString(selectedRow.Cells["custo_name"].Value);
                textBox2Add.Text = Convert.ToString(selectedRow.Cells["custo_address"].Value);
                textBox3Nic.Text = Convert.ToString(selectedRow.Cells["custo_nic"].Value);
                textBox4Email.Text = Convert.ToString(selectedRow.Cells["custo_email"].Value);
                textBox5Pno.Text = Convert.ToString(selectedRow.Cells["custo_pno"].Value);
                textBox1Pw.Text = Convert.ToString(selectedRow.Cells["custo_pass"].Value);
            }
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDahsboard = new AdminDashboard();
            this.Hide();
            adminDahsboard.Show();
        }
    }
}
