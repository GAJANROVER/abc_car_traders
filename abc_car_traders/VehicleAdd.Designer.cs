namespace abc_car_traders
{
    partial class VehicleAdd
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
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.details = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Centaur", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(415, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 33);
            this.label7.TabIndex = 22;
            this.label7.Text = "Car Details";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 550);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(910, 238);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.SelectCar);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Centaur", 18F);
            this.label6.Location = new System.Drawing.Point(230, 397);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "Car Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Centaur", 18F);
            this.label5.Location = new System.Drawing.Point(230, 344);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Car Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Centaur", 18F);
            this.label4.Location = new System.Drawing.Point(230, 280);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Car Chassis No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Centaur", 18F);
            this.label3.Location = new System.Drawing.Point(230, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Car Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Centaur", 18F);
            this.label2.Location = new System.Drawing.Point(230, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Car Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Centaur", 18F);
            this.label1.Location = new System.Drawing.Point(230, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Car Brand";
            // 
            // carBrand
            // 
            this.carBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.carBrand.Location = new System.Drawing.Point(535, 98);
            this.carBrand.Name = "carBrand";
            this.carBrand.Size = new System.Drawing.Size(134, 29);
            this.carBrand.TabIndex = 23;
            // 
            // carChassisNo
            // 
            this.carChassisNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.carChassisNo.Location = new System.Drawing.Point(535, 278);
            this.carChassisNo.Name = "carChassisNo";
            this.carChassisNo.Size = new System.Drawing.Size(134, 29);
            this.carChassisNo.TabIndex = 24;
            // 
            // carType
            // 
            this.carType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.carType.Location = new System.Drawing.Point(535, 221);
            this.carType.Name = "carType";
            this.carType.Size = new System.Drawing.Size(134, 29);
            this.carType.TabIndex = 25;
            // 
            // carModel
            // 
            this.carModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.carModel.Location = new System.Drawing.Point(535, 158);
            this.carModel.Name = "carModel";
            this.carModel.Size = new System.Drawing.Size(134, 29);
            this.carModel.TabIndex = 26;
            // 
            // carColor
            // 
            this.carColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.carColor.Location = new System.Drawing.Point(535, 395);
            this.carColor.Name = "carColor";
            this.carColor.Size = new System.Drawing.Size(134, 29);
            this.carColor.TabIndex = 27;
            // 
            // carPrice
            // 
            this.carPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.carPrice.Location = new System.Drawing.Point(535, 342);
            this.carPrice.Name = "carPrice";
            this.carPrice.Size = new System.Drawing.Size(134, 29);
            this.carPrice.TabIndex = 28;
            // 
            // dashboard
            // 
            this.dashboard.Font = new System.Drawing.Font("Centaur", 18F);
            this.dashboard.Location = new System.Drawing.Point(88, 462);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(123, 35);
            this.dashboard.TabIndex = 29;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // details
            // 
            this.details.Font = new System.Drawing.Font("Centaur", 18F);
            this.details.Location = new System.Drawing.Point(697, 462);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(114, 35);
            this.details.TabIndex = 30;
            this.details.Text = "Details";
            this.details.UseVisualStyleBackColor = true;
            this.details.Click += new System.EventHandler(this.details_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Centaur", 18F);
            this.save.Location = new System.Drawing.Point(535, 462);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(114, 35);
            this.save.TabIndex = 31;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Centaur", 18F);
            this.update.Location = new System.Drawing.Point(385, 462);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(114, 35);
            this.update.TabIndex = 32;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Centaur", 18F);
            this.delete.Location = new System.Drawing.Point(239, 462);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(114, 35);
            this.delete.TabIndex = 33;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Centaur", 18F);
            this.reset.Location = new System.Drawing.Point(845, 462);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(114, 35);
            this.reset.TabIndex = 34;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // VehicleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(988, 813);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.save);
            this.Controls.Add(this.details);
            this.Controls.Add(this.dashboard);
            this.Controls.Add(this.carPrice);
            this.Controls.Add(this.carColor);
            this.Controls.Add(this.carModel);
            this.Controls.Add(this.carType);
            this.Controls.Add(this.carChassisNo);
            this.Controls.Add(this.carBrand);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VehicleAdd";
            this.Text = "VehicleAdd";
            this.Load += new System.EventHandler(this.VehicleAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button details;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button reset;
    }
}