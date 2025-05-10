using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinaryApp.ViewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public int ClinicId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public double BuyFee { get; set; }
        public double SellFee { get; set; }
        public long ExpirationDate { get; set; }
        public string Barcode { get; set; }
    }
}
