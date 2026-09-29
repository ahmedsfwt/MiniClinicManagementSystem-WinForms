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
    public partial class PatientForm : Form
    {
        private readonly PatientService _patientService;
        private int _selectedPatientId = 0;

        public PatientForm()
        {
            InitializeComponent();
            _patientService = new();
            LoadPatients();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }
        private void LoadPatients()
        {
            var patients = _patientService.GetPatients();
            dgvPatients.AutoGenerateColumns = false;
            dgvPatients.DataSource = patients;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    MessageBox.Show("Please enter both Name and Phone.");
                    return;
                }
                var patient = new Patient
                {
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    DateOfBirth = dtpDateOfBirth.Value
                };
                _patientService.AddPatient(patient);
                ClearInputs();
                LoadPatients();
                MessageBox.Show("Patient added successfully.");
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedPatient = dgvPatients.CurrentRow.DataBoundItem as Patient;

            if (selectedPatient != null)
            {
                _selectedPatientId = selectedPatient.Id;
                txtName.Text = selectedPatient.Name;
                txtPhone.Text = selectedPatient.Phone;
                dtpDateOfBirth.Value = selectedPatient.DateOfBirth;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            if (_selectedPatientId == 0)
            {
                MessageBox.Show("Please select a patient from the list first.");
                return;
            }
            var confirmResult = MessageBox.Show(
                "Are you sure you want to delete this patient?",
                "Confirm Delete",
                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                _patientService.DeletePatient(_selectedPatientId);
                ClearInputs();
                LoadPatients();
                MessageBox.Show("Patient deleted successfully.");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {            
            try
            {
                if (_selectedPatientId == 0)
                {
                    MessageBox.Show("Please select a patient from the list first.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    MessageBox.Show("Please enter both Name and Phone.");
                    return;
                }

                var patient = new Patient
                {
                    Id = _selectedPatientId,
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    DateOfBirth = dtpDateOfBirth.Value
                };
                _patientService.UpdatePatient(patient);
                ClearInputs();
                LoadPatients();
                MessageBox.Show("Patient updated successfully.");
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
            _selectedPatientId = 0;
            txtName.Clear();
            txtPhone.Clear();
            txtSearch.Clear();
            dtpDateOfBirth.Value = DateTime.Now;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                var patients = _patientService.SearchPatients(txtSearch.Text);

                dgvPatients.DataSource = patients;
            }

        }

        
    }
}
