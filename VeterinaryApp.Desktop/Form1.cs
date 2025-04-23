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
using VeterinaryApp.UserControls;



namespace VeterinaryApp
{
    public partial class Form1 : Form
    {

        private Button currentButton;
        private Random random;
        private int tempIndex;
        // private Form activeForm;

        private Dictionary<string, UserControl> userControls = new Dictionary<string, UserControl>();
        private UserControl activeControl;


        private void LoadUserControl(string key, Func<UserControl> createFunc, object btnSender)
        {
            if (!userControls.ContainsKey(key))
            {
                var control = createFunc();
                control.Dock = DockStyle.Fill;
                userControls[key] = control;
                panelDesktopPane.Controls.Add(control); // panelDesktopPane senin ana panelin
            }

            // Aktif olan varsa gizle
            if (activeControl != null)
                activeControl.Visible = false;

            ActivateButton(btnSender); // Renkleri değiştirme kısmı aynı kalıyor

            activeControl = userControls[key];
            activeControl.Visible = true;
            lblTitle.Text = key.ToUpper(); // Başlık güncelle

            btnCloseChildForm.Visible = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUserControl("ana sayfa", () => new AnasayfaControl(), null);
        }



        //Constructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;                //Kontrol çubuğunu kaldırdık.
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }




        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                }
            }
        }

        //private void OpenChildForm(Form childForm, object btnSender)
        //{
        //    if (activeForm != null) 
        //    {
        //        activeForm.Close();
        //    }
        //    ActivateButton(btnSender);
        //    activeForm = childForm;
        //    childForm.TopLevel = false;
        //    childForm.FormBorderStyle= FormBorderStyle.None;
        //    childForm.Dock = DockStyle.Fill;
        //    this.panelDesktopPane.Controls.Add(childForm);
        //    this.panelDesktopPane.Tag= childForm;
        //    childForm.BringToFront();
        //    childForm.Show();
        //    lblTitle.Text=childForm.Text;
        //}

        //private void btnMusteri_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new Forms.FormMusteri(), sender);
        //}

        //private void btnHasta_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new Forms.FormHasta(), sender);
        //}

        //private void btnStok_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new Forms.FormStok(), sender);
        //}

        //private void btnMuayene_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new Forms.FormMuayene(), sender);
        //}

        //private void btnRandevu_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new Forms.FormRandevu(), sender);
        //}

        //private void btnFinansal_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new Forms.FormFinansal(), sender);
        //}

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            LoadUserControl("kayıt", () => new KaydetControl(), sender);
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            LoadUserControl("bilgiler", () => new BilgilerControl(), sender);
        }

        private void btnMuayene_Click(object sender, EventArgs e)
        {
            LoadUserControl("muayene", () => new MuayeneControl(), sender);
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            LoadUserControl("stok", () => new StokControl(), sender);
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            LoadUserControl("randevu", () => new RandevuControl(), sender);
        }

        private void btnFinansal_Click(object sender, EventArgs e)
        {
            LoadUserControl("finansal", () => new FinansalControl(), sender);
        }

        //private void btnCloseChildForm_Click(object sender, EventArgs e)
        //{
        //    if (activeForm != null)
        //        activeForm.Close();
        //    Reset();
        //}

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeControl != null)
            {
                activeControl.Visible = false;
                activeControl = null;
            }

            Reset(); // Renkleri ve başlığı sıfırla
            LoadUserControl("ana sayfa", () => new AnasayfaControl(), null);
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "ANA SAYFA";
            panelTitleBar.BackColor = Color.FromArgb(51, 51, 76);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();                        //Ekranın konumunu istediğimiz gibi ayarlayabiliyoruz.
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}

