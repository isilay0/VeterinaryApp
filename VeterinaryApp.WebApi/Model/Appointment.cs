using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeterinaryApp.WebApi.Model
{
    [Table("APPOINMENT")]
    public class Appointment
    {
        [Column("ID")]
        [JsonProperty("id")]
        public int Id { get; set; }
        [Column("ANIMAL_ID")]
        [JsonProperty("animalId")]
        public int AnimalId { get; set; }
        [Column("DOCTOR_ID")]
        [JsonProperty("doctorId")]
        public int DoctorId { get; set; }
        [Column("CUSTOMER_ID")]
        [JsonProperty("customerId")]
        public int CustomerId { get; set; }
        [Column("DATE")]
        [JsonProperty("date")]
        public long Date { get; set; }
    }
}
