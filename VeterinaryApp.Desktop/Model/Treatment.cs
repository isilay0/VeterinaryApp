using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryApp.Model
{
    internal class Treatment
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int AnimalId { get; set; }
        public string Operation { get; set; }
        public string DoctorNote { get; set; }
        public double TreatmentFee { get; set; }
        public long Date { get; set; }
        public string Disease {  get; set; }
        public int ProductId { get; set; }
        public string FeeStatus { get; set; }
        public string DoctorName { get; set; }
        public string AnimalName { get; set; }
        public Doctor[] Doctors { get; set; }
        public Animal[] Animals { get; set; }
    }
}
