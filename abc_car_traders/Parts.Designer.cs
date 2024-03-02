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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Centaur", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(428, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 33);
            this.label7.TabIndex = 39;
            this.label7.Text = "Part Details";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 441);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(910, 238);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.Click += new System.EventHandler(this.selectParts);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Centaur", 18F);
            this.label4.Location = new System.Drawing.Point(251, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 27);
            this.label4.TabIndex = 25;
            this.label4.Text = "Part Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Centaur", 18F);
            this.label3.Location = new System.Drawing.Point(251, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 27);
            this.label3.TabIndex = 24;
            this.label3.Text = "Part Car Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Centaur", 18F);
            this.label2.Location = new System.Drawing.Point(251, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 27);
            this.label2.TabIndex = 28;
            this.label2.Text = "Part Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Centaur", 18F);
            this.label1.Location = new System.Drawing.Point(251, 95);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 27);
            this.label1.TabIndex = 23;
            this.label1.Text = "Part Name";
            // 
            // dashboard
            // 
            this.dashboard.Font = new System.Drawing.Font("Centaur", 18F);
            this.dashboard.Location = new System.Drawing.Point(191, 369);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(160, 33);
            this.dashboard.TabIndex = 41;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // partDelete
            // 
            this.partDelete.Font = new System.Drawing.Font("Centaur", 18F);
            this.partDelete.Location = new System.Drawing.Point(374, 369);
            this.partDelete.Name = "partDelete";
            this.partDelete.Size = new System.Drawing.Size(99, 33);
            this.partDelete.TabIndex = 42;
            this.partDelete.Text = "Delete";
            this.partDelete.UseVisualStyleBackColor = true;
            this.partDelete.Click += new System.EventHandler(this.partDelete_Click);
            // 
            // partSave
            // 
            this.partSave.Font = new System.Drawing.Font("Centaur", 18F);
            this.partSave.Location = new System.Drawing.Point(617, 369);
            this.partSave.Name = "partSave";
            this.partSave.Size = new System.Drawing.Size(75, 33);
            this.partSave.TabIndex = 43;
            this.partSave.Text = "Save";
            this.partSave.UseVisualStyleBackColor = true;
            this.partSave.Click += new System.EventHandler(this.partSave_Click);
            // 
            // partUpdate
            // 
            this.partUpdate.Font = new System.Drawing.Font("Centaur", 18F);
            this.partUpdate.Location = new System.Drawing.Point(493, 369);
            this.partUpdate.Name = "partUpdate";
            this.partUpdate.Size = new System.Drawing.Size(101, 33);
            this.partUpdate.TabIndex = 44;
            this.partUpdate.Text = "Update";
            this.partUpdate.UseVisualStyleBackColor = true;
            this.partUpdate.Click += new System.EventHandler(this.partUpdate_Click);
            // 
            // partDetails
            // 
            this.partDetails.Font = new System.Drawing.Font("Centaur", 18F);
            this.partDetails.Location = new System.Drawing.Point(728, 369);
            this.partDetails.Name = "partDetails";
            this.partDetails.Size = new System.Drawing.Size(99, 33);
            this.partDetails.TabIndex = 45;
            this.partDetails.Text = "Details";
            this.partDetails.UseVisualStyleBackColor = true;
            this.partDetails.Click += new System.EventHandler(this.partDetails_Click);
            // 
            // partName
            // 
            this.partName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.partName.Location = new System.Drawing.Point(591, 95);
            this.partName.Name = "partName";
            this.partName.Size = new System.Drawing.Size(146, 29);
            this.partName.TabIndex = 46;
            // 
            // partNumber
            // 
            this.partNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.partNumber.Location = new System.Drawing.Point(591, 160);
            this.partNumber.Name = "partNumber";
            this.partNumber.Size = new System.Drawing.Size(146, 29);
            this.partNumber.TabIndex = 47;
            // 
            // partPrice
            // 
            this.partPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.partPrice.Location = new System.Drawing.Point(591, 290);
            this.partPrice.Name = "partPrice";
            this.partPrice.Size = new System.Drawing.Size(146, 29);
            this.partPrice.TabIndex = 48;
            // 
            // partCarModel
            // 
            this.partCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.partCarModel.Location = new System.Drawing.Point(591, 227);
            this.partCarModel.Name = "partCarModel";
            this.partCarModel.Size = new System.Drawing.Size(146, 29);
            this.partCarModel.TabIndex = 49;
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Centaur", 18F);
            this.reset.Location = new System.Drawing.Point(849, 369);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(99, 33);
            this.reset.TabIndex = 50;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1031, 711);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}