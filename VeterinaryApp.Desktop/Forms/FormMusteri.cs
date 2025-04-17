using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using VeterinaryApp.Model;
using VeterinaryApp.Http;
using VeterinaryApp.Http.Model;
using VeterinaryApp.Exceptions;

namespace VeterinaryApp.Forms
{
    public partial class FormMusteri : Form
    {

        private IEnumerable<Customer> customers;
        private IEnumerable<Breed> breeds;
        private IEnumerable<Doctor> doctors;
        private readonly IHttpApi api;
        public FormMusteri()
        {
            api = new Api();
            InitializeComponent();
            LoadComboboxItems();
        }

        private async void LoadComboboxItems()
        {
            customers = await api.Get<IEnumerable<Customer>>("api/Customer");
            breeds = await api.Get<IEnumerable<Breed>>("api/Breed");
            doctors = await api.Get<IEnumerable<Doctor>>("api/Doctor");

            if (customers != null)
            {

                foreach (var customer in customers)
                {
                    ComboBoxMusteriSecim.Items.Add($"{customer.Name} {customer.Surname}");
                }
            }
            if (breeds != null)
            {
                foreach (var breed in breeds)
                {
                    ComboBoxCinsSecim.Items.Add($"{breed.BreedName}");
                }
            }
            if (doctors != null)
            {
                foreach (var doctor in doctors)
                {
                    ComboBoxDoktorSecim.Items.Add($"{doctor.Name} {doctor.Surname}");
                }
            }
        }

        private async void btnMusteriKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtMusteriAdi.Text;
            string soyad = txtMusteriSoyadi.Text;
            string telefon = txtMusteriTelNo.Text;
            string adres = txtMusteriAdres.Text;
            string sehir = txtMusteriIl.Text;
            string ilce = txtMusteriIlce.Text;

            var Customer = new Customer
            {
                Name = ad,
                Surname = soyad,
                PhoneNumber = telefon,
                Address = adres,
                City = sehir,
                District = ilce
            };
            try
            {
                await api.Post<Customer, object>("api/Customer", Customer);
            }
            catch (BadRequestException ex)
            {
                MessageBox.Show($"Kaydetme başarısız: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnHayvanKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                await api.Post<Animal, object>("api/Animal", new Animal()
                {
                    CustomerId = customers.FirstOrDefault(x => $"{x.Name} {x.Surname}" == (string)ComboBoxMusteriSecim.SelectedItem).Id,
                    BreedId = breeds.FirstOrDefault(x => x.BreedName == (string)ComboBoxCinsSecim.SelectedItem).Id,
                    DoctorId = doctors.FirstOrDefault(x => $"{x.Name} {x.Surname}" == (string)ComboBoxDoktorSecim.SelectedItem).Id,
                    Name = txtHayvanAdi.Text,
                    Disease = txtHayvanSikayet.Text,
                    Age = DateTime.Now.Year - int.Parse(txtHayvanDogumTarihi.Text),
                    Gender = RadioButtonDisi.Checked ? false : true,
                });
            }
            catch (BadRequestException ex)
            {
                MessageBox.Show($"Kaydetme başarısız: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
