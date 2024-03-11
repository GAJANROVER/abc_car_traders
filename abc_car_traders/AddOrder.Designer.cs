namespace abc_car_traders
{
    partial class AddOrder
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.order = new System.Windows.Forms.Button();
            this.carDetails = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.carBrand = new System.Windows.Forms.TextBox();
            this.carChassisNo = new System.Windows.Forms.TextBox();
            this.carType = new System.Windows.Forms.TextBox();
            this.carModel = new System.Windows.Forms.TextBox();
            this.carColor = new System.Windows.Forms.TextBox();
            this.carPrice = new System.Windows.Forms.TextBox();
            this.dashboard = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 515);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1003, 281);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.viewCarDetails);
            // 
            // order
            // 
            this.order.Font = new System.Drawing.Font("Centaur", 18F);
            this.order.Location = new System.Drawing.Point(785, 426);
            this.order.Margin = new System.Windows.Forms.Padding(4);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(231, 57);
            this.order.TabIndex = 1;
            this.order.Text = "Order";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // carDetails
            // 
            this.carDetails.Font = new System.Drawing.Font("Centaur", 18F);
            this.carDetails.Location = new System.Drawing.Point(528, 426);
            this.carDetails.Margin = new System.Windows.Forms.Padding(4);
            this.carDetails.Name = "carDetails";
            this.carDetails.Size = new System.Drawing.Size(249, 57);
            this.carDetails.TabIndex = 2;
            this.carDetails.Text = "Show Car Details";
            this.carDetails.UseVisualStyleBackColor = true;
            this.carDetails.Click += new System.EventHandler(this.carDetails_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Centaur", 18F);
            this.label6.Location = new System.Drawing.Point(583, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 33);
            this.label6.TabIndex = 15;
            this.label6.Text = "Car Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Centaur", 18F);
            this.label5.Location = new System.Drawing.Point(70, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 33);
            this.label5.TabIndex = 14;
            this.label5.Text = "Car Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Centaur", 18F);
            this.label4.Location = new System.Drawing.Point(583, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "Car Chassis No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Centaur", 18F);
            this.label3.Location = new System.Drawing.Point(70, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "Car Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Centaur", 18F);
            this.label2.Location = new System.Drawing.Point(583, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 33);
            this.label2.TabIndex = 16;
            this.label2.Text = "Car Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Centaur", 18F);
            this.label1.Location = new System.Drawing.Point(70, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Car Brand";
            // 
            // carBrand
            // 
            this.carBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.carBrand.Location = new System.Drawing.Point(257, 200);
            this.carBrand.Margin = new System.Windows.Forms.Padding(4);
            this.carBrand.Name = "carBrand";
            this.carBrand.Size = new System.Drawing.Size(224, 34);
            this.carBrand.TabIndex = 17;
            // 
            // carChassisNo
            // 
            this.carChassisNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.carChassisNo.Location = new System.Drawing.Point(792, 280);
            this.carChassisNo.Margin = new System.Windows.Forms.Padding(4);
            this.carChassisNo.Name = "carChassisNo";
            this.carChassisNo.Size = new System.Drawing.Size(224, 34);
            this.carChassisNo.TabIndex = 18;
            // 
            // carType
            // 
            this.carType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.carType.Location = new System.Drawing.Point(257, 281);
            this.carType.Margin = new System.Windows.Forms.Padding(4);
            this.carType.Name = "carType";
            this.carType.Size = new System.Drawing.Size(224, 34);
            this.carType.TabIndex = 19;
            // 
            // carModel
            // 
            this.carModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.carModel.Location = new System.Drawing.Point(792, 199);
            this.carModel.Margin = new System.Windows.Forms.Padding(4);
            this.carModel.Name = "carModel";
            this.carModel.Size = new System.Drawing.Size(224, 34);
            this.carModel.TabIndex = 20;
            // 
            // carColor
            // 
            this.carColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.carColor.Location = new System.Drawing.Point(792, 354);
            this.carColor.Margin = new System.Windows.Forms.Padding(4);
            this.carColor.Name = "carColor";
            this.carColor.Size = new System.Drawing.Size(224, 34);
            this.carColor.TabIndex = 21;
            // 
            // carPrice
            // 
            this.carPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.carPrice.Location = new System.Drawing.Point(257, 354);
            this.carPrice.Margin = new System.Windows.Forms.Padding(4);
            this.carPrice.Name = "carPrice";
            this.carPrice.Size = new System.Drawing.Size(224, 34);
            this.carPrice.TabIndex = 22;
            // 
            // dashboard
            // 
            this.dashboard.Font = new System.Drawing.Font("Centaur", 18F);
            this.dashboard.Location = new System.Drawing.Point(62, 24);
            this.dashboard.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(249, 57);
            this.dashboard.TabIndex = 23;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MintCream;
            this.label8.Font = new System.Drawing.Font("Centaur", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(425, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 41);
            this.label8.TabIndex = 59;
            this.label8.Text = "Order Car";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(866, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 22);
            this.label7.TabIndex = 60;
            this.label7.Text = "ABC Car Traders";
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1063, 849);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dashboard);
            this.Controls.Add(this.carPrice);
            this.Controls.Add(this.carColor);
            this.Controls.Add(this.carModel);
            this.Controls.Add(this.carType);
            this.Controls.Add(this.carChassisNo);
            this.Controls.Add(this.carBrand);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carDetails);
            this.Controls.Add(this.order);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddOrder";
            this.Text = "AddOrder";
            this.Load += new System.EventHandler(this.AddOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Button carDetails;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox carBrand;
        private System.Windows.Forms.TextBox carChassisNo;
        private System.Windows.Forms.TextBox carType;
        private System.Windows.Forms.TextBox carModel;
        private System.Windows.Forms.TextBox carColor;
        private System.Windows.Forms.TextBox carPrice;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}