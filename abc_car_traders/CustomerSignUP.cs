using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc_car_traders
{
    public partial class CustomerSignUP : Form
    {   
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Personal\projects\abc_car_traders\abc_car_traders\abc_car_traders\Database2.mdf;Integrated Security=True;";

        public CustomerSignUP()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CustomerSignUP_Load(object sender, EventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Hide();
            home.Show();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            common common = new common();
            string name = textBox1Name.Text;
            string address = textBox2Add.Text;
            string nic = textBox3Nic.Text;
            string email = textBox4Email.Text;
            string pno = textBox5Pno.Text;
            string pw = textBox1Pw.Text;

            bool validEmail = common.IsValidEmail(email);
            bool validName = common.ContainsOnlyLetters(name);
            bool validPno = common.ContainsOnlyNumbers(pno);

            if (!validName && (!string.IsNullOrEmpty(name)))
            {
                MessageBox.Show("Name should contain only letters.", "Warning");
                return;
            }
            else if (!validEmail && (!string.IsNullOrEmpty(email)))
            {
                MessageBox.Show("Invalid email address.", "Warning");
                return;
            }
            else if (pno.Length != 10 && (!string.IsNullOrEmpty(pno)))
            {
                MessageBox.Show("Phone number must contain exactly 10 numeric characters.", "Warning");
                return;
            }
            else if (!validPno && (!string.IsNullOrEmpty(pno)))
            {
                MessageBox.Show("Phone number should contain only numbers.", "Warning");
                return;
            }
            else if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(address) && string.IsNullOrEmpty(nic) && string.IsNullOrEmpty(email) && string.IsNullOrEmpty(pno) && string.IsNullOrEmpty(pw))
            {
                MessageBox.Show("Can't Save Empty Record", "Warning");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO customer (custo_name, custo_address, custo_nic, custo_email, custo_pno, custo_pass) VALUES (@custo_name, @custo_address, @custo_nic, @custo_email, @custo_pno, @custo_pass)", con);
                cmd.Parameters.AddWithValue("@custo_name", textBox1Name.Text);
                cmd.Parameters.AddWithValue("@custo_address", textBox2Add.Text);
                cmd.Parameters.AddWithValue("@custo_nic", textBox3Nic.Text);
                cmd.Parameters.AddWithValue("@custo_email", textBox4Email.Text);
                cmd.Parameters.AddWithValue("@custo_pno", int.Parse(textBox5Pno.Text));
                cmd.Parameters.AddWithValue("@custo_pass", textBox1Pw.Text); // Assuming you have a default password

                cmd.ExecuteNonQuery();

                MessageBox.Show("Customer Created Successfully", "Success");

                // Refresh DataGridView
                home_Click(sender, e);
            }
        }
    }
}
