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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //private void button2_Click(object sender, EventArgs e)
        //{

        //}

     

        private void label4_Click(object sender, EventArgs e)
        {

        }

    

        private bool isValid()
        {
            if (textBox1.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter the User Name", "error");
                return false;
            }
            else if (textBox2.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter the valid password", "error");
                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                int loggedInUserId = -1; // Initialize with a default value indicating no user logged in

                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Personal\projects\abc_car_traders\abc_car_traders\abc_car_traders\Database2.mdf;Integrated Security=True"))
                {
                    string query = "SELECT * FROM admin WHERE admin_user_name = '" + textBox1.Text.Trim() + "' AND admin_pass = '" + textBox2.Text.Trim() + "' ";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dta = new DataTable();
                    sda.Fill(dta);

                    string queryCusto = "SELECT custo_id  FROM customer WHERE custo_name = '" + textBox1.Text.Trim() + "' AND custo_pass = '" + textBox2.Text.Trim() + "' ";
                    SqlDataAdapter sdaCusto = new SqlDataAdapter(queryCusto, conn);
                    DataTable dtaCusto = new DataTable();
                    sdaCusto.Fill(dtaCusto);


                    if (dta.Rows.Count == 1)
                    {
                        AdminDashboard adminDashboard = new AdminDashboard();
                        this.Hide();
                        adminDashboard.Show();

                    }else if(dtaCusto.Rows.Count == 1) {

                        // Get the logged-in user ID from the customer table
                        loggedInUserId = Convert.ToInt32(dtaCusto.Rows[0]["custo_id"]);

                        CustomerDashboard CustomerDashboard = new CustomerDashboard(loggedInUserId);
                        this.Hide();
                        CustomerDashboard.Show();

                    } else {
                        MessageBox.Show("Invalid username and password", "error");
                    }
                }

            }
        }

        private void customer_signup_Click(object sender, EventArgs e)
        {
            CustomerSignUP customerSignUP = new CustomerSignUP();
            this.Hide();
            customerSignUP.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
