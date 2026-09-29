using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniClinic.Domain.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }



        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentException("Patient name is required.");
            }

            if (string.IsNullOrWhiteSpace(Phone))
            {
                throw new ArgumentException("Patient phone is required.");
            }

            if (DateOfBirth > DateTime.Now)
            {
                throw new ArgumentException("Date of birth cannot be in the future.");
            }

        }
    }
}
