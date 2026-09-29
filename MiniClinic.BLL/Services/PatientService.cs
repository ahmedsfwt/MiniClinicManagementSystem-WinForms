using MiniClinic.DAL.Repositories;
using MiniClinic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniClinic.BLL.Services
{
    public class PatientService
    {
        private readonly PatientRepository _patientRepository;

        public PatientService()
        {
            _patientRepository = new();
        }

        public List<Patient> GetPatients()
        {
            return _patientRepository.GetAll();
        }
        public Patient? GetPatientById(int id)
        {
            return _patientRepository.GetById(id);
        }

        public void AddPatient(Patient patient)
        {
            patient.Validate();
            _patientRepository.Add(patient);
        }

        public void UpdatePatient(Patient patient)
        {
            patient.Validate();
            _patientRepository.Update(patient);
        }

        public void DeletePatient(int id) {
        
            _patientRepository.Delete(id);
        }

        public List<Patient> SearchPatients(string name)
        {
            return _patientRepository.Search(name);
        }
    }
}
