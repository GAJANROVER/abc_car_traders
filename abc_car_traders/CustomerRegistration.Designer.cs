using System;

namespace abc_car_traders
{
    partial class CustomerRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.delete = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.customer_save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox5Pno = new System.Windows.Forms.TextBox();
            this.textBox4Email = new System.Windows.Forms.TextBox();
            this.textBox3Nic = new System.Windows.Forms.TextBox();
            this.textBox2Add = new System.Windows.Forms.TextBox();
            this.textBox1Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboard = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1Pw = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Centaur", 18F);
            this.delete.Location = new System.Drawing.Point(290, 429);
            this.delete.Margin = new System.Windows.Forms.Padding(4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(140, 47);
            this.delete.TabIndex = 41;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click_1);
            // 
            // show
            // 
            this.show.Font = new System.Drawing.Font("Centaur", 18F);
            this.show.Location = new System.Drawing.Point(541, 430);
            this.show.Margin = new System.Windows.Forms.Padding(4);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(115, 47);
            this.show.TabIndex = 40;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Centaur", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(428, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 41);
            this.label6.TabIndex = 39;
            this.label6.Text = "Customer Registration";
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Centaur", 18F);
            this.update.Location = new System.Drawing.Point(152, 430);
            this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(131, 46);
            this.update.TabIndex = 38;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click_1);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Centaur", 18F);
            this.reset.Location = new System.Drawing.Point(437, 430);
            this.reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(97, 47);
            this.reset.TabIndex = 37;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click_1);
            // 
            // customer_save
            // 
            this.customer_save.Font = new System.Drawing.Font("Centaur", 18F);
            this.customer_save.Location = new System.Drawing.Point(41, 430);
            this.customer_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customer_save.Name = "customer_save";
            this.customer_save.Size = new System.Drawing.Size(105, 47);
            this.customer_save.TabIndex = 36;
            this.customer_save.Text = "Save";
            this.customer_save.UseVisualStyleBackColor = true;
            this.customer_save.Click += new System.EventHandler(this.customer_save_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 498);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1148, 293);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.Click += new System.EventHandler(this.SelectCustomer);
            // 
            // textBox5Pno
            // 
            this.textBox5Pno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox5Pno.Location = new System.Drawing.Point(952, 349);
            this.textBox5Pno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5Pno.Name = "textBox5Pno";
            this.textBox5Pno.Size = new System.Drawing.Size(235, 34);
            this.textBox5Pno.TabIndex = 34;
            // 
            // textBox4Email
            // 
            this.textBox4Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox4Email.Location = new System.Drawing.Point(267, 262);
            this.textBox4Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4Email.Name = "textBox4Email";
            this.textBox4Email.Size = new System.Drawing.Size(264, 34);
            this.textBox4Email.TabIndex = 33;
            // 
            // textBox3Nic
            // 
            this.textBox3Nic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox3Nic.Location = new System.Drawing.Point(918, 261);
            this.textBox3Nic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3Nic.Name = "textBox3Nic";
            this.textBox3Nic.Size = new System.Drawing.Size(264, 34);
            this.textBox3Nic.TabIndex = 32;
            // 
            // textBox2Add
            // 
            this.textBox2Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox2Add.Location = new System.Drawing.Point(918, 177);
            this.textBox2Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2Add.Name = "textBox2Add";
            this.textBox2Add.Size = new System.Drawing.Size(264, 34);
            this.textBox2Add.TabIndex = 31;
            // 
            // textBox1Name
            // 
            this.textBox1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox1Name.Location = new System.Drawing.Point(267, 178);
            this.textBox1Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1Name.Name = "textBox1Name";
            this.textBox1Name.Size = new System.Drawing.Size(264, 34);
            this.textBox1Name.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Centaur", 18F);
            this.label5.Location = new System.Drawing.Point(605, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(307, 33);
            this.label5.TabIndex = 28;
            this.label5.Text = "Customer Mobile Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Centaur", 18F);
            this.label4.Location = new System.Drawing.Point(24, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 33);
            this.label4.TabIndex = 27;
            this.label4.Text = "Customer Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Centaur", 18F);
            this.label3.Location = new System.Drawing.Point(605, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 33);
            this.label3.TabIndex = 26;
            this.label3.Text = "Customer Nic";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Centaur", 18F);
            this.label2.Location = new System.Drawing.Point(605, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 33);
            this.label2.TabIndex = 29;
            this.label2.Text = "Customer Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Centaur", 18F);
            this.label1.Location = new System.Drawing.Point(24, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 33);
            this.label1.TabIndex = 25;
            this.label1.Text = "Customer Name";
            // 
            // dashboard
            // 
            this.dashboard.Font = new System.Drawing.Font("Centaur", 18F);
            this.dashboard.Location = new System.Drawing.Point(39, 36);
            this.dashboard.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(155, 44);
            this.dashboard.TabIndex = 42;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Centaur", 18F);
            this.label7.Location = new System.Drawing.Point(24, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 33);
            this.label7.TabIndex = 43;
            this.label7.Text = "Customer Password";
            // 
            // textBox1Pw
            // 
            this.textBox1Pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox1Pw.Location = new System.Drawing.Point(267, 350);
            this.textBox1Pw.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1Pw.Name = "textBox1Pw";
            this.textBox1Pw.Size = new System.Drawing.Size(264, 34);
            this.textBox1Pw.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1003, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 22);
            this.label8.TabIndex = 60;
            this.label8.Text = "ABC Car Traders";
            // 
            // CustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1232, 974);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1Pw);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dashboard);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.show);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.update);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.customer_save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox5Pno);
            this.Controls.Add(this.textBox4Email);
            this.Controls.Add(this.textBox3Nic);
            this.Controls.Add(this.textBox2Add);
            this.Controls.Add(this.textBox1Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerRegistration";
            this.Text = "CustomerRegistration";
            this.Load += new System.EventHandler(this.CustomerRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button update;
        public System.Windows.Forms.Button reset;
        public System.Windows.Forms.Button customer_save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox5Pno;
        private System.Windows.Forms.TextBox textBox4Email;
        private System.Windows.Forms.TextBox textBox3Nic;
        private System.Windows.Forms.TextBox textBox2Add;
        private System.Windows.Forms.TextBox textBox1Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1Pw;
        private System.Windows.Forms.Label label8;
    }
}