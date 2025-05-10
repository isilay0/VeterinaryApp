using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinaryApp.Exceptions;
using VeterinaryApp.Http;
using VeterinaryApp.Http.Model;
using VeterinaryApp.Model;


namespace VeterinaryApp.UserControls
{
    public partial class MuayeneControl : UserControl
    {
        private readonly IHttpApi api;
        private IEnumerable<Treatment> treatments;
        public MuayeneControl()
        {
            api = new Api();
            InitializeComponent();
            LoadDoctor();
            LoadAnimal();
            LoadTreatment();
            LoadProduct();
            LoadFee();
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var treatments = new Treatment();

                treatments.DoctorId = (int)cmbVeterinerSecimi.SelectedValue;
                treatments.AnimalId = (int)cmbHastaHayvan.SelectedValue;
                treatments.Disease = txtSikayet.Text;
                treatments.Operation = txtYapilanİslem.Text;
                treatments.ProductId = (int)cmbUrun.SelectedValue;
                treatments.TreatmentFee = (int)numericMuayeneUcreti.Value;
                treatments.FeeStatus = cmbUcret.SelectedItem.ToString();
                DateTime muayeneTarih = dtpTarih.Value;
                treatments.Date = ConvertToEpochMillis(muayeneTarih);
                treatments.DoctorNote = txtDoktorNotu.Text;

                await api.Post<Treatment, object>("api/Treatment", treatments);
                MessageBox.Show($"Kaydetme başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (BadRequestException ex)
            {
                MessageBox.Show($"Kaydetme başarısız: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show($"Kaydetme başarısız:\nLütfen gerekli tüm alanları doldurduğunuzdan emin olun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadDoctor()
        {
            try
            {
                var doctorList = await api.Get<List<Doctor>>("api/Doctor");

                // Ad soyad birleştirip yeni bir liste oluştur
                var displayList = doctorList.Select(c => new
                {
                    FullName = $"{c.Name} {c.Surname}",
                    c.Id
                }).ToList();

                cmbVeterinerSecimi.DataSource = displayList;
                cmbVeterinerSecimi.DisplayMember = "FullName";
                cmbVeterinerSecimi.ValueMember = "Id";

                if (doctorList.Count > 0)
                {
                    cmbVeterinerSecimi.SelectedIndex = 0;
                }
            }
            catch (BadRequestException ex)
            {
                MessageBox.Show($"Doktor alınırken hata oluştu: {ex.Message}");
            }
        }
        private async void LoadAnimal()
        {
            try
            {
                var animalList = await api.Get<List<Animal>>("api/Animal");

                // Ad soyad birleştirip yeni bir liste oluştur
                var displayList = animalList.Select(c => new
                {
                    FullName = $"{c.HbsId} ",
                    c.Id
                }).ToList();

                cmbHastaHayvan.DataSource = displayList;
                cmbHastaHayvan.DisplayMember = "FullName";
                cmbHastaHayvan.ValueMember = "Id";

                if (animalList.Count > 0)
                {
                    cmbHastaHayvan.SelectedIndex = 0;
                }
            }
            catch (BadRequestException ex)
            {
                MessageBox.Show($"Hayvanlar alınırken hata oluştu: {ex.Message}");
            }
        }
        private async void LoadProduct()
        {
            try
            {
                var productList = await api.Get<List<Product>>("api/Product");

                // Ad soyad birleştirip yeni bir liste oluştur
                var displayList = productList.Select(c => new
                {
                    FullName = $"{c.Name} ",
                    c.Id
                }).ToList();

                cmbUrun.DataSource = displayList;
                cmbUrun.DisplayMember = "FullName";
                cmbUrun.ValueMember = "Id";

                if (productList.Count > 0)
                {
                    cmbUrun.SelectedIndex = 0;
                }
            }
            catch (BadRequestException ex)
            {
                MessageBox.Show($"Ürünler alınırken hata oluştu: {ex.Message}");
            }
        }
        private void LoadFee()
        {
            var fee = new List<string> { "Kredi Kartı", "Nakit" };
            cmbUcret.Items.AddRange(fee.ToArray());
        }
        private void LoadTreatment()
        {
            var fee = new List<string> { "Aşı", "İlaç", "Ameliyat Malzemesi" };
            cmbUrun.Items.AddRange(fee.ToArray());
        }
        private long ConvertToEpochMillis(DateTime date)
        {

            return ((DateTimeOffset)date).ToUnixTimeMilliseconds();
        }

        public async Task GetTreatmentsByAnimalNameAsync(string name)
        {
            try
            {
                btnListele.Enabled = false;
                var response = await api.Get<List<Treatment>>($"/api/Treatment/search/name/{name}");

                if (response != null && response.Any())
                {
                    DataGridmuayene.DataSource = response.Select(t => new
                    {
                        AnimalName = t.Animals != null ? t.Animals.FirstOrDefault()?.Name : null,
                        DoctorName = t.Doctors != null ? t.Doctors.FirstOrDefault()?.Name : null,
                        Disease = t.Disease,
                        Operation = t.Operation,
                        TreatmentFee = t.TreatmentFee,
                        FeeStatus = t.FeeStatus,
                        Date = t.Date,
                        DoctorNote = t.DoctorNote
                    }).ToList();
                    btnListele.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Kayıtlı işlem bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnListele.Enabled = true;
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
        private async void btnListele_Click(object sender, EventArgs e)
        {
            await GetTreatmentsByAnimalNameAsync(txtArama.Text);
        }
    }

}

