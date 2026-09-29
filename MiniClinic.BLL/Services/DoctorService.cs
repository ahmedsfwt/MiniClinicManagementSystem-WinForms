using Microsoft.EntityFrameworkCore.Internal;
using MiniClinic.DAL.Data;
using MiniClinic.DAL.Repositories;
using MiniClinic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniClinic.BLL.Services
{
    public class DoctorService
    {
        private readonly DoctorRepository _doctorRepository;

        public DoctorService()
        { 
            _doctorRepository = new DoctorRepository();
        }

        public List<Doctor> GetAllDoctors(){

            return _doctorRepository.GetAll();
        }

        public Doctor? GetDoctorById(int id){

            return _doctorRepository.GetById(id);
        }

        public void AddDoctor(Doctor doctor) {

            doctor.Validate();
            _doctorRepository.Add(doctor);
        }

        public void UpdateDoctor(Doctor doctor){

            doctor.Validate();
            _doctorRepository.Update(doctor);
        }

        public void DeleteDoctor(int id) {

            _doctorRepository.Delete(id);
        }

    }
}
