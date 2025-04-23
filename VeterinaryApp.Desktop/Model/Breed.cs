using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryApp.Model
{
    internal class Breed
    {
        public int Id { get; set; }
        public string BreedName { get; set; }
        public int SpeciesId { get; set; }
    }
}
