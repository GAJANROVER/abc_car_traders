namespace abc_car_traders
{
    partial class Parts
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dashboard = new System.Windows.Forms.Button();
            this.partDelete = new System.Windows.Forms.Button();
            this.partSave = new System.Windows.Forms.Button();
            this.partUpdate = new System.Windows.Forms.Button();
            this.partDetails = new System.Windows.Forms.Button();
            this.partName = new System.Windows.Forms.TextBox();
            this.partNumber = new System.Windows.Forms.TextBox();
            this.partPrice = new System.Windows.Forms.TextBox();
            this.partCarModel = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Centaur", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(566, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 41);
            this.label7.TabIndex = 39;
            this.label7.Text = "Part Details";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 409);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1001, 293);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.Click += new System.EventHandler(this.selectParts);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Centaur", 18F);
            this.label4.Location = new System.Drawing.Point(646, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 33);
            this.label4.TabIndex = 25;
            this.label4.Text = "Part Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Centaur", 18F);
            this.label3.Location = new System.Drawing.Point(102, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 33);
            this.label3.TabIndex = 24;
            this.label3.Text = "Part Car Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Centaur", 18F);
            this.label2.Location = new System.Drawing.Point(646, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 33);
            this.label2.TabIndex = 28;
            this.label2.Text = "Part Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Centaur", 18F);
            this.label1.Location = new System.Drawing.Point(102, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 33);
            this.label1.TabIndex = 23;
            this.label1.Text = "Part Name";
            // 
            // dashboard
            // 
            this.dashboard.Font = new System.Drawing.Font("Centaur", 18F);
            this.dashboard.Location = new System.Drawing.Point(83, 23);
            this.dashboard.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(213, 41);
            this.dashboard.TabIndex = 41;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // partDelete
            // 
            this.partDelete.Font = new System.Drawing.Font("Centaur", 18F);
            this.partDelete.Location = new System.Drawing.Point(672, 336);
            this.partDelete.Margin = new System.Windows.Forms.Padding(4);
            this.partDelete.Name = "partDelete";
            this.partDelete.Size = new System.Drawing.Size(132, 41);
            this.partDelete.TabIndex = 42;
            this.partDelete.Text = "Delete";
            this.partDelete.UseVisualStyleBackColor = true;
            this.partDelete.Click += new System.EventHandler(this.partDelete_Click);
            // 
            // partSave
            // 
            this.partSave.Font = new System.Drawing.Font("Centaur", 18F);
            this.partSave.Location = new System.Drawing.Point(421, 336);
            this.partSave.Margin = new System.Windows.Forms.Padding(4);
            this.partSave.Name = "partSave";
            this.partSave.Size = new System.Drawing.Size(100, 41);
            this.partSave.TabIndex = 43;
            this.partSave.Text = "Save";
            this.partSave.UseVisualStyleBackColor = true;
            this.partSave.Click += new System.EventHandler(this.partSave_Click);
            // 
            // partUpdate
            // 
            this.partUpdate.Font = new System.Drawing.Font("Centaur", 18F);
            this.partUpdate.Location = new System.Drawing.Point(529, 336);
            this.partUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.partUpdate.Name = "partUpdate";
            this.partUpdate.Size = new System.Drawing.Size(135, 41);
            this.partUpdate.TabIndex = 44;
            this.partUpdate.Text = "Update";
            this.partUpdate.UseVisualStyleBackColor = true;
            this.partUpdate.Click += new System.EventHandler(this.partUpdate_Click);
            // 
            // partDetails
            // 
            this.partDetails.Font = new System.Drawing.Font("Centaur", 18F);
            this.partDetails.Location = new System.Drawing.Point(812, 336);
            this.partDetails.Margin = new System.Windows.Forms.Padding(4);
            this.partDetails.Name = "partDetails";
            this.partDetails.Size = new System.Drawing.Size(132, 41);
            this.partDetails.TabIndex = 45;
            this.partDetails.Text = "Details";
            this.partDetails.UseVisualStyleBackColor = true;
            this.partDetails.Click += new System.EventHandler(this.partDetails_Click);
            // 
            // partName
            // 
            this.partName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.partName.Location = new System.Drawing.Point(322, 142);
            this.partName.Margin = new System.Windows.Forms.Padding(4);
            this.partName.Name = "partName";
            this.partName.Size = new System.Drawing.Size(193, 34);
            this.partName.TabIndex = 46;
            // 
            // partNumber
            // 
            this.partNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.partNumber.Location = new System.Drawing.Point(891, 141);
            this.partNumber.Margin = new System.Windows.Forms.Padding(4);
            this.partNumber.Name = "partNumber";
            this.partNumber.Size = new System.Drawing.Size(193, 34);
            this.partNumber.TabIndex = 47;
            // 
            // partPrice
            // 
            this.partPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.partPrice.Location = new System.Drawing.Point(322, 234);
            this.partPrice.Margin = new System.Windows.Forms.Padding(4);
            this.partPrice.Name = "partPrice";
            this.partPrice.Size = new System.Drawing.Size(193, 34);
            this.partPrice.TabIndex = 48;
            // 
            // partCarModel
            // 
            this.partCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.partCarModel.Location = new System.Drawing.Point(891, 233);
            this.partCarModel.Margin = new System.Windows.Forms.Padding(4);
            this.partCarModel.Name = "partCarModel";
            this.partCarModel.Size = new System.Drawing.Size(193, 34);
            this.partCarModel.TabIndex = 49;
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Centaur", 18F);
            this.reset.Location = new System.Drawing.Point(952, 336);
            this.reset.Margin = new System.Windows.Forms.Padding(4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(132, 41);
            this.reset.TabIndex = 50;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(934, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 22);
            this.label5.TabIndex = 51;
            this.label5.Text = "ABC Car Traders";
            // 
            // Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1375, 875);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.partCarModel);
            this.Controls.Add(this.partPrice);
            this.Controls.Add(this.partNumber);
            this.Controls.Add(this.partName);
            this.Controls.Add(this.partDetails);
            this.Controls.Add(this.partUpdate);
            this.Controls.Add(this.partSave);
            this.Controls.Add(this.partDelete);
            this.Controls.Add(this.dashboard);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Parts";
            this.Text = "Parts";
            this.Load += new System.EventHandler(this.Parts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Button partDelete;
        private System.Windows.Forms.Button partSave;
        private System.Windows.Forms.Button partUpdate;
        private System.Windows.Forms.Button partDetails;
        private System.Windows.Forms.TextBox partName;
        private System.Windows.Forms.TextBox partNumber;
        private System.Windows.Forms.TextBox partPrice;
        private System.Windows.Forms.TextBox partCarModel;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label5;
    }
}