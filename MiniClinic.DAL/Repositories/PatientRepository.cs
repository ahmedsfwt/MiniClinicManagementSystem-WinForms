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
    public class PatientRepository
    {
        private readonly AppDbContext _context;

        public PatientRepository()
        {
            _context = new();
        }

        public List<Patient> GetAll(){
            return _context.Patients.AsNoTracking().ToList();
        }

        public Patient? GetById(int id){
            return _context.Patients.FirstOrDefault(p => p.Id == id);
        }

        public List<Patient> Search(string name){
            return _context.Patients.Where(p => p.Name.Contains(name)).ToList();
        }

        public void Add(Patient patient) {
            _context.Patients.Add(patient);
            _context.SaveChanges();
        }

        public void Update(Patient patient)
        {
            _context.Patients.Update(patient);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var patient = GetById(id);
            if (patient != null)
            {
                _context.Patients.Remove(patient);
                _context.SaveChanges();
            }
        }
    }
}
