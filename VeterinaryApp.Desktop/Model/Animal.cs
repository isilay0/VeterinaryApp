using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryApp.Model
{
    
    internal class Animal
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int BreedId { get; set; }
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Disease { get; set; }
        public string Age { get; set; }
        public bool Gender { get; set; }

        public int SpeciesId { get; set; }
        public string Color { get; set; }
        public string Blood {  get; set; }
        public int Weight { get; set; }
        public string HbsId { get; set; }

        public string Geld { get; set; }
        


    }
}
