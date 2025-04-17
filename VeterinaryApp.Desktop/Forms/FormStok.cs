using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinaryApp.Exceptions;
using VeterinaryApp.Http;
using VeterinaryApp.Model;

namespace VeterinaryApp.Forms
{
    public partial class FormStok : Form
    {
        private List<Product> products = new List<Product>();
        private readonly IHttpApi api;
        public FormStok()
        {
            api = new Api();
            InitializeComponent();
            //productsDataGrid.DataSourceChanged += ProductsDataGrid_DataSourceChanged;

        }


        private async Task LoadProducts()
        {
            try
            {
                if (productsDataGrid.Rows.Count > 0)
                {
                    productsDataGrid.Rows.Clear();
                }
                products = await api.Get<List<Product>>("api/Product");
                foreach (Product product in products)
                {
                    if (productsDataGrid.Columns != null && productsDataGrid.Columns.Count > 0)
                    {
                        productsDataGrid.Rows.Add(product.Id, product.Name, product.Type, product.Quantity, product.BuyFee, product.SellFee);
                    }
                }
                productsDataGrid.Refresh();
            }
            catch (BadRequestException ex)
            {
                MessageBox.Show($"Veri çekme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            string urunAdi = txtUrunAdi.Text;
            string urunTuru = txtUrunTuru.Text;
            int stokMiktari = (int)numericStokMiktari.Value;
            double alis = double.Parse(txtAlis.Text);
            double satis = double.Parse(txtSatis.Text);

            var product = new Product
            {
                Name = urunAdi,
                Type = urunTuru,
                Quantity = stokMiktari,
                BuyFee = alis,
                SellFee = satis,
                ClinicId = 2
            };
            try
            {
                await api.Post<Product, object>("api/Product", product);
                productsDataGrid.Rows.Add(product.Id, product.Name, product.Type, product.Quantity, product.BuyFee, product.SellFee);
            }
            catch (BadRequestException ex)
            {
                MessageBox.Show($"Kaydetme başarısız: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)productsDataGrid.SelectedRows[0].Cells[0].Value;
                await api.Delete<object>($"api/Product/{id}");
                productsDataGrid.Rows.Remove(productsDataGrid.SelectedRows[0]);
                productsDataGrid.Refresh();
            }
            catch (BadRequestException ex)
            {

                MessageBox.Show($"Silme başarısız: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void FormStok_Load(object sender, EventArgs e)
        {
            await LoadProducts();
        }
    }
}
