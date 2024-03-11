﻿using System;
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
    public partial class OrderDetailscs : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Personal\projects\abc_car_traders\abc_car_traders\abc_car_traders\Database2.mdf;Integrated Security=True;";
        public OrderDetailscs()
        {
            InitializeComponent();
        }

        private void OrderDetailscs_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlconn = new SqlConnection(connectionString))
            {
                sqlconn.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT o.order_date_time, c.custo_name, c.custo_nic, c.custo_pno, ca.car_brand, ca.car_model, ca.car_chassis_no, ca.car_price, ca.car_color, pa.part_name, pa.part_number, pa.part_number, pa.part_price FROM [order] o LEFT JOIN [order details] od ON o.order_id = od.order_id LEFT JOIN [customer] c ON c.custo_Id = o.customer_id LEFT JOIN [cars] ca ON ca.car_id = od.car_id LEFT JOIN [parts] pa ON pa.part_id = od.part_id", sqlconn);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);

                dataGridView1.DataSource = dt;
                //dataGridView1.Columns["part_id"].Visible = false;
                dataGridView1.ReadOnly = true;
            }
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDahsboard = new AdminDashboard();
            this.Hide();
            adminDahsboard.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
