using Microsoft.Extensions.Logging;
using VeterinaryAppNew.Resources;

namespace VeterinaryAppNew
{
    public partial class MainForm : Form
    {
        //private readonly Panel sidebarPanel;
        //private readonly Button btnDashboard;
        //private readonly Button btnSettings;
        private readonly ILogger<MainForm> logger;
        public MainForm(ILogger<MainForm> logger)
        {
            this.logger = logger;
            try
            {
                logger.LogInformation("MainForm.Ctor().. | Start");
                InitializeComponent();
                //sidebarPanel = new Panel
                //{
                //    Dock = DockStyle.Left,
                //    Width = 200,
                //    BackColor = Color.FromArgb(30, 30, 40), // koyu gri ton
                //};
                //this.Controls.Add(sidebarPanel);

                //// Buton: Dashboard
                //btnDashboard = CreateSidebarButton("Dashboard", AppResource.VetClinic);
                //btnDashboard.Top = 60;
                //sidebarPanel.Controls.Add(btnDashboard);

                //// Buton: Settings
                //btnSettings = CreateSidebarButton("Ayarlar", AppResource.shopping_cart);
                //btnSettings.Top = btnDashboard.Bottom + 10;
                //sidebarPanel.Controls.Add(btnSettings);
                logger.LogInformation("MainForm.Ctor().. | End");
            }
            catch (Exception ex)
            {
                logger.LogError($"MainForm.Ctor().. | Error : {ex.Message}");
            }

        }

        //private Button CreateSidebarButton(string text, Image icon)
        //{
        //    var btn = new Button
        //    {
        //        Text = "  " + text,
        //        TextAlign = ContentAlignment.MiddleLeft,
        //        Image = icon,
        //        ImageAlign = ContentAlignment.MiddleLeft,
        //        FlatStyle = FlatStyle.Flat,
        //        ForeColor = Color.White,
        //        Font = new Font("Segoe UI", 10, FontStyle.Regular),
        //        Height = 45,
        //        Width = sidebarPanel.Width,
        //        BackColor = Color.FromArgb(30, 30, 40),
        //        Cursor = Cursors.Hand
        //    };

        //    btn.FlatAppearance.BorderSize = 0;
        //    btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(50, 50, 60);
        //    btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(30, 30, 40);

        //    return btn;
        //}
    }
}
