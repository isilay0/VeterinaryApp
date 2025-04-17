using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeterinaryApp.WebApi.Model
{
    [Table("ANIMAL")]
    public class Animal
    {
        [Column("ID")]
        [JsonProperty("id")]
        public int Id { get; set; }

        [Column("CUSTOMER_ID")]
        [JsonProperty("customerId")]
        public int CustomerId { get; set; }

        [Column("BREED_ID")]
        [JsonProperty("breedId")]
        public int BreedId { get; set; }

        [Column("DOCTOR_ID")]
        [JsonProperty("doctorId")]
        public int DoctorId { get; set; }

        [Column("NAME")]
        [JsonProperty("name")]
        public string? Name { get; set; }

        [Column("DISEASE")]
        [JsonProperty("disease")]
        public string? Disease { get; set; }

        [Column("BIRTHDATE")]
        [JsonProperty("birthDate")]
        public long BirthDate { get; set; }
        [Column("GENDER")]
        [JsonProperty("gender")]
        public bool Gender { get; set; }
        [Column("SPECIES_ID")]
        [JsonProperty("speciesId")]
        public int SpeciesId { get; set; }
        [Column("COLOR")]
        [JsonProperty("color")]
        public string? Color { get; set; }
        [Column("BLOOD_GROUP")]
        [JsonProperty("bloodGroup")]
        public string? Blood { get; set; }
        [Column("WEIGHT")]
        [JsonProperty("weight")]
        public int Weight { get; set; }
        [Column("HBS_ID")]
        [JsonProperty("hbsId")]
        public string? HbsId { get; set; }
        [Column("ADAPTION")]
        [JsonProperty("adaption")]
        public bool Adaption { get; set; }

    }
}
