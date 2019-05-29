namespace Desktop.Forms.Workspace
{
    partial class FormMain
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
            this.buttonUserData = new System.Windows.Forms.Button();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.buttonShowResidences = new System.Windows.Forms.Button();
            this.buttonShowBuildings = new System.Windows.Forms.Button();
            this.buttonShowResidents = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonShowRents = new System.Windows.Forms.Button();
            this.buttonShowRentInvoices = new System.Windows.Forms.Button();
            this.buttonShowRentPayments = new System.Windows.Forms.Button();
            this.buttonShowOverseeings = new System.Windows.Forms.Button();
            this.buttonShowUsers = new System.Windows.Forms.Button();
            this.buttonShowCompanies = new System.Windows.Forms.Button();
            this.buttonShowFaults = new System.Windows.Forms.Button();
            this.buttonShowFaultRepairs = new System.Windows.Forms.Button();
            this.buttonShowRepairInvoices = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUserData
            // 
            this.buttonUserData.Location = new System.Drawing.Point(78, 39);
            this.buttonUserData.Name = "buttonUserData";
            this.buttonUserData.Size = new System.Drawing.Size(75, 23);
            this.buttonUserData.TabIndex = 1;
            this.buttonUserData.Text = "Moje dane";
            this.buttonUserData.UseVisualStyleBackColor = true;
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.Location = new System.Drawing.Point(159, 39);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(75, 23);
            this.buttonSignOut.TabIndex = 0;
            this.buttonSignOut.Text = "Wyloguj";
            this.buttonSignOut.UseVisualStyleBackColor = true;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // buttonShowResidences
            // 
            this.buttonShowResidences.Location = new System.Drawing.Point(75, 0);
            this.buttonShowResidences.Margin = new System.Windows.Forms.Padding(0);
            this.buttonShowResidences.Name = "buttonShowResidences";
            this.buttonShowResidences.Size = new System.Drawing.Size(75, 23);
            this.buttonShowResidences.TabIndex = 3;
            this.buttonShowResidences.Text = "Mieszkania";
            this.buttonShowResidences.UseVisualStyleBackColor = true;
            // 
            // buttonShowBuildings
            // 
            this.buttonShowBuildings.Location = new System.Drawing.Point(0, 0);
            this.buttonShowBuildings.Margin = new System.Windows.Forms.Padding(0);
            this.buttonShowBuildings.Name = "buttonShowBuildings";
            this.buttonShowBuildings.Size = new System.Drawing.Size(75, 23);
            this.buttonShowBuildings.TabIndex = 2;
            this.buttonShowBuildings.Text = "Budynki";
            this.buttonShowBuildings.UseVisualStyleBackColor = true;
            this.buttonShowBuildings.Click += new System.EventHandler(this.buttonShowBuildings_Click);
            // 
            // buttonShowResidents
            // 
            this.buttonShowResidents.Location = new System.Drawing.Point(150, 0);
            this.buttonShowResidents.Margin = new System.Windows.Forms.Padding(0);
            this.buttonShowResidents.Name = "buttonShowResidents";
            this.buttonShowResidents.Size = new System.Drawing.Size(75, 23);
            this.buttonShowResidents.TabIndex = 4;
            this.buttonShowResidents.Text = "Najemcy";
            this.buttonShowResidents.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonShowBuildings);
            this.flowLayoutPanel1.Controls.Add(this.buttonShowResidences);
            this.flowLayoutPanel1.Controls.Add(this.buttonShowResidents);
            this.flowLayoutPanel1.Controls.Add(this.buttonShowRents);
            this.flowLayoutPanel1.Controls.Add(this.buttonShowRentInvoices);
            this.flowLayoutPanel1.Controls.Add(this.buttonShowOverseeings);
            this.flowLayoutPanel1.Controls.Add(this.buttonShowRentPayments);
            this.flowLayoutPanel1.Controls.Add(this.buttonShowUsers);
            this.flowLayoutPanel1.Controls.Add(this.buttonShowCompanies);
            this.flowLayoutPanel1.Controls.Add(this.buttonShowFaults);
            this.flowLayoutPanel1.Controls.Add(this.buttonShowFaultRepairs);
            this.flowLayoutPanel1.Controls.Add(this.buttonShowRepairInvoices);
            this.flowLayoutPanel1.Controls.Add(this.buttonUserData);
            this.flowLayoutPanel1.Controls.Add(this.buttonSignOut);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 362);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(859, 100);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // buttonShowRents
            // 
            this.buttonShowRents.Location = new System.Drawing.Point(225, 0);
            this.buttonShowRents.Margin = new System.Windows.Forms.Padding(0);
            this.buttonShowRents.Name = "buttonShowRents";
            this.buttonShowRents.Size = new System.Drawing.Size(75, 23);
            this.buttonShowRents.TabIndex = 5;
            this.buttonShowRents.Text = "Wynajmy";
            this.buttonShowRents.UseVisualStyleBackColor = true;
            // 
            // buttonShowRentInvoices
            // 
            this.buttonShowRentInvoices.Location = new System.Drawing.Point(300, 0);
            this.buttonShowRentInvoices.Margin = new System.Windows.Forms.Padding(0);
            this.buttonShowRentInvoices.Name = "buttonShowRentInvoices";
            this.buttonShowRentInvoices.Size = new System.Drawing.Size(75, 36);
            this.buttonShowRentInvoices.TabIndex = 6;
            this.buttonShowRentInvoices.Text = "Faktury wynajmów";
            this.buttonShowRentInvoices.UseVisualStyleBackColor = true;
            // 
            // buttonShowRentPayments
            // 
            this.buttonShowRentPayments.Location = new System.Drawing.Point(450, 0);
            this.buttonShowRentPayments.Margin = new System.Windows.Forms.Padding(0);
            this.buttonShowRentPayments.Name = "buttonShowRentPayments";
            this.buttonShowRentPayments.Size = new System.Drawing.Size(75, 23);
            this.buttonShowRentPayments.TabIndex = 7;
            this.buttonShowRentPayments.Text = "Płatności";
            this.buttonShowRentPayments.UseVisualStyleBackColor = true;
            // 
            // buttonShowOverseeings
            // 
            this.buttonShowOverseeings.Location = new System.Drawing.Point(375, 0);
            this.buttonShowOverseeings.Margin = new System.Windows.Forms.Padding(0);
            this.buttonShowOverseeings.Name = "buttonShowOverseeings";
            this.buttonShowOverseeings.Size = new System.Drawing.Size(75, 23);
            this.buttonShowOverseeings.TabIndex = 8;
            this.buttonShowOverseeings.Text = "Dozorowania";
            this.buttonShowOverseeings.UseVisualStyleBackColor = true;
            // 
            // buttonShowUsers
            // 
            this.buttonShowUsers.Location = new System.Drawing.Point(525, 0);
            this.buttonShowUsers.Margin = new System.Windows.Forms.Padding(0);
            this.buttonShowUsers.Name = "buttonShowUsers";
            this.buttonShowUsers.Size = new System.Drawing.Size(75, 23);
            this.buttonShowUsers.TabIndex = 9;
            this.buttonShowUsers.Text = "Użytkownicy";
            this.buttonShowUsers.UseVisualStyleBackColor = true;
            // 
            // buttonShowCompanies
            // 
            this.buttonShowCompanies.Location = new System.Drawing.Point(600, 0);
            this.buttonShowCompanies.Margin = new System.Windows.Forms.Padding(0);
            this.buttonShowCompanies.Name = "buttonShowCompanies";
            this.buttonShowCompanies.Size = new System.Drawing.Size(75, 23);
            this.buttonShowCompanies.TabIndex = 10;
            this.buttonShowCompanies.Text = "Firmy";
            this.buttonShowCompanies.UseVisualStyleBackColor = true;
            // 
            // buttonShowFaults
            // 
            this.buttonShowFaults.Location = new System.Drawing.Point(675, 0);
            this.buttonShowFaults.Margin = new System.Windows.Forms.Padding(0);
            this.buttonShowFaults.Name = "buttonShowFaults";
            this.buttonShowFaults.Size = new System.Drawing.Size(75, 23);
            this.buttonShowFaults.TabIndex = 11;
            this.buttonShowFaults.Text = "Usterki";
            this.buttonShowFaults.UseVisualStyleBackColor = true;
            // 
            // buttonShowFaultRepairs
            // 
            this.buttonShowFaultRepairs.Location = new System.Drawing.Point(750, 0);
            this.buttonShowFaultRepairs.Margin = new System.Windows.Forms.Padding(0);
            this.buttonShowFaultRepairs.Name = "buttonShowFaultRepairs";
            this.buttonShowFaultRepairs.Size = new System.Drawing.Size(75, 23);
            this.buttonShowFaultRepairs.TabIndex = 12;
            this.buttonShowFaultRepairs.Text = "Naprawy";
            this.buttonShowFaultRepairs.UseVisualStyleBackColor = true;
            // 
            // buttonShowRepairInvoices
            // 
            this.buttonShowRepairInvoices.Location = new System.Drawing.Point(0, 36);
            this.buttonShowRepairInvoices.Margin = new System.Windows.Forms.Padding(0);
            this.buttonShowRepairInvoices.Name = "buttonShowRepairInvoices";
            this.buttonShowRepairInvoices.Size = new System.Drawing.Size(75, 40);
            this.buttonShowRepairInvoices.TabIndex = 13;
            this.buttonShowRepairInvoices.Text = "Faktury napraw";
            this.buttonShowRepairInvoices.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 335);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(879, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Budynki";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(532, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(532, 309);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 498);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUserData;
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.Button buttonShowResidences;
        private System.Windows.Forms.Button buttonShowBuildings;
        private System.Windows.Forms.Button buttonShowResidents;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonShowRents;
        private System.Windows.Forms.Button buttonShowRentInvoices;
        private System.Windows.Forms.Button buttonShowRentPayments;
        private System.Windows.Forms.Button buttonShowOverseeings;
        private System.Windows.Forms.Button buttonShowUsers;
        private System.Windows.Forms.Button buttonShowCompanies;
        private System.Windows.Forms.Button buttonShowFaults;
        private System.Windows.Forms.Button buttonShowFaultRepairs;
        private System.Windows.Forms.Button buttonShowRepairInvoices;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}