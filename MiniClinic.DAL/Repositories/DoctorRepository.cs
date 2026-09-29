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
    public class DoctorRepository
    {
        private readonly AppDbContext _context;

        public DoctorRepository()
        {
            _context = new AppDbContext();
        }

        public List<Doctor> GetAll()
        {
            return _context.Doctors.AsNoTracking().ToList();
        }

        public Doctor? GetById(int id)
        {
            return _context.Doctors.FirstOrDefault(d => d.Id == id);
        }

        public void Add(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }

        public void Update(Doctor doctor)
        {
            _context.Doctors.Update(doctor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var doctor = GetById(id);

            if (doctor != null)
            {
                _context.Doctors.Remove(doctor);
                _context.SaveChanges();
            }
        }
    }
}
