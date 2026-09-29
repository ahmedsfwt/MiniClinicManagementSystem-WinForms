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
    public partial class DoctorForm : Form
    {
        private readonly DoctorService _doctorService;
        private int _selectedDoctorId = 0;

        public DoctorForm()
        {
            InitializeComponent();
            _doctorService = new();
            LoadDoctors();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            LoadDoctors();
        }
        private void LoadDoctors()
        {
            var doctors = _doctorService.GetAllDoctors();
            dgvDoctors.AutoGenerateColumns = false;
            dgvDoctors.DataSource = doctors;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSpecialty.Text))
            {
                MessageBox.Show("Please enter both Name and Specialty.");
                return;
            }
            var doctor = new Doctor
            {
                Name = txtName.Text,
                Specialty = txtSpecialty.Text
            };
            _doctorService.AddDoctor(doctor);
            ClearInputs();
            LoadDoctors();
            MessageBox.Show("Doctor added successfully.");
        }

        private void dgvDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedDoctor = dgvDoctors.CurrentRow.DataBoundItem as Doctor;

            if (selectedDoctor != null)
            {
                _selectedDoctorId = selectedDoctor.Id;
                txtName.Text = selectedDoctor.Name;
                txtSpecialty.Text = selectedDoctor.Specialty;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            

            if(_selectedDoctorId == 0)
            {
                MessageBox.Show("Please select a doctor from the list first.");
                return;
            }
            var confirmResult = MessageBox.Show(
                "Are you sure you want to delete this doctor?",
                "Confirm Delete",
                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                _doctorService.DeleteDoctor(_selectedDoctorId);
                ClearInputs();
                LoadDoctors() ;
                MessageBox.Show("Doctor deleted successfully.");
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedDoctorId == 0)
            {
                MessageBox.Show("Please select a doctor from the list first.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSpecialty.Text))
            {
                MessageBox.Show("Please enter both Name and Specialty.");
                return;
            }
        
            var doctor = new Doctor
            {
                Id = _selectedDoctorId,
                Name = txtName.Text,
                Specialty = txtSpecialty.Text,
            };
            _doctorService.UpdateDoctor(doctor);
            ClearInputs();
            LoadDoctors();
            MessageBox.Show("Doctor updated successfully.");       
                        
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            _selectedDoctorId = 0;
            txtName.Clear();
            txtSpecialty.Clear();
        }
           
       
    }
}
