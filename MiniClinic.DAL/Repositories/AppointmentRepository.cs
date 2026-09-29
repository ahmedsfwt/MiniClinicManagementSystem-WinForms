using Microsoft.EntityFrameworkCore;
using MiniClinic.DAL.Data;
using MiniClinic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniClinic.DAL.Repositories
{
    public class AppointmentRepository
    {
        private readonly AppDbContext _context;
        public AppointmentRepository()
        {
            _context = new();
        }

        public List<Appointment> GetAll()
        {
            return _context.Appointments.AsNoTracking()
                .Include(a => a.Doctor)
                .Include(a => a.Patient).ToList();
        }

        public Appointment? GetById(int id)
        {
            return _context.Appointments.AsNoTracking()
                .Include(a => a.Doctor)
                .Include(a => a.Patient)
                .FirstOrDefault(a => a.Id == id);
        }

        public List<Appointment> GetByPatientId(int id)
        {
            return _context.Appointments.AsNoTracking()
                .Include(a => a.Doctor)
                .Where(a => a.PatientId == id).ToList();
        }

        public List<Appointment> GetByDoctorId(int id) {
            return _context.Appointments.AsNoTracking().Where(a => a.DoctorId == id).ToList();
        }

        public void Add(Appointment appointment){
            _context.Appointments.Add(appointment);
            _context.SaveChanges();
        }

        public void Update(Appointment appointment){
            _context.Appointments.Update(appointment);
            _context.SaveChanges();
        }

        public void Delete(int id) {
            var appointment = GetById(id);

            if (appointment != null) {
                _context.Appointments.Remove(appointment);
                _context.SaveChanges();
            }
        }

    }
}
