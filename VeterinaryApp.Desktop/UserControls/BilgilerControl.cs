using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinaryApp.Exceptions;
using VeterinaryApp.Http;
using VeterinaryApp.Model;
using VeterinaryApp.ViewModel;

namespace VeterinaryApp.UserControls
{
    public partial class BilgilerControl : UserControl
    {
        private readonly IHttpApi api;
        private IEnumerable<Customer> customers;
        private IEnumerable<Animal> animals;

        public BilgilerControl()
        {
            api = new Api();
            InitializeComponent();
        }

        public async Task GetAndLoadCustomerByTckn(string tckn)
        {
            try
            {
                btnMusteriBilgiAra.Enabled = false;
                Customer customer = await api.Get<Customer>($"/api/Customer/search/tckn/{tckn}");
                if (customer != null)
                {
                    txtMusteriAdi.Text = customer.Name;
                    txtMusteriSoyadi.Text = customer.Surname;
                    txtMusteriTelNo.Text = customer.PhoneNumber;
                    txtMusteriTelNo2.Text = customer.PhoneNumber2;
                    txtMusteriIl.Text = customer.City;
                    txtMusteriIlce.Text = customer.District;
                    txtMusteriEposta.Text = customer.Email;
                    txtMusteriAdres.Text = customer.Address;

                    if (customer.Animals != null)
                    {
                        if (customer.Animals.Length > 0)
                        {
                            //ComBoxHastaSec.DataSource = customer.Animals.Select(x => $"{x.Name} - {x.Species.Name}").ToArray();
                            var animalViewModels = customer.Animals.Select(a => new AnimalViewModel
                            {
                                Name = a.Name,
                                SpeciesName = a.Species?.Name,
                                Age = a.Age,
                                Blood = a.Blood,
                                BreedName = a.Breed?.BreedName,
                                Color = a.Color,
                                Disease = a.Disease,
                                //DoctorName = a.Doctor?.Name + " " + a.Doctor.Surname,
                                Geld = a.Geld,
                                Gender = a.Gender,
                                HbsId = a.HbsId,
                                //Id = a.Id,
                                Weight = a.Weight
                            }).ToArray();
                            dataGridHastaGecmisi.DataSource = animalViewModels;
                        }
                        else
                        {
                            //ComBoxHastaSec.Enabled = false;
                            //ComBoxHastaSec.Items.Add("Hayvan Bulunamadı");
                        }
                    }
                    btnMusteriBilgiAra.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"Müşteri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (BadRequestException ex)
            {
                MessageBox.Show($"{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Unhandled Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComBoxHastaSec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnMusteriBilgiAra_Click(object sender, EventArgs e)
        {
            await GetAndLoadCustomerByTckn(txtMusteriTC.Text);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
            }
        }
    }
}
