using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeterinaryApp.WebApi.Model
{
    [Table("BREED")]
    public class Breed
    {
        [Column("ID")]
        [JsonProperty("id")]
        public int Id { get; set; }
        [Column("BREED_NAME")]
        [JsonProperty("breedName")]
        public string? BreedName { get; set; }
        [Column("SPECIES_ID")]
        [JsonProperty("SpeciesId")]
        public int SpeciesId { get; set; }

    }
}
