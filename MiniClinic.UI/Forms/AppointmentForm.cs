using MiniClinic.BLL.Services;
using MiniClinic.Domain.Entities;
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
    public partial class AppointmentForm : Form
    {
        private readonly AppointmentService _appointmentService;
        private readonly DoctorService _doctorService;
        private readonly PatientService _patientService;
        private int _selectedAppointmentId = 0;
        private List<Appointment> _currentAppointments = new List<Appointment>();

        public AppointmentForm()
        {
            InitializeComponent();
            _patientService = new();
            _doctorService = new();
            _appointmentService = new();
            LoadAppointments();
            LoadDoctorComboBoxes();
            LoadPatientComboBoxes();
        }

        private void LoadDoctorComboBoxes()
        {
            var doctors = _doctorService.GetAllDoctors();

            cboDoctor.DataSource = doctors;
            cboDoctor.DisplayMember = "Name";
            cboDoctor.ValueMember = "Id";

            var filterDoctors = _doctorService.GetAllDoctors();
            filterDoctors.Insert(0, new Doctor { Id = 0, Name = "All Doctors" });

            cboFilterDoctor.DataSource = filterDoctors;
            cboFilterDoctor.DisplayMember = "Name";
            cboFilterDoctor.ValueMember = "Id";
        }
        private void LoadPatientComboBoxes()
        {
            var patients = _patientService.GetPatients();

            cboPatient.DataSource = patients;
            cboPatient.DisplayMember = "Name";
            cboPatient.ValueMember = "Id";

            var filterPatients = _patientService.GetPatients();
            filterPatients.Insert(0, new Patient { Id = 0, Name = "All Patients" });

            cboFilterPatient.DataSource = filterPatients;
            cboFilterPatient.DisplayMember = "Name";
            cboFilterPatient.ValueMember = "Id";
        }
        private void LoadAppointments()
        {
            dgvAppointments.AutoGenerateColumns = false;
            var appointments = _appointmentService.GetAllAppointments();
            var displayList = appointments.Select(a => new
            {
                Id = a.Id,
                DoctorName = a.Doctor.Name,
                PatientName = a.Patient.Name,
                AppointmentDate = a.AppointmentDate,
                Notes = a.Notes
            }).ToList();

            
            dgvAppointments.DataSource = displayList;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {            
            try
            {
                if (cboDoctor.SelectedValue == null || cboPatient.SelectedValue == null)
                {
                    MessageBox.Show("Please select a Doctor and a Patient.");
                    return;
                }
                DateTime appointmentDateTime = dtpDate.Value.Date + dtpTime.Value.TimeOfDay;

                if (appointmentDateTime <= DateTime.Now)
                {
                    MessageBox.Show("Please select a Date Time in Future.");
                    return;
                }

                var appointment = new Appointment
                {
                    DoctorId = (int)cboDoctor.SelectedValue,
                    PatientId = (int)cboPatient.SelectedValue,
                    AppointmentDate = appointmentDateTime,
                    Notes = txtNotes.Text
                };

                _appointmentService.AddAppointment(appointment);

                LoadAppointments();
                ClearInputs();

                MessageBox.Show("Appointment added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAppointments.CurrentRow == null)
            {
                return;
            }
                        
            var idValue = dgvAppointments.CurrentRow.Cells["Id"].Value;

            if (idValue == null)
            {
                return;
            }

            int appointmentId = (int)idValue;
                        
            var selectedAppointment = _appointmentService.GetAppointmentById(appointmentId);

            if (selectedAppointment == null)
            {
                return;
            }

            _selectedAppointmentId = selectedAppointment.Id;
            cboDoctor.SelectedValue = selectedAppointment.DoctorId;
            cboPatient.SelectedValue = selectedAppointment.PatientId;
            dtpDate.Value = selectedAppointment.AppointmentDate.Date;
            dtpTime.Value = selectedAppointment.AppointmentDate;
            txtNotes.Text = selectedAppointment.Notes;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            if (_selectedAppointmentId == 0)
            {
                MessageBox.Show("Please select an appointment from the list first.");
                return;
            }

            var confirmResult = MessageBox.Show(
                "Are you sure you want to delete this appointment?",
                "Confirm Delete",
                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                _appointmentService.DeleteAppointment(_selectedAppointmentId);

                LoadAppointments();
                ClearInputs();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {            
            try
            {
                if (_selectedAppointmentId == 0)
                {
                    MessageBox.Show("Please select an appointment from the list first.");
                    return;
                }

                if (cboDoctor.SelectedValue == null || cboPatient.SelectedValue == null)
                {
                    MessageBox.Show("Please select a Doctor and a Patient.");
                    return;
                }
                DateTime appointmentDateTime = dtpDate.Value.Date + dtpTime.Value.TimeOfDay;

                var appointment = new Appointment
                {
                    Id = _selectedAppointmentId,
                    DoctorId = (int)cboDoctor.SelectedValue,
                    PatientId = (int)cboPatient.SelectedValue,
                    AppointmentDate = appointmentDateTime,
                    Notes = txtNotes.Text
                };

                _appointmentService.UpdateAppointment(appointment);
                LoadAppointments();
                ClearInputs();

                MessageBox.Show("Appointment updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            _selectedAppointmentId = 0;
            txtNotes.Clear();
            dtpDate.Value = DateTime.Now;
            dtpTime.Value = DateTime.Now;

            if (cboDoctor.Items.Count > 0)
            {
                cboDoctor.SelectedIndex = 0;
            }

            if (cboPatient.Items.Count > 0)
            {
                cboPatient.SelectedIndex = 0;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            int filterDoctorId = cboFilterDoctor.SelectedValue != null ? (int)cboFilterDoctor.SelectedValue : 0;
            int filterPatientId = cboFilterPatient.SelectedValue != null ? (int)cboFilterPatient.SelectedValue : 0;

            var allAppointments = _appointmentService.GetAllAppointments();

            var filtered = allAppointments.Where(a =>
                (filterDoctorId == 0 || a.DoctorId == filterDoctorId) &&
                (filterPatientId == 0 || a.PatientId == filterPatientId))
                .ToList();

            var displayList = filtered.Select(a => new
            {
                Id = a.Id,
                DoctorName = a.Doctor.Name,
                PatientName = a.Patient.Name,
                AppointmentDate = a.AppointmentDate,
                Notes = a.Notes
            }).ToList();

            dgvAppointments.DataSource = null;
            dgvAppointments.DataSource = displayList;
        }

        
    }
}
