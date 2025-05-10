using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeterinaryApp.WebApi.Model
{
    [Table("PRODUCT")]
    public class Product
    {
        [Column("ID")]
        [JsonProperty("id")]
        public int Id { get; set; }
        [Column("CLINIC_ID")]
        [JsonProperty("clinicId")]
        public int ClinicId { get; set; }
        [Column("NAME")]
        [JsonProperty("name")]
        public string? Name { get; set; }
        [Column("TYPE")]
        [JsonProperty("type")]
        public string? Type { get; set; }
        [Column("QUANTITY")]
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [Column("BUY_FEE")]
        [JsonProperty("buyFee")]
        public double BuyFee { get; set; }
        [Column("SELL_FEE")]
        [JsonProperty("sellFee")]
        public double SellFee { get; set; }
        [Column("EXPIRATION_DATE")]
        [JsonProperty("expirationDate")]
        public long ExpirationDate { get; set; }
        [Column("BARCODE")]
        [JsonProperty("barcode")]
        public string? Barcode { get; set; }
    }
}
