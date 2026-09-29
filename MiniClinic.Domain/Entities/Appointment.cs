using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniClinic.Domain.Entities
{
    public class Appointment
    {
        public int Id { get; set; }       
        
        public DateTime AppointmentDate { get; set; }
        public string Notes { get; set; }
        public int DoctorId { get; set; }

        public Doctor Doctor { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        public void Validate()
        {
            if (DoctorId <= 0)
            {
                throw new ArgumentException("A doctor must be selected.");
            }

            if (PatientId <= 0)
            {
                throw new ArgumentException("A patient must be selected.");
            }

            if (AppointmentDate < DateTime.Now)
            {
                throw new ArgumentException("Appointment date cannot be in the past.");
            }


        }

    }
}
