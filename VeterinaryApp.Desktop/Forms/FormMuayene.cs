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
    public partial class FormMuayene : Form
    {
        private List<Treatment> treatments = new List<Treatment>();
        private IEnumerable<Doctor> doctors;
        private IEnumerable<Animal> animals;
        private readonly IHttpApi api;
        public FormMuayene()
        {
            api = new Api();
            InitializeComponent();
            LoadComboboxItems();
        }

        private async void LoadComboboxItems()
        {
            doctors = await api.Get<IEnumerable<Doctor>>("api/Doctor");
            animals = await api.Get<IEnumerable<Animal>>("api/Animal");



            if (doctors != null)
            {
                foreach (var doctor in doctors)
                {
                    comboDoktor.Items.Add($"{doctor.Name} {doctor.Surname}");
                }
            }
            if (animals != null)
            {
                foreach (var animal in animals)
                {
                    cmbHastaHayvan.Items.Add($"{animal.Name}");
                }
            }
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {

            try
            {
                await api.Post<Treatment, object>("api/Treatment", new Treatment()
                {

                    DoctorId = doctors.FirstOrDefault(d => $"{d.Name} {d.Surname}" == (string)comboDoktor.SelectedItem).Id,
                    AnimalId = animals.FirstOrDefault(a => a.Name == (string)cmbHastaHayvan.SelectedItem).Id,
                    Operation = txtYapilanİslem.Text,
                    DoctorNote = txtDoktorNotu.Text,
                    TreatmentFee = (float)numericMuayeneUcreti.Value,
                    Date = ((DateTimeOffset)dtpTarih.Value).ToUnixTimeSeconds()
                });
            }
            catch (BadRequestException ex)
            {
                MessageBox.Show($"Muayene İşlemi başarısız: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadProducts()
        {

            try
            {
                if (muayeneDataGrid.Rows.Count > 0)
                {
                    muayeneDataGrid.Rows.Clear();
                }
                treatments = await api.Get<List<Treatment>>("api/Treatment");
                foreach (Treatment treatment in treatments)
                {
                    if (muayeneDataGrid.Columns != null && muayeneDataGrid.Columns.Count > 0)
                    {
                        var doktor = doctors.FirstOrDefault(d => d.Id == treatment.DoctorId);

                        if (doktor != null)
                        {
                            muayeneDataGrid.Rows.Add(
                                $"{doktor.Name} {doktor.Surname}",
                                treatment.Operation,
                                treatment.DoctorNote,
                                treatment.TreatmentFee,
                                treatment.Date
                            );
                        }
                        else
                        {
                            muayeneDataGrid.Rows.Add(
                                "Bilinmeyen Doktor",
                                treatment.Operation,
                                treatment.DoctorNote,
                                treatment.TreatmentFee,
                                treatment.Date
                            );
                        }
                    }
                }
                muayeneDataGrid.Refresh();
            }
            catch (BadRequestException ex)
            {
                MessageBox.Show($"Veri çekme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private async void txtArama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                await GetTreatments(txtArama.Text);
            }
        }
        private async Task GetTreatments(string filtreKriter)
        {
            try
            {
                treatments = await api.Get<List<Treatment>>("api/Treatment");
                doctors = await api.Get<List<Doctor>>("api/Doctor");

                if (muayeneDataGrid.Rows.Count > 0)
                {
                    muayeneDataGrid.Rows.Clear();
                }
                foreach (var treatment in treatments.Where(x => x.Id.ToString().ToLowerInvariant().Contains(filtreKriter.ToLowerInvariant())))
                {
                    muayeneDataGrid.Rows.Add(doctors.FirstOrDefault(d => d.Id == treatment.DoctorId).Name,treatment.Operation,treatment.DoctorNote,treatment.TreatmentFee,treatment.Date);
                }
                muayeneDataGrid.Refresh();

            }
            catch (BadRequestException ex)
            {
                MessageBox.Show($"Listeleme başarısız: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void FormMuayene_Load(object sender, EventArgs e)
        {
            await LoadProducts();
            await GetTreatments("");
        }
    }
}
