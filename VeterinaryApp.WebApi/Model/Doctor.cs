using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeterinaryApp.WebApi.Model
{
    [Table("DOCTOR")]
    public class Doctor
    {
        [Column("ID")]
        [JsonProperty("id")]
        public int Id { get; set; }
        [Column("CLINIC_ID")]
        [JsonProperty("clinicId")]
        public int ClinicId { get; set; }
        [Column("ROLEID")]
        [JsonProperty("roleId")]
        public int RoleId { get; set; }
        [Column("NAME")]
        [JsonProperty("name")]
        public string? Name { get; set; }
        [Column("SURNAME")]
        [JsonProperty("surname")]
        public string? Surname { get; set; }
        [Column("RATING")]
        [JsonProperty("rating")]
        public double Rating { get; set; }
        [Column("PHONE_NUMBER")]
        [JsonProperty("phoneNumber")]
        public string? PhoneNumber { get; set; }
        [Column("EMAIL")]
        [JsonProperty("email")]
        public string? Email { get; set; }
        [Column("PASSWORD")]
        [JsonProperty("password")]
        public string? Password { get; set; }
    }
}
