using MiniClinic.DAL.Repositories;
using MiniClinic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniClinic.BLL.Services
{
    public class AppointmentService
    {
        private readonly AppointmentRepository _appointmentRepository;
        private readonly DoctorRepository _doctorRepository;
        private readonly PatientRepository _patientRepository;

        public AppointmentService()
        {
            _appointmentRepository = new();
            _doctorRepository = new();
            _patientRepository = new();
        }

        public List<Appointment> GetAllAppointments()
        {
            return _appointmentRepository.GetAll();
        }

        public Appointment? GetAppointmentById(int id)
        {
            return _appointmentRepository.GetById(id);
        }

        public List<Appointment> GetAppointmentsByPatient(int patientId)
        {
            return _appointmentRepository.GetByPatientId(patientId);
        }

        public void DeleteAppointment(int id)
        {
            _appointmentRepository.Delete(id);
        }

        public void AddAppointment(Appointment appointment)
        {
            ValidateAppointment(appointment);
            _appointmentRepository.Add(appointment);
        }

        public void UpdateAppointment(Appointment appointment)
        {
            ValidateAppointment(appointment, appointment.Id);
            _appointmentRepository.Update(appointment);
        }
        private void ValidateAppointment(Appointment appointment, int currentAppointmentId = 0)
        {
           
            appointment.Validate();

            var doctor = _doctorRepository.GetById(appointment.DoctorId);
            if (doctor == null){
                throw new ArgumentException("Selected doctor does not exist.");
            }

            var patient = _patientRepository.GetById(appointment.PatientId);
            if (patient == null){
                throw new ArgumentException("Selected patient does not exist.");
            }

            
            var doctorAppointments = _appointmentRepository.GetByDoctorId(appointment.DoctorId);

            bool Conflict = doctorAppointments.Any(a =>
                a.Id != currentAppointmentId &&
                a.AppointmentDate.Date == appointment.AppointmentDate.Date &&
                a.AppointmentDate.Hour == appointment.AppointmentDate.Hour &&
                a.AppointmentDate.Minute == appointment.AppointmentDate.Minute);

            if (Conflict){
                throw new ArgumentException("This doctor already has an appointment at this date and time.");
            }
        }
                
    }
}
