namespace MiniClinic.UI.Forms
{
    partial class DoctorForm
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
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnClear = new Button();
            panel1 = new Panel();
            label1 = new Label();
            txtName = new TextBox();
            txtSpecialty = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dgvDoctors = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Specialty = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(23, 162, 184);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.FromArgb(60, 60, 60);
            btnDelete.Location = new Point(105, 315);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(176, 36);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(23, 162, 184);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.ForeColor = Color.FromArgb(60, 60, 60);
            btnUpdate.Location = new Point(392, 315);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(175, 36);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(23, 162, 184);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.FromArgb(60, 60, 60);
            btnAdd.Location = new Point(653, 315);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(172, 36);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(23, 162, 184);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.FromArgb(60, 60, 60);
            btnClear.Location = new Point(910, 315);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(180, 36);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 162, 184);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1218, 67);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.ForeColor = Color.FromArgb(60, 60, 60);
            label1.Location = new Point(535, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 5;
            label1.Text = "Doctors";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.WindowFrame;
            txtName.Location = new Point(809, 147);
            txtName.Name = "txtName";
            txtName.Size = new Size(218, 31);
            txtName.TabIndex = 5;
            // 
            // txtSpecialty
            // 
            txtSpecialty.BackColor = SystemColors.WindowFrame;
            txtSpecialty.Location = new Point(409, 147);
            txtSpecialty.Name = "txtSpecialty";
            txtSpecialty.Size = new Size(212, 31);
            txtSpecialty.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(23, 162, 184);
            label2.FlatStyle = FlatStyle.Flat;
            label2.ForeColor = Color.FromArgb(60, 60, 60);
            label2.Location = new Point(955, 119);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(23, 162, 184);
            label3.FlatStyle = FlatStyle.Flat;
            label3.ForeColor = Color.FromArgb(60, 60, 60);
            label3.Location = new Point(521, 119);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 8;
            label3.Text = "Specialty";
            // 
            // dgvDoctors
            // 
            dgvDoctors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDoctors.BackgroundColor = SystemColors.ControlDarkDark;
            dgvDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctors.Columns.AddRange(new DataGridViewColumn[] { Id, Name, Specialty });
            dgvDoctors.Location = new Point(-3, 406);
            dgvDoctors.MultiSelect = false;
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.ReadOnly = true;
            dgvDoctors.RowHeadersWidth = 51;
            dgvDoctors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoctors.Size = new Size(1218, 527);
            dgvDoctors.TabIndex = 9;
            dgvDoctors.CellContentClick += dgvDoctors_CellContentClick;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Name.DataPropertyName = "Name";
            Name.HeaderText = "Name";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // Specialty
            // 
            Specialty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Specialty.DataPropertyName = "Specialty";
            Specialty.HeaderText = "Specialty";
            Specialty.MinimumWidth = 6;
            Specialty.Name = "Specialty";
            Specialty.ReadOnly = true;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(1213, 954);
            Controls.Add(dgvDoctors);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSpecialty);
            Controls.Add(txtName);
            Controls.Add(panel1);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Font = new Font("Leelawadee UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            //Name = "DoctorForm";
            Text = "Mini Clinic Management System";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnClear;
        private Panel panel1;
        private Label label1;
        private TextBox txtName;
        private TextBox txtSpecialty;
        private Label label2;
        private Label label3;
        private DataGridView dgvDoctors;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Specialty;
    }
}