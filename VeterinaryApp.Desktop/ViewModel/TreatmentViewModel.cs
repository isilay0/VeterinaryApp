using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryApp.ViewModel
{
    internal class TreatmentViewModel
    {
        public string AnimalName { get; set; }
        public string DoctorName { get; set; }
        public string Disease { get; set; }
        public string Operation { get; set; }
        public double TreatmentFee { get; set; }
        public string FeeStatus { get; set; }
        public long Date { get; set; }
        public string DoctorNote { get; set; }
    }
}
