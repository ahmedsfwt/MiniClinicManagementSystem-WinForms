namespace MiniClinic.UI.Forms
{
    partial class AppointmentForm
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
            lblAppointments = new Label();
            lblDoctor = new Label();
            lblPatient = new Label();
            dgvAppointments = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            PatientName = new DataGridViewTextBoxColumn();
            DoctorName = new DataGridViewTextBoxColumn();
            AppointmentDate = new DataGridViewTextBoxColumn();
            Notes = new DataGridViewTextBoxColumn();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblNotes = new Label();
            txtNotes = new TextBox();
            btnFilter = new Button();
            cboDoctor = new ComboBox();
            cboPatient = new ComboBox();
            lblTime = new Label();
            dtpTime = new DateTimePicker();
            label2 = new Label();
            cboFilterDoctor = new ComboBox();
            cboFilterPatient = new ComboBox();
            lblFilterPatient = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(23, 162, 184);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.FromArgb(60, 60, 60);
            btnDelete.Location = new Point(105, 440);
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
            btnUpdate.Location = new Point(354, 440);
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
            btnAdd.Location = new Point(614, 440);
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
            btnClear.Location = new Point(856, 440);
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
            panel1.Controls.Add(lblAppointments);
            panel1.Location = new Point(-3, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1218, 67);
            panel1.TabIndex = 4;
            // 
            // lblAppointments
            // 
            lblAppointments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAppointments.AutoSize = true;
            lblAppointments.FlatStyle = FlatStyle.Flat;
            lblAppointments.ForeColor = Color.FromArgb(60, 60, 60);
            lblAppointments.Location = new Point(535, 23);
            lblAppointments.Margin = new Padding(4, 0, 4, 0);
            lblAppointments.Name = "lblAppointments";
            lblAppointments.Size = new Size(133, 25);
            lblAppointments.TabIndex = 5;
            lblAppointments.Text = "Appointments";
            // 
            // lblDoctor
            // 
            lblDoctor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDoctor.AutoSize = true;
            lblDoctor.BackColor = Color.FromArgb(23, 162, 184);
            lblDoctor.FlatStyle = FlatStyle.Flat;
            lblDoctor.ForeColor = Color.FromArgb(60, 60, 60);
            lblDoctor.Location = new Point(955, 119);
            lblDoctor.Margin = new Padding(4, 0, 4, 0);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(70, 25);
            lblDoctor.TabIndex = 7;
            lblDoctor.Text = "Doctor";
            // 
            // lblPatient
            // 
            lblPatient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPatient.AutoSize = true;
            lblPatient.BackColor = Color.FromArgb(23, 162, 184);
            lblPatient.FlatStyle = FlatStyle.Flat;
            lblPatient.ForeColor = Color.FromArgb(60, 60, 60);
            lblPatient.Location = new Point(544, 119);
            lblPatient.Margin = new Padding(4, 0, 4, 0);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(73, 25);
            lblPatient.TabIndex = 8;
            lblPatient.Text = "Patient";
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAppointments.BackgroundColor = SystemColors.ControlDarkDark;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Columns.AddRange(new DataGridViewColumn[] { Id, PatientName, DoctorName, AppointmentDate, Notes });
            dgvAppointments.Location = new Point(-3, 539);
            dgvAppointments.MultiSelect = false;
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(1218, 394);
            dgvAppointments.TabIndex = 9;
            dgvAppointments.CellClick += dgvAppointments_CellContentClick;
            dgvAppointments.CellContentClick += dgvAppointments_CellContentClick;
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
            // PatientName
            // 
            PatientName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PatientName.DataPropertyName = "PatientName";
            PatientName.HeaderText = "Patient";
            PatientName.MinimumWidth = 6;
            PatientName.Name = "PatientName";
            PatientName.ReadOnly = true;
            // 
            // DoctorName
            // 
            DoctorName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DoctorName.DataPropertyName = "DoctorName";
            DoctorName.HeaderText = "Doctor";
            DoctorName.MinimumWidth = 6;
            DoctorName.Name = "DoctorName";
            DoctorName.ReadOnly = true;
            // 
            // AppointmentDate
            // 
            AppointmentDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            AppointmentDate.DataPropertyName = "AppointmentDate";
            AppointmentDate.HeaderText = "Appointment Date";
            AppointmentDate.MinimumWidth = 6;
            AppointmentDate.Name = "AppointmentDate";
            AppointmentDate.ReadOnly = true;
            // 
            // Notes
            // 
            Notes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Notes.DataPropertyName = "Notes";
            Notes.HeaderText = "Notes";
            Notes.MinimumWidth = 6;
            Notes.Name = "Notes";
            Notes.ReadOnly = true;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.FromArgb(23, 162, 184);
            lblDate.FlatStyle = FlatStyle.Flat;
            lblDate.ForeColor = Color.FromArgb(60, 60, 60);
            lblDate.Location = new Point(220, 119);
            lblDate.Margin = new Padding(4, 0, 4, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(52, 25);
            lblDate.TabIndex = 10;
            lblDate.Text = "Date";
            // 
            // dtpDate
            // 
            dtpDate.CalendarMonthBackground = SystemColors.WindowFrame;
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(101, 147);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(180, 31);
            dtpDate.TabIndex = 11;
            // 
            // lblNotes
            // 
            lblNotes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblNotes.AutoSize = true;
            lblNotes.BackColor = Color.FromArgb(23, 162, 184);
            lblNotes.FlatStyle = FlatStyle.Flat;
            lblNotes.ForeColor = Color.FromArgb(60, 60, 60);
            lblNotes.Location = new Point(963, 211);
            lblNotes.Margin = new Padding(4, 0, 4, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(62, 25);
            lblNotes.TabIndex = 12;
            lblNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            txtNotes.BackColor = SystemColors.ControlLight;
            txtNotes.Location = new Point(402, 244);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(634, 31);
            txtNotes.TabIndex = 13;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(23, 162, 184);
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.ForeColor = Color.FromArgb(60, 60, 60);
            btnFilter.Location = new Point(101, 342);
            btnFilter.Margin = new Padding(4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(180, 36);
            btnFilter.TabIndex = 14;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // cboDoctor
            // 
            cboDoctor.BackColor = Color.Gray;
            cboDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDoctor.FormattingEnabled = true;
            cboDoctor.Location = new Point(813, 149);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.Size = new Size(223, 33);
            cboDoctor.TabIndex = 15;
            // 
            // cboPatient
            // 
            cboPatient.BackColor = Color.Gray;
            cboPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPatient.FormattingEnabled = true;
            cboPatient.Location = new Point(402, 149);
            cboPatient.Name = "cboPatient";
            cboPatient.Size = new Size(223, 33);
            cboPatient.TabIndex = 16;
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.FromArgb(23, 162, 184);
            lblTime.FlatStyle = FlatStyle.Flat;
            lblTime.ForeColor = Color.FromArgb(60, 60, 60);
            lblTime.Location = new Point(218, 211);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(54, 25);
            lblTime.TabIndex = 17;
            lblTime.Text = "Time";
            // 
            // dtpTime
            // 
            dtpTime.CalendarMonthBackground = SystemColors.WindowFrame;
            dtpTime.Format = DateTimePickerFormat.Time;
            dtpTime.Location = new Point(101, 239);
            dtpTime.Name = "dtpTime";
            dtpTime.Size = new Size(180, 31);
            dtpTime.TabIndex = 18;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(23, 162, 184);
            label2.FlatStyle = FlatStyle.Flat;
            label2.ForeColor = Color.FromArgb(60, 60, 60);
            label2.Location = new Point(872, 307);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 19;
            label2.Text = "Filter by Doctor";
            // 
            // cboFilterDoctor
            // 
            cboFilterDoctor.BackColor = Color.Gray;
            cboFilterDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterDoctor.FormattingEnabled = true;
            cboFilterDoctor.Location = new Point(813, 345);
            cboFilterDoctor.Name = "cboFilterDoctor";
            cboFilterDoctor.Size = new Size(223, 33);
            cboFilterDoctor.TabIndex = 20;
            // 
            // cboFilterPatient
            // 
            cboFilterPatient.BackColor = Color.Gray;
            cboFilterPatient.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterPatient.FormattingEnabled = true;
            cboFilterPatient.Location = new Point(402, 342);
            cboFilterPatient.Name = "cboFilterPatient";
            cboFilterPatient.Size = new Size(223, 33);
            cboFilterPatient.TabIndex = 22;
            // 
            // lblFilterPatient
            // 
            lblFilterPatient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblFilterPatient.AutoSize = true;
            lblFilterPatient.BackColor = Color.FromArgb(23, 162, 184);
            lblFilterPatient.FlatStyle = FlatStyle.Flat;
            lblFilterPatient.ForeColor = Color.FromArgb(60, 60, 60);
            lblFilterPatient.Location = new Point(461, 307);
            lblFilterPatient.Margin = new Padding(4, 0, 4, 0);
            lblFilterPatient.Name = "lblFilterPatient";
            lblFilterPatient.Size = new Size(147, 25);
            lblFilterPatient.TabIndex = 21;
            lblFilterPatient.Text = "Filter by Patient";
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(1213, 954);
            Controls.Add(cboFilterPatient);
            Controls.Add(lblFilterPatient);
            Controls.Add(cboFilterDoctor);
            Controls.Add(label2);
            Controls.Add(dtpTime);
            Controls.Add(lblTime);
            Controls.Add(cboPatient);
            Controls.Add(cboDoctor);
            Controls.Add(btnFilter);
            Controls.Add(txtNotes);
            Controls.Add(lblNotes);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(dgvAppointments);
            Controls.Add(lblPatient);
            Controls.Add(lblDoctor);
            Controls.Add(panel1);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Font = new Font("Leelawadee UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "AppointmentForm";
            Text = "Mini Clinic Management System";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnClear;
        private Panel panel1;
        private Label lblAppointments;
        private TextBox txtPhone;
        private Label lblDoctor;
        private Label lblPatient;
        private DataGridView dgvAppointments;
        private Label lblDate;
        private DateTimePicker dtpDate;
        private Label lblNotes;
        private TextBox txtNotes;
        private Button btnFilter;
        private ComboBox cboDoctor;
        private ComboBox cboPatient;
        private Label lblTime;
        private DateTimePicker dtpTime;
        private Label label2;
        private ComboBox cboFilterDoctor;
        private ComboBox cboFilterPatient;
        private Label lblFilterPatient;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn PatientName;
        private DataGridViewTextBoxColumn DoctorName;
        private DataGridViewTextBoxColumn AppointmentDate;
        private DataGridViewTextBoxColumn Notes;
    }
}