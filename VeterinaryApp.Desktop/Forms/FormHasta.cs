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
using VeterinaryApp.Exceptions;
using VeterinaryApp.Http;
using VeterinaryApp.Model;

namespace VeterinaryApp.Forms
{
    public partial class FormHasta : Form
    {
        private List<Customer> customers = new List<Customer>();
        private List<Animal> animals = new List<Animal>();
        private List<Breed> breeds = new List<Breed>();
        private List<Doctor> doctors = new List<Doctor>();
        private readonly IHttpApi api;
        public FormHasta()
        {
            api = new Api();
            InitializeComponent();
        }

        private async void txtMusteriArat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                await GetCustomers(txtMusteriArat.Text);
            }
        }
        
        private async void txtHayvanArat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                await GetAnimals(txtHayvanArat.Text);
            }
        }

        public async Task GetCustomers(string filtreKriter)
        {
            try
            {
                customers = await api.Get<List<Customer>>("api/Customer");

                if (DataGridViewMusteriBilgi.Rows.Count > 0)
                {
                    DataGridViewMusteriBilgi.Rows.Clear();
                }
                foreach (var customer in customers.Where(x => x.Name.ToLowerInvariant().Contains(filtreKriter.ToLowerInvariant())))
                {
                    DataGridViewMusteriBilgi.Rows.Add(customer.Name, customer.Surname, customer.PhoneNumber, customer.Address, customer.City, customer.District);
                }
                DataGridViewMusteriBilgi.Refresh();

            }
            catch (BadRequestException ex)
            {
                MessageBox.Show($"Listeleme başarısız: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async Task GetAnimals(string filtreKriter)
        {
            try
            {
                animals = await api.Get<List<Animal>>("api/Animal");
                breeds = await api.Get<List<Breed>>("api/Breed");
                doctors = await api.Get<List<Doctor>>("api/Doctor");

                if (DataGridViewHayvanBilgi.Rows.Count > 0)
                {
                    DataGridViewHayvanBilgi.Rows.Clear();
                }

                foreach (var animal in animals.Where(x => x.Name.ToLowerInvariant().Contains(filtreKriter.ToLowerInvariant())))
                {
                    DataGridViewHayvanBilgi.Rows.Add(animal.Name, breeds.FirstOrDefault(b => b.Id == animal.BreedId).BreedName, animal.Age, animal.Gender, animal.Disease, doctors.FirstOrDefault(d => d.Id == animal.DoctorId).Name);
                }
                DataGridViewHayvanBilgi.Refresh();

            }
            catch (BadRequestException ex)
            {
                MessageBox.Show($"Listeleme başarısız: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void FormHasta_Load(object sender, EventArgs e)
        {
            await GetCustomers("");
            await GetAnimals("");
        }
    }
}
