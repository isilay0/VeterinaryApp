namespace VeterinaryApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new VeterinaryApp.Component.GradientPanel();
            this.btnFinansal = new System.Windows.Forms.Button();
            this.btnRandevu = new System.Windows.Forms.Button();
            this.btnMuayene = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.btnHasta = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.panelLogo = new VeterinaryApp.Component.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new VeterinaryApp.Component.GradientPanel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(9)))), ((int)(((byte)(183)))));
            this.panelMenu.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(201)))), ((int)(((byte)(240)))));
            this.panelMenu.Controls.Add(this.btnFinansal);
            this.panelMenu.Controls.Add(this.btnRandevu);
            this.panelMenu.Controls.Add(this.btnMuayene);
            this.panelMenu.Controls.Add(this.btnStok);
            this.panelMenu.Controls.Add(this.btnHasta);
            this.panelMenu.Controls.Add(this.btnKayit);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 841);
            this.panelMenu.TabIndex = 3;
            // 
            // btnFinansal
            // 
            this.btnFinansal.BackColor = System.Drawing.Color.Transparent;
            this.btnFinansal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinansal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinansal.FlatAppearance.BorderSize = 0;
            this.btnFinansal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinansal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFinansal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.btnFinansal.Image = global::VeterinaryApp.Properties.Resources.financial;
            this.btnFinansal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinansal.Location = new System.Drawing.Point(0, 325);
            this.btnFinansal.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinansal.Name = "btnFinansal";
            this.btnFinansal.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnFinansal.Size = new System.Drawing.Size(200, 49);
            this.btnFinansal.TabIndex = 13;
            this.btnFinansal.Text = "  Finansal";
            this.btnFinansal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinansal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinansal.UseVisualStyleBackColor = false;
            this.btnFinansal.Click += new System.EventHandler(this.btnFinansal_Click);
            // 
            // btnRandevu
            // 
            this.btnRandevu.BackColor = System.Drawing.Color.Transparent;
            this.btnRandevu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRandevu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRandevu.FlatAppearance.BorderSize = 0;
            this.btnRandevu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRandevu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.btnRandevu.Image = global::VeterinaryApp.Properties.Resources.appointment;
            this.btnRandevu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRandevu.Location = new System.Drawing.Point(0, 276);
            this.btnRandevu.Margin = new System.Windows.Forms.Padding(2);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnRandevu.Size = new System.Drawing.Size(200, 49);
            this.btnRandevu.TabIndex = 12;
            this.btnRandevu.Text = "  Randevu";
            this.btnRandevu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRandevu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRandevu.UseVisualStyleBackColor = false;
            this.btnRandevu.Click += new System.EventHandler(this.btnRandevu_Click);
            // 
            // btnMuayene
            // 
            this.btnMuayene.BackColor = System.Drawing.Color.Transparent;
            this.btnMuayene.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMuayene.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMuayene.FlatAppearance.BorderSize = 0;
            this.btnMuayene.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuayene.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMuayene.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.btnMuayene.Image = global::VeterinaryApp.Properties.Resources.pets_vet_animal_health_icon;
            this.btnMuayene.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMuayene.Location = new System.Drawing.Point(0, 227);
            this.btnMuayene.Margin = new System.Windows.Forms.Padding(2);
            this.btnMuayene.Name = "btnMuayene";
            this.btnMuayene.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnMuayene.Size = new System.Drawing.Size(200, 49);
            this.btnMuayene.TabIndex = 11;
            this.btnMuayene.Text = "  Muayene";
            this.btnMuayene.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMuayene.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMuayene.UseVisualStyleBackColor = false;
            this.btnMuayene.Click += new System.EventHandler(this.btnMuayene_Click);
            // 
            // btnStok
            // 
            this.btnStok.BackColor = System.Drawing.Color.Transparent;
            this.btnStok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStok.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStok.FlatAppearance.BorderSize = 0;
            this.btnStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.btnStok.Image = global::VeterinaryApp.Properties.Resources.stock_icon__1_;
            this.btnStok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStok.Location = new System.Drawing.Point(0, 178);
            this.btnStok.Margin = new System.Windows.Forms.Padding(2);
            this.btnStok.Name = "btnStok";
            this.btnStok.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnStok.Size = new System.Drawing.Size(200, 49);
            this.btnStok.TabIndex = 10;
            this.btnStok.Text = "  Stok";
            this.btnStok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStok.UseVisualStyleBackColor = false;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // btnHasta
            // 
            this.btnHasta.BackColor = System.Drawing.Color.Transparent;
            this.btnHasta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHasta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHasta.FlatAppearance.BorderSize = 0;
            this.btnHasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.btnHasta.Image = global::VeterinaryApp.Properties.Resources.information_icon;
            this.btnHasta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHasta.Location = new System.Drawing.Point(0, 129);
            this.btnHasta.Margin = new System.Windows.Forms.Padding(2);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnHasta.Size = new System.Drawing.Size(200, 49);
            this.btnHasta.TabIndex = 9;
            this.btnHasta.Text = "  Bilgiler";
            this.btnHasta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHasta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHasta.UseVisualStyleBackColor = false;
            this.btnHasta.Click += new System.EventHandler(this.btnHasta_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.Transparent;
            this.btnKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKayit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKayit.FlatAppearance.BorderSize = 0;
            this.btnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnKayit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.btnKayit.Image = global::VeterinaryApp.Properties.Resources.sign_in_icon;
            this.btnKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayit.Location = new System.Drawing.Point(0, 80);
            this.btnKayit.Margin = new System.Windows.Forms.Padding(2);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnKayit.Size = new System.Drawing.Size(200, 49);
            this.btnKayit.TabIndex = 8;
            this.btnKayit.Text = "  Kayıt";
            this.btnKayit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(37)))), ((int)(((byte)(133)))));
            this.panelLogo.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(9)))), ((int)(((byte)(183)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "VET CLINIC";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.panelTitleBar.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(37)))), ((int)(((byte)(133)))));
            this.panelTitleBar.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(9)))), ((int)(((byte)(183)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1342, 80);
            this.panelTitleBar.TabIndex = 4;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::VeterinaryApp.Properties.Resources.cross;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 80);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.lblTitle.Location = new System.Drawing.Point(511, 25);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(138, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ANA SAYFA";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(200, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1342, 761);
            this.panelDesktopPane.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.Location = new System.Drawing.Point(1275, 23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinimize.Location = new System.Drawing.Point(1183, 23);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 37);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaximize.Location = new System.Drawing.Point(1229, 23);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(40, 37);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1542, 841);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(950, 499);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Component.GradientPanel panelMenu;
        private System.Windows.Forms.Button btnFinansal;
        private System.Windows.Forms.Button btnRandevu;
        private System.Windows.Forms.Button btnMuayene;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Button btnHasta;
        private System.Windows.Forms.Button btnKayit;
        private Component.GradientPanel panelLogo;
        private System.Windows.Forms.Label label1;
        private Component.GradientPanel panelTitleBar;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
    }
}

