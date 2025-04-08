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
        [Column("AGE")]
        [JsonProperty("age")]
        public int Age { get; set; }
    }
}
