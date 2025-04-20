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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.btnFinansal = new System.Windows.Forms.Button();
            this.btnRandevu = new System.Windows.Forms.Button();
            this.btnMuayene = new System.Windows.Forms.Button();
            this.btnStok = new System.Windows.Forms.Button();
            this.btnHasta = new System.Windows.Forms.Button();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnFinansal);
            this.panelMenu.Controls.Add(this.btnRandevu);
            this.panelMenu.Controls.Add(this.btnMuayene);
            this.panelMenu.Controls.Add(this.btnStok);
            this.panelMenu.Controls.Add(this.btnHasta);
            this.panelMenu.Controls.Add(this.btnMusteri);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 833);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "VET CLINIC";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1320, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1184, 4);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 37);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(1232, 4);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(40, 37);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1276, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 37);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(587, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(183, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ANA SAYFA";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1320, 753);
            this.panelDesktopPane.TabIndex = 5;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::VeterinaryApp.Properties.Resources.cross;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(100, 80);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // btnFinansal
            // 
            this.btnFinansal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinansal.FlatAppearance.BorderSize = 0;
            this.btnFinansal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinansal.Font = new System.Drawing.Font("Century Schoolbook", 10F);
            this.btnFinansal.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFinansal.Image = global::VeterinaryApp.Properties.Resources.financial;
            this.btnFinansal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinansal.Location = new System.Drawing.Point(0, 380);
            this.btnFinansal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinansal.Name = "btnFinansal";
            this.btnFinansal.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFinansal.Size = new System.Drawing.Size(220, 60);
            this.btnFinansal.TabIndex = 6;
            this.btnFinansal.Text = "  Finansal";
            this.btnFinansal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinansal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinansal.UseVisualStyleBackColor = true;
            this.btnFinansal.Click += new System.EventHandler(this.btnFinansal_Click);
            // 
            // btnRandevu
            // 
            this.btnRandevu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRandevu.FlatAppearance.BorderSize = 0;
            this.btnRandevu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandevu.Font = new System.Drawing.Font("Century Schoolbook", 10F);
            this.btnRandevu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRandevu.Image = global::VeterinaryApp.Properties.Resources.appointment;
            this.btnRandevu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRandevu.Location = new System.Drawing.Point(0, 320);
            this.btnRandevu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRandevu.Size = new System.Drawing.Size(220, 60);
            this.btnRandevu.TabIndex = 5;
            this.btnRandevu.Text = "  Randevu";
            this.btnRandevu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRandevu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRandevu.UseVisualStyleBackColor = true;
            this.btnRandevu.Click += new System.EventHandler(this.btnRandevu_Click);
            // 
            // btnMuayene
            // 
            this.btnMuayene.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMuayene.FlatAppearance.BorderSize = 0;
            this.btnMuayene.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuayene.Font = new System.Drawing.Font("Century Schoolbook", 10F);
            this.btnMuayene.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMuayene.Image = global::VeterinaryApp.Properties.Resources.pets_vet_animal_health_icon;
            this.btnMuayene.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMuayene.Location = new System.Drawing.Point(0, 260);
            this.btnMuayene.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMuayene.Name = "btnMuayene";
            this.btnMuayene.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMuayene.Size = new System.Drawing.Size(220, 60);
            this.btnMuayene.TabIndex = 4;
            this.btnMuayene.Text = "  Muayene";
            this.btnMuayene.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMuayene.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMuayene.UseVisualStyleBackColor = true;
            this.btnMuayene.Click += new System.EventHandler(this.btnMuayene_Click);
            // 
            // btnStok
            // 
            this.btnStok.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStok.FlatAppearance.BorderSize = 0;
            this.btnStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStok.Font = new System.Drawing.Font("Century Schoolbook", 10F);
            this.btnStok.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStok.Image = global::VeterinaryApp.Properties.Resources.stock_icon__1_;
            this.btnStok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStok.Location = new System.Drawing.Point(0, 200);
            this.btnStok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStok.Name = "btnStok";
            this.btnStok.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnStok.Size = new System.Drawing.Size(220, 60);
            this.btnStok.TabIndex = 3;
            this.btnStok.Text = "  Stok";
            this.btnStok.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStok.UseVisualStyleBackColor = true;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // btnHasta
            // 
            this.btnHasta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHasta.FlatAppearance.BorderSize = 0;
            this.btnHasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHasta.Font = new System.Drawing.Font("Century Schoolbook", 10F);
            this.btnHasta.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHasta.Image = global::VeterinaryApp.Properties.Resources.information_icon;
            this.btnHasta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHasta.Location = new System.Drawing.Point(0, 140);
            this.btnHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnHasta.Size = new System.Drawing.Size(220, 60);
            this.btnHasta.TabIndex = 2;
            this.btnHasta.Text = "  Bilgiler";
            this.btnHasta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHasta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHasta.UseVisualStyleBackColor = true;
            this.btnHasta.Click += new System.EventHandler(this.btnHasta_Click);
            // 
            // btnMusteri
            // 
            this.btnMusteri.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMusteri.FlatAppearance.BorderSize = 0;
            this.btnMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteri.Font = new System.Drawing.Font("Century Schoolbook", 10F);
            this.btnMusteri.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMusteri.Image = global::VeterinaryApp.Properties.Resources.sign_in_icon;
            this.btnMusteri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteri.Location = new System.Drawing.Point(0, 80);
            this.btnMusteri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMusteri.Size = new System.Drawing.Size(220, 60);
            this.btnMusteri.TabIndex = 1;
            this.btnMusteri.Text = "  Kayıt";
            this.btnMusteri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 833);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1261, 605);
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

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Button btnFinansal;
        private System.Windows.Forms.Button btnRandevu;
        private System.Windows.Forms.Button btnMuayene;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnHasta;
        private System.Windows.Forms.Panel panelDesktopPane;
    }
}

