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
        public int Age { get; set; }
        public bool Gender { get; set; }
        public string Anımal { get; set; }


    }
}
