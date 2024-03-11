namespace abc_car_traders
{
    partial class Orderpart
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
            this.dashboard = new System.Windows.Forms.Button();
            this.partDetails = new System.Windows.Forms.Button();
            this.order = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.partName = new System.Windows.Forms.TextBox();
            this.partPrice = new System.Windows.Forms.TextBox();
            this.partCarModel = new System.Windows.Forms.TextBox();
            this.partNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 410);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 336);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.viewPart);
            // 
            // dashboard
            // 
            this.dashboard.Font = new System.Drawing.Font("Centaur", 18F);
            this.dashboard.Location = new System.Drawing.Point(44, 29);
            this.dashboard.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(223, 55);
            this.dashboard.TabIndex = 1;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // partDetails
            // 
            this.partDetails.Font = new System.Drawing.Font("Centaur", 18F);
            this.partDetails.Location = new System.Drawing.Point(655, 333);
            this.partDetails.Margin = new System.Windows.Forms.Padding(4);
            this.partDetails.Name = "partDetails";
            this.partDetails.Size = new System.Drawing.Size(257, 55);
            this.partDetails.TabIndex = 2;
            this.partDetails.Text = "Show Part Details";
            this.partDetails.UseVisualStyleBackColor = true;
            this.partDetails.Click += new System.EventHandler(this.partDetails_Click);
            // 
            // order
            // 
            this.order.Font = new System.Drawing.Font("Centaur", 18F);
            this.order.Location = new System.Drawing.Point(936, 333);
            this.order.Margin = new System.Windows.Forms.Padding(4);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(123, 55);
            this.order.TabIndex = 3;
            this.order.Text = "Order";
            this.order.UseVisualStyleBackColor = true;
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Centaur", 18F);
            this.label4.Location = new System.Drawing.Point(609, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 33);
            this.label4.TabIndex = 52;
            this.label4.Text = "Part Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Centaur", 18F);
            this.label3.Location = new System.Drawing.Point(86, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 33);
            this.label3.TabIndex = 51;
            this.label3.Text = "Part Car Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Centaur", 18F);
            this.label2.Location = new System.Drawing.Point(599, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 33);
            this.label2.TabIndex = 53;
            this.label2.Text = "Part Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Centaur", 18F);
            this.label1.Location = new System.Drawing.Point(86, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 33);
            this.label1.TabIndex = 50;
            this.label1.Text = "Part Name";
            // 
            // partName
            // 
            this.partName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.partName.Location = new System.Drawing.Point(294, 176);
            this.partName.Margin = new System.Windows.Forms.Padding(4);
            this.partName.Name = "partName";
            this.partName.Size = new System.Drawing.Size(231, 34);
            this.partName.TabIndex = 54;
            // 
            // partPrice
            // 
            this.partPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.partPrice.Location = new System.Drawing.Point(828, 259);
            this.partPrice.Margin = new System.Windows.Forms.Padding(4);
            this.partPrice.Name = "partPrice";
            this.partPrice.Size = new System.Drawing.Size(231, 34);
            this.partPrice.TabIndex = 55;
            // 
            // partCarModel
            // 
            this.partCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.partCarModel.Location = new System.Drawing.Point(294, 260);
            this.partCarModel.Margin = new System.Windows.Forms.Padding(4);
            this.partCarModel.Name = "partCarModel";
            this.partCarModel.Size = new System.Drawing.Size(231, 34);
            this.partCarModel.TabIndex = 56;
            // 
            // partNumber
            // 
            this.partNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.partNumber.Location = new System.Drawing.Point(828, 176);
            this.partNumber.Margin = new System.Windows.Forms.Padding(4);
            this.partNumber.Name = "partNumber";
            this.partNumber.Size = new System.Drawing.Size(231, 34);
            this.partNumber.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Centaur", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(491, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 41);
            this.label7.TabIndex = 58;
            this.label7.Text = "Order Part";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(909, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 22);
            this.label5.TabIndex = 59;
            this.label5.Text = "ABC Car Traders";
            // 
            // Orderpart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1163, 826);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.partNumber);
            this.Controls.Add(this.partCarModel);
            this.Controls.Add(this.partPrice);
            this.Controls.Add(this.partName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.order);
            this.Controls.Add(this.partDetails);
            this.Controls.Add(this.dashboard);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Orderpart";
            this.Text = "Orderpart";
            this.Load += new System.EventHandler(this.Orderpart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Button partDetails;
        private System.Windows.Forms.Button order;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox partName;
        private System.Windows.Forms.TextBox partPrice;
        private System.Windows.Forms.TextBox partCarModel;
        private System.Windows.Forms.TextBox partNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}