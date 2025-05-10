using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinaryApp.Exceptions;
using VeterinaryApp.Http;
using VeterinaryApp.Model;
using VeterinaryApp.ViewModel;

namespace VeterinaryApp.UserControls
{
    public partial class StokControl : UserControl
    {
        private readonly IHttpApi api;
        private IEnumerable<Product> products;
        public StokControl()
        {
            api = new Api();
            InitializeComponent();
            LoadType();
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            var products = new Product();
            {
                products.ClinicId = 2;
                products.Name = txtUrunAdi.Text;
                products.Type = cmbUrunTuru.SelectedItem.ToString();
                products.Quantity = (int)numericStokMiktari.Value;
                products.BuyFee = (int)numericAlisFiyati.Value;
                products.SellFee = (int)numericSatisFiyati.Value;
                products.Barcode = txtBarkod.Text;
                DateTime expirationDate = dtpSonKullanma.Value;
                products.ExpirationDate = ConvertToEpochMillis(expirationDate);
            };
            try
            {
                await api.Post<Product, object>("api/Product", products);
                MessageBox.Show($"Kaydetme başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (BadRequestException ex)
            {
                MessageBox.Show($"Kaydetme başarısız: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadType()
        {
            var type = new List<string> { "Aşı", "İlaç", "Ameliyat Malzemesi" };
            cmbUrunTuru.Items.AddRange(type.ToArray());
        }
        private long ConvertToEpochMillis(DateTime date)
        {

            return ((DateTimeOffset)date).ToUnixTimeMilliseconds();
        }

        public async Task GetByName(string name)
        {
            btnUrunGetir.Enabled = false;
            Product product = await api.Get<Product>($"/api/Product/search/name/{name}");
            if (product != null)
            {
                var productViewModel = new ProductViewModel
                {
                    Name = product.Name,
                    Type = product.Type,
                    Quantity = product.Quantity,
                    BuyFee = product.BuyFee,
                    SellFee = product.SellFee,
                    ExpirationDate = product.ExpirationDate,
                    Barcode = product.Barcode
                };
                DataGridStok.DataSource = new List<ProductViewModel> { productViewModel }; 
            }
            else
            {
                DataGridStok.DataSource = new List<ProductViewModel>();
            }

            btnUrunGetir.Enabled = true;
        }



        private async void btnMusteriBilgiAra_Click(object sender, EventArgs e)
        {
            await GetByName(txtArama.Text);
        }
    }
}
