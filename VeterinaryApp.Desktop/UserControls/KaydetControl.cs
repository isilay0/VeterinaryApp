using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using Newtonsoft.Json;
using VeterinaryApp.Exceptions;
using VeterinaryApp.Http;
using VeterinaryApp.Model;


namespace VeterinaryApp.UserControls
{
    public partial class KaydetControl : UserControl
    {
        private IEnumerable<Customer> customers;
        private IEnumerable<Animal> animals;
        private readonly IHttpApi api;

        public KaydetControl()
        {
            api = new Api();
            InitializeComponent();
            LoadSpecies();
            LoadBreed();
            LoadBlood();
            LoadGeld();
            LoadCustomer();
        }

        

        private async void btnMusteriKaydet_Click_1(object sender, EventArgs e)
        {
            var customer = new Customer();
            {
                customer.Name = txtMusteriAdi.Text;
                customer.Surname = txtMusteriSoyadi.Text;
                customer.Tckn = txtTC.Text;
                customer.PhoneNumber = txtMusteriTelNo.Text;
                customer.PhoneNumber2 = txtMusteri2TelNo.Text;
                customer.City = txtMusteriIl.Text;
                customer.District = txtMusteriIlce.Text;
                customer.Email = txtEposta.Text;
                customer.Address = txtMusteriAdres.Text;

            };
            try
            {
                await api.Post<Customer, object>("api/Customer", customer);
                MessageBox.Show($"Kaydetme başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (BadRequestException ex)
            {
                MessageBox.Show($"Kaydetme başarısız: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnHastaKaydet_Click_1(object sender, EventArgs e)
        {
            var animal = new Animal();
            {
                animal.CustomerId = (int)ComboHastaSahipSec.SelectedValue;
                animal.DoctorId = 1;
                animal.Name = txtHastaAdi.Text;
                animal.HbsId = txtHastaHbsNo.Text;
                animal.Age = txtHastaYas.Text;
                animal.Gender = RadioBtnDisi.Checked ? false : true;
                animal.SpeciesId = (int)ComboHastaTur.SelectedValue;
                animal.BreedId = (int)ComboHastaIrk.SelectedValue;
                animal.Color = txtHastaRenk.Text;
                animal.Blood = ComboHastaKanGrubu.SelectedItem.ToString();
                animal.Weight = (int)numericHastaKilo.Value;
                animal.Geld = ComBoHastaKisir.SelectedItem.ToString();
                animal.Disease = txtGelmeNedeni.Text;

            }
            try
            {
                await api.Post<Animal, object>("api/Animal", animal);
                MessageBox.Show($"Kaydetme başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (BadRequestException ex)
            {
                MessageBox.Show($"Kaydetme başarısız: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadSpecies()
        {
            try
            {
                // Türleri API'den veya veritabanından al (API örneği kullanılmıştır)
                var speciesList = await api.Get<List<Species>>("api/Species");

                // ComboBox'ı temizle
                ComboHastaTur.Items.Clear();

                // ComboBox'a türleri ekle
                foreach (var species in speciesList)
                {
                    ComboHastaTur.DataSource = speciesList;
                    ComboHastaTur.DisplayMember = "Name"; // Gözükecek alan
                    ComboHastaTur.ValueMember = "Id";
                }

                // İlk öğeyi seçili yapmak (opsiyonel)
                if (ComboHastaTur.Items.Count > 0)
                {
                    ComboHastaTur.SelectedIndex = 0;
                }
            }
            catch (BadRequestException ex)
            {
                MessageBox.Show($"Türler alınırken hata oluştu: {ex.Message}");
            }
        }
        private async void LoadBreed()
        {
            try
            {
                var breedList = await api.Get<List<Breed>>("api/Breed");

                ComboHastaIrk.DataSource = breedList;
                ComboHastaIrk.DisplayMember = "BreedName";  // Gözüken kısım
                ComboHastaIrk.ValueMember = "Id";           // Gönderilecek olan değer (muhtemelen "Id" veya "BreedId")

                if (breedList.Count > 0)
                {
                    ComboHastaIrk.SelectedIndex = 0;
                }
            }
            catch (BadRequestException ex)
            {
                MessageBox.Show($"Irklar alınırken hata oluştu: {ex.Message}");
            }
        }

        private void LoadBlood()
        {
            var blood = new List<string> { "ARH+", "BRH-", "AB" };
            ComboHastaKanGrubu.Items.AddRange(blood.ToArray());
        }
        private void LoadGeld()
        {
            ComBoHastaKisir.Items.Add("Kısır");
            ComBoHastaKisir.Items.Add("Kısır Değil");
            ComBoHastaKisir.SelectedIndex = 0;

        }

        private async void LoadCustomer()
        {
            try
            {
                var customerList = await api.Get<List<Customer>>("api/Customer");

                // Ad soyad birleştirip yeni bir liste oluştur
                var displayList = customerList.Select(c => new
                {
                    FullName = $"{c.Name} {c.Surname}",
                    c.Id
                }).ToList();

                ComboHastaSahipSec.DataSource = displayList;
                ComboHastaSahipSec.DisplayMember = "FullName";
                ComboHastaSahipSec.ValueMember = "Id";

                if (customerList.Count > 0)
                {
                    ComboHastaSahipSec.SelectedIndex = 0;
                }
            }
            catch (BadRequestException ex)
            {
                MessageBox.Show($"Müşteriler alınırken hata oluştu: {ex.Message}");
            }
        }

        
    }
}