using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeterinaryApp.WebApi.Model
{
    [Table("CUSTOMER")]

    public class Customer
    {
        [Column("ID")]
        [JsonProperty("id")]
        public int Id { get; set; }
        [Column("NAME")]
        [JsonProperty("name")]
        public string? Name { get; set; }
        [Column("SURNAME")]
        [JsonProperty("surname")]
        public string? Surname { get; set; }
        [Column("ADDRESS")]
        [JsonProperty("address")]
        public string? Address { get; set; }
        [Column("PHONE_NUMBER")]
        [JsonProperty("phoneNumber")]
        public string? PhoneNumber { get; set; }
        [Column("CITY")]
        [JsonProperty("city")]
        public string? City { get; set; }
        [Column("DISTRICT")]
        [JsonProperty("district")]
        public string? District { get; set; }
        
    }
}
