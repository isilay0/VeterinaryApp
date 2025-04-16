using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryApp.Model
{
    internal class Doctor
    {
        public int Id { get; set; }
        public string ClinicId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Rating { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
