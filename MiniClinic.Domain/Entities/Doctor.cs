using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniClinic.Domain.Entities
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Specialty { get; set; } 

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentException("Doctor name is required.");
            }

            if (string.IsNullOrWhiteSpace(Specialty))
            {
                throw new ArgumentException("Doctor specialty is required.");
            }


        }

    }
}
