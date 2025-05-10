using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeterinaryApp.WebApi.Model
{
    [Table("TREATMENT")]
    public class Treatment
    {
        [Column("ID")]
        [JsonProperty("id")]
        public int Id { get; set; }
        [Column("DOCTOR_ID")]
        [JsonProperty("doctorId")]
        public int DoctorId { get; set; }

        [Column("ANIMAL_ID")]
        [JsonProperty("animalId")]
        public int AnimalId { get; set; }

        [Column("OPERATION")]
        [JsonProperty("operation")]
        public string? Operation { get; set; }
        [Column("DOCTOR_NOTE")]
        [JsonProperty("doctorNote")]
        public string? DoctorNote { get; set; }
        [Column("TREATMENT_FEE")]
        [JsonProperty("treatmentFee")]
        public double TreatmentFee { get; set; }
        [Column("DATE")]
        [JsonProperty("date")]
        public long Date { get; set; }
        [Column("DISEASE")]
        [JsonProperty("disease")]
        public string? Disease { get; set; }
        [Column("PRODUCT_ID")]
        [JsonProperty("productId")]
        public int ProductId { get; set; }
        [Column("FEE_STATUS")]
        [JsonProperty("feeStatus")]
        public string? FeeStatus { get; set; }
        [JsonProperty("animal")]
        public Animal? Animal { get; set; }
        [JsonProperty("doctor")]
        public Doctor? Doctor { get; set; }


    }
}
