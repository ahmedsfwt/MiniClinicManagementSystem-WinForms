using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniClinic.UI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            
            DoctorForm doctorForm = new();
            doctorForm.ShowDialog();

        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new();
            patientForm.ShowDialog();
            
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            AppointmentForm appointmentForm = new();
            appointmentForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
