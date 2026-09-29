namespace MiniClinic.UI.Forms
{
    partial class PatientForm
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
            txtPhone = new TextBox();
            lblName = new Label();
            lblPhone = new Label();
            dgvPatients = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            DateOfBirth = new DataGridViewTextBoxColumn();
            lblDateOfBirth = new Label();
            dtpDateOfBirth = new DateTimePicker();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
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
            label1.Size = new Size(81, 25);
            label1.TabIndex = 5;
            label1.Text = "Patients";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.WindowFrame;
            txtName.Location = new Point(809, 147);
            txtName.Name = "txtName";
            txtName.Size = new Size(218, 31);
            txtName.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.WindowFrame;
            txtPhone.Location = new Point(409, 147);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(212, 31);
            txtPhone.TabIndex = 6;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.BackColor = Color.FromArgb(23, 162, 184);
            lblName.FlatStyle = FlatStyle.Flat;
            lblName.ForeColor = Color.FromArgb(60, 60, 60);
            lblName.Location = new Point(955, 119);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(62, 25);
            lblName.TabIndex = 7;
            lblName.Text = "Name";
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPhone.AutoSize = true;
            lblPhone.BackColor = Color.FromArgb(23, 162, 184);
            lblPhone.FlatStyle = FlatStyle.Flat;
            lblPhone.ForeColor = Color.FromArgb(60, 60, 60);
            lblPhone.Location = new Point(544, 119);
            lblPhone.Margin = new Padding(4, 0, 4, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(66, 25);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Phone";
            // 
            // dgvPatients
            // 
            dgvPatients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPatients.BackgroundColor = SystemColors.ControlDarkDark;
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Columns.AddRange(new DataGridViewColumn[] { Id, Name, Phone, DateOfBirth });
            dgvPatients.Location = new Point(-3, 406);
            dgvPatients.MultiSelect = false;
            dgvPatients.Name = "dgvPatients";
            dgvPatients.ReadOnly = true;
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.Size = new Size(1218, 527);
            dgvPatients.TabIndex = 9;
            dgvPatients.CellContentClick += dgvPatients_CellContentClick;
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
            // Phone
            // 
            Phone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "Phone";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            // 
            // DateOfBirth
            // 
            DateOfBirth.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DateOfBirth.DataPropertyName = "DateOfBirth";
            DateOfBirth.HeaderText = "Date Of Birth";
            DateOfBirth.MinimumWidth = 6;
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.ReadOnly = true;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.BackColor = Color.FromArgb(23, 162, 184);
            lblDateOfBirth.FlatStyle = FlatStyle.Flat;
            lblDateOfBirth.ForeColor = Color.FromArgb(60, 60, 60);
            lblDateOfBirth.Location = new Point(142, 119);
            lblDateOfBirth.Margin = new Padding(4, 0, 4, 0);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(125, 25);
            lblDateOfBirth.TabIndex = 10;
            lblDateOfBirth.Text = "Date Of Birth";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CalendarMonthBackground = SystemColors.WindowFrame;
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(31, 147);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(250, 31);
            dtpDateOfBirth.TabIndex = 11;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.FromArgb(23, 162, 184);
            lblSearch.FlatStyle = FlatStyle.Flat;
            lblSearch.ForeColor = Color.FromArgb(60, 60, 60);
            lblSearch.Location = new Point(653, 213);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(151, 25);
            lblSearch.TabIndex = 12;
            lblSearch.Text = "Search By Name";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.WindowFrame;
            txtSearch.Location = new Point(574, 241);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(251, 31);
            txtSearch.TabIndex = 13;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(23, 162, 184);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.FromArgb(60, 60, 60);
            btnSearch.Location = new Point(387, 239);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(180, 36);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(1213, 954);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(lblDateOfBirth);
            Controls.Add(dgvPatients);
            Controls.Add(lblPhone);
            Controls.Add(lblName);
            Controls.Add(txtPhone);
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
            //Name = "PatientForm";
            Text = "Mini Clinic Management System";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
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
        private TextBox txtPhone;
        private Label lblName;
        private Label lblPhone;
        private DataGridView dgvPatients;
        private Label lblDateOfBirth;
        private DateTimePicker dtpDateOfBirth;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn DateOfBirth;
    }
}