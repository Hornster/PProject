namespace Desktop.Forms.Workspace
{
    partial class FormBuildings
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
            this.dataGridViewBuildings = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonShowResidences = new System.Windows.Forms.Button();
            this.buttonShowRents = new System.Windows.Forms.Button();
            this.buttonShowOverseeing = new System.Windows.Forms.Button();
            this.buttonShowResidents = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuildings)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBuildings
            // 
            this.dataGridViewBuildings.AllowUserToAddRows = false;
            this.dataGridViewBuildings.AllowUserToDeleteRows = false;
            this.dataGridViewBuildings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBuildings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBuildings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuildings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnAddress});
            this.dataGridViewBuildings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewBuildings.Location = new System.Drawing.Point(12, 135);
            this.dataGridViewBuildings.MultiSelect = false;
            this.dataGridViewBuildings.Name = "dataGridViewBuildings";
            this.dataGridViewBuildings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBuildings.Size = new System.Drawing.Size(839, 264);
            this.dataGridViewBuildings.TabIndex = 0;
            // 
            // ColumnID
            // 
            this.ColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnID.DataPropertyName = "Id";
            this.ColumnID.FillWeight = 40.60914F;
            this.ColumnID.HeaderText = "Id";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnID.Width = 40;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAddress.DataPropertyName = "Address";
            this.ColumnAddress.FillWeight = 159.3909F;
            this.ColumnAddress.HeaderText = "Adres";
            this.ColumnAddress.Name = "ColumnAddress";
            // 
            // buttonShowResidences
            // 
            this.buttonShowResidences.Location = new System.Drawing.Point(164, 3);
            this.buttonShowResidences.Name = "buttonShowResidences";
            this.buttonShowResidences.Size = new System.Drawing.Size(118, 23);
            this.buttonShowResidences.TabIndex = 2;
            this.buttonShowResidences.Text = "Pokaż mieszkania";
            this.buttonShowResidences.UseVisualStyleBackColor = true;
            // 
            // buttonShowRents
            // 
            this.buttonShowRents.Location = new System.Drawing.Point(288, 3);
            this.buttonShowRents.Name = "buttonShowRents";
            this.buttonShowRents.Size = new System.Drawing.Size(119, 23);
            this.buttonShowRents.TabIndex = 3;
            this.buttonShowRents.Text = "Pokaż wynajmy";
            this.buttonShowRents.UseVisualStyleBackColor = true;
            // 
            // buttonShowOverseeing
            // 
            this.buttonShowOverseeing.Location = new System.Drawing.Point(3, 32);
            this.buttonShowOverseeing.Name = "buttonShowOverseeing";
            this.buttonShowOverseeing.Size = new System.Drawing.Size(155, 23);
            this.buttonShowOverseeing.TabIndex = 4;
            this.buttonShowOverseeing.Text = "Pokaż historię dozorowań";
            this.buttonShowOverseeing.UseVisualStyleBackColor = true;
            // 
            // buttonShowResidents
            // 
            this.buttonShowResidents.Location = new System.Drawing.Point(164, 32);
            this.buttonShowResidents.Name = "buttonShowResidents";
            this.buttonShowResidents.Size = new System.Drawing.Size(118, 23);
            this.buttonShowResidents.TabIndex = 5;
            this.buttonShowResidents.Text = "Pokaż najemców";
            this.buttonShowResidents.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 405);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(839, 32);
            this.flowLayoutPanel.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 127);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zarządzaj danymi budynku";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonAddEdit);
            this.flowLayoutPanel1.Controls.Add(this.buttonRemove);
            this.flowLayoutPanel1.Controls.Add(this.buttonShowResidences);
            this.flowLayoutPanel1.Controls.Add(this.buttonShowRents);
            this.flowLayoutPanel1.Controls.Add(this.buttonShowOverseeing);
            this.flowLayoutPanel1.Controls.Add(this.buttonShowResidents);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(459, 58);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // buttonAddEdit
            // 
            this.buttonAddEdit.Location = new System.Drawing.Point(3, 3);
            this.buttonAddEdit.Name = "buttonAddEdit";
            this.buttonAddEdit.Size = new System.Drawing.Size(92, 23);
            this.buttonAddEdit.TabIndex = 2;
            this.buttonAddEdit.Text = "Dodaj/Edytuj";
            this.buttonAddEdit.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(101, 3);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(57, 23);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Usuń";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(419, 16);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adres:";
            // 
            // FormBuildings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 444);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.dataGridViewBuildings);
            this.Name = "FormBuildings";
            this.Text = "FormBuildings";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuildings)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBuildings;
        private System.Windows.Forms.Button buttonShowResidences;
        private System.Windows.Forms.Button buttonShowRents;
        private System.Windows.Forms.Button buttonShowOverseeing;
        private System.Windows.Forms.Button buttonShowResidents;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAddEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}