using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryApp.Model
{
    internal class Appointment
    {
        public int Id { get; set; }
        public int AnımalId { get; set; }
        public int DoctorId { get; set; }
        public int CustomerId { get; set; }
        public long Date { get; set; }

    }
}
