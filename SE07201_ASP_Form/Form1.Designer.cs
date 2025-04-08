namespace SE07201_ASP_Form
{
    partial class frmWaterBill
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lvCustomer = new System.Windows.Forms.ListView();
            this.CustomerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastMonthWater = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThisMonthWater = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Consumption = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalWaterBill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblLastMonthWater = new System.Windows.Forms.Label();
            this.txtLastMonthWater = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblThisMonthWater = new System.Windows.Forms.Label();
            this.txtThisMonthWater = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cboCustomerType = new System.Windows.Forms.ComboBox();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cboNumberOfPeople = new System.Windows.Forms.ComboBox();
            this.lblNUmberOfPeople = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSortByName = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(307, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULATE THE MONTHLY WATER BILL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 26);
            this.textBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 76);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(12, 369);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(142, 40);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lvCustomer
            // 
            this.lvCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CustomerName,
            this.LastMonthWater,
            this.ThisMonthWater,
            this.Consumption,
            this.totalWaterBill});
            this.lvCustomer.FullRowSelect = true;
            this.lvCustomer.GridLines = true;
            this.lvCustomer.HideSelection = false;
            this.lvCustomer.Location = new System.Drawing.Point(12, 424);
            this.lvCustomer.Name = "lvCustomer";
            this.lvCustomer.Size = new System.Drawing.Size(1301, 187);
            this.lvCustomer.TabIndex = 11;
            this.lvCustomer.UseCompatibleStateImageBehavior = false;
            this.lvCustomer.View = System.Windows.Forms.View.Details;
            this.lvCustomer.SelectedIndexChanged += new System.EventHandler(this.lvCustomer_SelectedIndexChanged);
            // 
            // CustomerName
            // 
            this.CustomerName.Text = "Customer Name";
            this.CustomerName.Width = 250;
            // 
            // LastMonthWater
            // 
            this.LastMonthWater.Text = "Last Month Water";
            this.LastMonthWater.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastMonthWater.Width = 250;
            // 
            // ThisMonthWater
            // 
            this.ThisMonthWater.Text = "This Month Water";
            this.ThisMonthWater.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ThisMonthWater.Width = 250;
            // 
            // Consumption
            // 
            this.Consumption.Text = "Consumption";
            this.Consumption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Consumption.Width = 250;
            // 
            // totalWaterBill
            // 
            this.totalWaterBill.Text = "Total Water Bill";
            this.totalWaterBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalWaterBill.Width = 300;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCustomerName);
            this.panel2.Controls.Add(this.txtCustomerName);
            this.panel2.Location = new System.Drawing.Point(12, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 76);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 20);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(118, 19);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name";
            this.lblCustomerName.Click += new System.EventHandler(this.lblCustomerName_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(177, 20);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(268, 26);
            this.txtCustomerName.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblLastMonthWater);
            this.panel3.Controls.Add(this.txtLastMonthWater);
            this.panel3.Location = new System.Drawing.Point(12, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 76);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblLastMonthWater
            // 
            this.lblLastMonthWater.AutoSize = true;
            this.lblLastMonthWater.Location = new System.Drawing.Point(12, 20);
            this.lblLastMonthWater.Name = "lblLastMonthWater";
            this.lblLastMonthWater.Size = new System.Drawing.Size(133, 19);
            this.lblLastMonthWater.TabIndex = 1;
            this.lblLastMonthWater.Text = "Last Month Water";
            this.lblLastMonthWater.Click += new System.EventHandler(this.lblLastMonthWater_Click);
            // 
            // txtLastMonthWater
            // 
            this.txtLastMonthWater.Location = new System.Drawing.Point(177, 20);
            this.txtLastMonthWater.Name = "txtLastMonthWater";
            this.txtLastMonthWater.Size = new System.Drawing.Size(268, 26);
            this.txtLastMonthWater.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblThisMonthWater);
            this.panel4.Controls.Add(this.txtThisMonthWater);
            this.panel4.Location = new System.Drawing.Point(12, 250);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(455, 76);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblThisMonthWater
            // 
            this.lblThisMonthWater.AutoSize = true;
            this.lblThisMonthWater.Location = new System.Drawing.Point(12, 20);
            this.lblThisMonthWater.Name = "lblThisMonthWater";
            this.lblThisMonthWater.Size = new System.Drawing.Size(132, 19);
            this.lblThisMonthWater.TabIndex = 1;
            this.lblThisMonthWater.Text = "This Month Water";
            this.lblThisMonthWater.Click += new System.EventHandler(this.lblThisMonthWater_Click);
            // 
            // txtThisMonthWater
            // 
            this.txtThisMonthWater.Location = new System.Drawing.Point(177, 20);
            this.txtThisMonthWater.Name = "txtThisMonthWater";
            this.txtThisMonthWater.Size = new System.Drawing.Size(268, 26);
            this.txtThisMonthWater.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cboCustomerType);
            this.panel5.Controls.Add(this.lblCustomerType);
            this.panel5.Location = new System.Drawing.Point(499, 86);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 76);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cboCustomerType
            // 
            this.cboCustomerType.FormattingEnabled = true;
            this.cboCustomerType.Items.AddRange(new object[] {
            "1 - Household customer",
            "2 - Adminstrative agency, public service",
            "3 - Production units",
            "4 - Business services"});
            this.cboCustomerType.Location = new System.Drawing.Point(177, 20);
            this.cboCustomerType.Name = "cboCustomerType";
            this.cboCustomerType.Size = new System.Drawing.Size(310, 27);
            this.cboCustomerType.TabIndex = 4;
            this.cboCustomerType.SelectedIndexChanged += new System.EventHandler(this.cboCustomerType_SelectedIndexChanged);
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Location = new System.Drawing.Point(12, 20);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(111, 19);
            this.lblCustomerType.TabIndex = 1;
            this.lblCustomerType.Text = "Customer Type";
            this.lblCustomerType.Click += new System.EventHandler(this.lblCustomerType_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cboNumberOfPeople);
            this.panel6.Controls.Add(this.lblNUmberOfPeople);
            this.panel6.Location = new System.Drawing.Point(499, 168);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(501, 76);
            this.panel6.TabIndex = 5;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cboNumberOfPeople
            // 
            this.cboNumberOfPeople.Enabled = false;
            this.cboNumberOfPeople.FormattingEnabled = true;
            this.cboNumberOfPeople.Location = new System.Drawing.Point(177, 17);
            this.cboNumberOfPeople.Name = "cboNumberOfPeople";
            this.cboNumberOfPeople.Size = new System.Drawing.Size(310, 27);
            this.cboNumberOfPeople.TabIndex = 5;
            this.cboNumberOfPeople.SelectedIndexChanged += new System.EventHandler(this.cboNumerOfPeople_SelectedIndexChanged);
            // 
            // lblNUmberOfPeople
            // 
            this.lblNUmberOfPeople.AutoSize = true;
            this.lblNUmberOfPeople.Location = new System.Drawing.Point(12, 20);
            this.lblNUmberOfPeople.Name = "lblNUmberOfPeople";
            this.lblNUmberOfPeople.Size = new System.Drawing.Size(133, 19);
            this.lblNUmberOfPeople.TabIndex = 1;
            this.lblNUmberOfPeople.Text = "Number Of People";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(200, 369);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(142, 40);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSortByName
            // 
            this.btnSortByName.Location = new System.Drawing.Point(401, 369);
            this.btnSortByName.Name = "btnSortByName";
            this.btnSortByName.Size = new System.Drawing.Size(142, 40);
            this.btnSortByName.TabIndex = 8;
            this.btnSortByName.Text = "Sort By Name";
            this.btnSortByName.UseVisualStyleBackColor = true;
            this.btnSortByName.Click += new System.EventHandler(this.btnSortByName_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(634, 369);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 40);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmWaterBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1383, 727);
            this.Controls.Add(this.lvCustomer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSortByName);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmWaterBill";
            this.Text = "CALCULATE THE MONTHLY WATER BILL";
            this.Load += new System.EventHandler(this.frmWaterBill_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.ListView lvCustomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblLastMonthWater;
        private System.Windows.Forms.TextBox txtLastMonthWater;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblThisMonthWater;
        private System.Windows.Forms.TextBox txtThisMonthWater;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cboCustomerType;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cboNumberOfPeople;
        private System.Windows.Forms.Label lblNUmberOfPeople;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSortByName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColumnHeader CustomerName;
        private System.Windows.Forms.ColumnHeader LastMonthWater;
        private System.Windows.Forms.ColumnHeader ThisMonthWater;
        private System.Windows.Forms.ColumnHeader Consumption;
        private System.Windows.Forms.ColumnHeader totalWaterBill;
    }
}

