using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;

namespace VeterinaryApp.WebApi.Model
{
    [Table("SPECIES")]
    public class Species
    {
        [Column("ID")]
        [JsonProperty("id")]
        public int Id { get; set; }
        [Column("Name")]
        [JsonProperty("name")]
        public string? Name { get; set; }

    }
}
