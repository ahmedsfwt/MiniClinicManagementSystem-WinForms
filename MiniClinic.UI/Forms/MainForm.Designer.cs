namespace MiniClinic.UI.Forms
{
    partial class MainForm
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
            btnDoctors = new Button();
            btnPatients = new Button();
            btnAppointments = new Button();
            btnExit = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDoctors
            // 
            btnDoctors.BackColor = Color.FromArgb(23, 162, 184);
            btnDoctors.FlatStyle = FlatStyle.Flat;
            btnDoctors.ForeColor = Color.FromArgb(60, 60, 60);
            btnDoctors.Location = new Point(113, 511);
            btnDoctors.Margin = new Padding(4);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Size = new Size(176, 36);
            btnDoctors.TabIndex = 0;
            btnDoctors.Text = "Doctors";
            btnDoctors.UseVisualStyleBackColor = false;
            btnDoctors.Click += btnDoctors_Click;
            // 
            // btnPatients
            // 
            btnPatients.BackColor = Color.FromArgb(23, 162, 184);
            btnPatients.FlatStyle = FlatStyle.Flat;
            btnPatients.ForeColor = Color.FromArgb(60, 60, 60);
            btnPatients.Location = new Point(397, 511);
            btnPatients.Margin = new Padding(4);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(175, 36);
            btnPatients.TabIndex = 1;
            btnPatients.Text = "Patients";
            btnPatients.UseVisualStyleBackColor = false;
            btnPatients.Click += btnPatients_Click;
            // 
            // btnAppointments
            // 
            btnAppointments.BackColor = Color.FromArgb(23, 162, 184);
            btnAppointments.FlatStyle = FlatStyle.Flat;
            btnAppointments.ForeColor = Color.FromArgb(60, 60, 60);
            btnAppointments.Location = new Point(666, 511);
            btnAppointments.Margin = new Padding(4);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(172, 36);
            btnAppointments.TabIndex = 2;
            btnAppointments.Text = "Appointments";
            btnAppointments.UseVisualStyleBackColor = false;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(23, 162, 184);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.FromArgb(60, 60, 60);
            btnExit.Location = new Point(927, 511);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(180, 36);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
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
            label1.Location = new Point(458, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(217, 25);
            label1.TabIndex = 5;
            label1.Text = "Clinic Management Hub";
            label1.Click += label1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(1213, 954);
            Controls.Add(panel1);
            Controls.Add(btnExit);
            Controls.Add(btnAppointments);
            Controls.Add(btnPatients);
            Controls.Add(btnDoctors);
            Font = new Font("Leelawadee UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Mini Clinic Management System";
            Load += MainForm_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDoctors;
        private Button btnPatients;
        private Button btnAppointments;
        private Button btnExit;
        private Panel panel1;
        private Label label1;
    }
}