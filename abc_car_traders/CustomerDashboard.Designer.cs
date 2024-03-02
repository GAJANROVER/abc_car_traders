namespace abc_car_traders
{
    partial class CustomerDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDashboard));
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkOrders = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.orderNewCar = new System.Windows.Forms.Button();
            this.orderCarPart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Centaur", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(681, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(346, 33);
            this.label7.TabIndex = 65;
            this.label7.Text = "Welcome to ABC Car Traders";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 516);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 50.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 73);
            this.label1.TabIndex = 67;
            this.label1.Text = "ABC Car Traders";
            // 
            // checkOrders
            // 
            this.checkOrders.Font = new System.Drawing.Font("Centaur", 18F);
            this.checkOrders.Location = new System.Drawing.Point(653, 227);
            this.checkOrders.Name = "checkOrders";
            this.checkOrders.Size = new System.Drawing.Size(187, 35);
            this.checkOrders.TabIndex = 69;
            this.checkOrders.Text = "Check Orders";
            this.checkOrders.UseVisualStyleBackColor = true;
            this.checkOrders.Click += new System.EventHandler(this.checkOrders_Click);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Centaur", 18F);
            this.logout.Location = new System.Drawing.Point(926, 227);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(180, 35);
            this.logout.TabIndex = 70;
            this.logout.Text = "logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // orderNewCar
            // 
            this.orderNewCar.Font = new System.Drawing.Font("Centaur", 18F);
            this.orderNewCar.Location = new System.Drawing.Point(653, 140);
            this.orderNewCar.Name = "orderNewCar";
            this.orderNewCar.Size = new System.Drawing.Size(187, 34);
            this.orderNewCar.TabIndex = 71;
            this.orderNewCar.Text = "Order New Car";
            this.orderNewCar.UseVisualStyleBackColor = true;
            this.orderNewCar.Click += new System.EventHandler(this.orderNewCar_Click);
            // 
            // orderCarPart
            // 
            this.orderCarPart.Font = new System.Drawing.Font("Centaur", 18F);
            this.orderCarPart.Location = new System.Drawing.Point(926, 140);
            this.orderCarPart.Name = "orderCarPart";
            this.orderCarPart.Size = new System.Drawing.Size(180, 34);
            this.orderCarPart.TabIndex = 72;
            this.orderCarPart.Text = "Order Car Part";
            this.orderCarPart.UseVisualStyleBackColor = true;
            this.orderCarPart.Click += new System.EventHandler(this.orderCarPart_Click);
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 585);
            this.Controls.Add(this.orderCarPart);
            this.Controls.Add(this.orderNewCar);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.checkOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Name = "CustomerDashboard";
            this.Text = "CustomerDashboard";
            this.Load += new System.EventHandler(this.CustomerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkOrders;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button orderNewCar;
        private System.Windows.Forms.Button orderCarPart;
    }
}