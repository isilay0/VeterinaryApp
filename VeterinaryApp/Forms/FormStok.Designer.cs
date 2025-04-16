namespace VeterinaryApp.Forms
{
    partial class FormStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStok));
            this.numericStokMiktari = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.btnSil = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEkle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtUrunAdi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtAlis = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSatis = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnFiltreyiTemizle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtArama = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.productsDataGrid = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUrunAdi = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblUrunTuru = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblStokMiktari = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblAlisFiyati = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblSatisFiyati = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtUrunTuru = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericStokMiktari
            // 
            this.numericStokMiktari.Location = new System.Drawing.Point(316, 39);
            this.numericStokMiktari.Name = "numericStokMiktari";
            this.numericStokMiktari.Size = new System.Drawing.Size(158, 34);
            this.numericStokMiktari.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.numericStokMiktari.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.numericStokMiktari.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.numericStokMiktari.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.numericStokMiktari.StateCommon.Border.Rounding = 18;
            this.numericStokMiktari.StateCommon.Border.Width = 1;
            this.numericStokMiktari.TabIndex = 39;
            this.numericStokMiktari.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(936, 30);
            this.btnSil.Name = "btnSil";
            this.btnSil.OverrideDefault.Back.Color1 = System.Drawing.Color.Gray;
            this.btnSil.OverrideDefault.Back.Color2 = System.Drawing.Color.DimGray;
            this.btnSil.OverrideDefault.Back.ColorAngle = 45F;
            this.btnSil.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray;
            this.btnSil.OverrideDefault.Border.Color2 = System.Drawing.Color.DimGray;
            this.btnSil.OverrideDefault.Border.ColorAngle = 45F;
            this.btnSil.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSil.OverrideDefault.Border.Rounding = 18;
            this.btnSil.OverrideDefault.Border.Width = 1;
            this.btnSil.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnSil.Size = new System.Drawing.Size(137, 40);
            this.btnSil.StateCommon.Back.Color1 = System.Drawing.Color.Gray;
            this.btnSil.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.btnSil.StateCommon.Back.ColorAngle = 45F;
            this.btnSil.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnSil.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnSil.StateCommon.Border.ColorAngle = 45F;
            this.btnSil.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSil.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSil.StateCommon.Border.Rounding = 18;
            this.btnSil.StateCommon.Border.Width = 1;
            this.btnSil.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSil.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnSil.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnSil.StatePressed.Back.Color1 = System.Drawing.Color.DarkGray;
            this.btnSil.StatePressed.Back.Color2 = System.Drawing.Color.DimGray;
            this.btnSil.StatePressed.Back.ColorAngle = 130F;
            this.btnSil.StatePressed.Border.Color1 = System.Drawing.Color.DarkGray;
            this.btnSil.StatePressed.Border.Color2 = System.Drawing.Color.DimGray;
            this.btnSil.StatePressed.Border.ColorAngle = 130F;
            this.btnSil.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSil.StatePressed.Border.Rounding = 18;
            this.btnSil.StatePressed.Border.Width = 1;
            this.btnSil.StateTracking.Back.Color1 = System.Drawing.Color.Gray;
            this.btnSil.StateTracking.Back.Color2 = System.Drawing.Color.Gray;
            this.btnSil.StateTracking.Back.ColorAngle = 45F;
            this.btnSil.StateTracking.Border.Color1 = System.Drawing.Color.DarkGray;
            this.btnSil.StateTracking.Border.Color2 = System.Drawing.Color.DimGray;
            this.btnSil.StateTracking.Border.ColorAngle = 45F;
            this.btnSil.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSil.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSil.StateTracking.Border.Rounding = 18;
            this.btnSil.StateTracking.Border.Width = 1;
            this.btnSil.TabIndex = 37;
            this.btnSil.Values.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(783, 30);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.OverrideDefault.Back.Color1 = System.Drawing.Color.Gray;
            this.btnEkle.OverrideDefault.Back.Color2 = System.Drawing.Color.DimGray;
            this.btnEkle.OverrideDefault.Back.ColorAngle = 45F;
            this.btnEkle.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray;
            this.btnEkle.OverrideDefault.Border.Color2 = System.Drawing.Color.DimGray;
            this.btnEkle.OverrideDefault.Border.ColorAngle = 45F;
            this.btnEkle.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEkle.OverrideDefault.Border.Rounding = 18;
            this.btnEkle.OverrideDefault.Border.Width = 1;
            this.btnEkle.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnEkle.Size = new System.Drawing.Size(137, 40);
            this.btnEkle.StateCommon.Back.Color1 = System.Drawing.Color.Gray;
            this.btnEkle.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.btnEkle.StateCommon.Back.ColorAngle = 45F;
            this.btnEkle.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnEkle.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnEkle.StateCommon.Border.ColorAngle = 45F;
            this.btnEkle.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEkle.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEkle.StateCommon.Border.Rounding = 18;
            this.btnEkle.StateCommon.Border.Width = 1;
            this.btnEkle.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnEkle.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnEkle.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnEkle.StatePressed.Back.Color1 = System.Drawing.Color.DarkGray;
            this.btnEkle.StatePressed.Back.Color2 = System.Drawing.Color.DimGray;
            this.btnEkle.StatePressed.Back.ColorAngle = 130F;
            this.btnEkle.StatePressed.Border.Color1 = System.Drawing.Color.DarkGray;
            this.btnEkle.StatePressed.Border.Color2 = System.Drawing.Color.DimGray;
            this.btnEkle.StatePressed.Border.ColorAngle = 130F;
            this.btnEkle.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEkle.StatePressed.Border.Rounding = 18;
            this.btnEkle.StatePressed.Border.Width = 1;
            this.btnEkle.StateTracking.Back.Color1 = System.Drawing.Color.Gray;
            this.btnEkle.StateTracking.Back.Color2 = System.Drawing.Color.Gray;
            this.btnEkle.StateTracking.Back.ColorAngle = 45F;
            this.btnEkle.StateTracking.Border.Color1 = System.Drawing.Color.DarkGray;
            this.btnEkle.StateTracking.Border.Color2 = System.Drawing.Color.DimGray;
            this.btnEkle.StateTracking.Border.ColorAngle = 45F;
            this.btnEkle.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnEkle.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnEkle.StateTracking.Border.Rounding = 18;
            this.btnEkle.StateTracking.Border.Width = 1;
            this.btnEkle.TabIndex = 36;
            this.btnEkle.Values.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(17, 41);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(132, 31);
            this.txtUrunAdi.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtUrunAdi.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtUrunAdi.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtUrunAdi.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUrunAdi.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtUrunAdi.StateCommon.Border.Rounding = 18;
            this.txtUrunAdi.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtUrunAdi.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtUrunAdi.TabIndex = 35;
            // 
            // txtAlis
            // 
            this.txtAlis.Location = new System.Drawing.Point(484, 41);
            this.txtAlis.Name = "txtAlis";
            this.txtAlis.Size = new System.Drawing.Size(123, 31);
            this.txtAlis.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtAlis.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtAlis.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtAlis.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAlis.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtAlis.StateCommon.Border.Rounding = 18;
            this.txtAlis.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtAlis.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlis.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtAlis.TabIndex = 34;
            // 
            // txtSatis
            // 
            this.txtSatis.Location = new System.Drawing.Point(623, 41);
            this.txtSatis.Name = "txtSatis";
            this.txtSatis.Size = new System.Drawing.Size(125, 31);
            this.txtSatis.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtSatis.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtSatis.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtSatis.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSatis.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtSatis.StateCommon.Border.Rounding = 18;
            this.txtSatis.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtSatis.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatis.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtSatis.TabIndex = 33;
            // 
            // btnFiltreyiTemizle
            // 
            this.btnFiltreyiTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFiltreyiTemizle.Location = new System.Drawing.Point(521, 553);
            this.btnFiltreyiTemizle.Name = "btnFiltreyiTemizle";
            this.btnFiltreyiTemizle.OverrideDefault.Back.Color1 = System.Drawing.Color.Gray;
            this.btnFiltreyiTemizle.OverrideDefault.Back.Color2 = System.Drawing.Color.DimGray;
            this.btnFiltreyiTemizle.OverrideDefault.Back.ColorAngle = 45F;
            this.btnFiltreyiTemizle.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray;
            this.btnFiltreyiTemizle.OverrideDefault.Border.Color2 = System.Drawing.Color.DimGray;
            this.btnFiltreyiTemizle.OverrideDefault.Border.ColorAngle = 45F;
            this.btnFiltreyiTemizle.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnFiltreyiTemizle.OverrideDefault.Border.Rounding = 18;
            this.btnFiltreyiTemizle.OverrideDefault.Border.Width = 1;
            this.btnFiltreyiTemizle.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnFiltreyiTemizle.Size = new System.Drawing.Size(260, 40);
            this.btnFiltreyiTemizle.StateCommon.Back.Color1 = System.Drawing.Color.Gray;
            this.btnFiltreyiTemizle.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.btnFiltreyiTemizle.StateCommon.Back.ColorAngle = 45F;
            this.btnFiltreyiTemizle.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnFiltreyiTemizle.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnFiltreyiTemizle.StateCommon.Border.ColorAngle = 45F;
            this.btnFiltreyiTemizle.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnFiltreyiTemizle.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnFiltreyiTemizle.StateCommon.Border.Rounding = 18;
            this.btnFiltreyiTemizle.StateCommon.Border.Width = 1;
            this.btnFiltreyiTemizle.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnFiltreyiTemizle.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnFiltreyiTemizle.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnFiltreyiTemizle.StatePressed.Back.Color1 = System.Drawing.Color.DarkGray;
            this.btnFiltreyiTemizle.StatePressed.Back.Color2 = System.Drawing.Color.DimGray;
            this.btnFiltreyiTemizle.StatePressed.Back.ColorAngle = 130F;
            this.btnFiltreyiTemizle.StatePressed.Border.Color1 = System.Drawing.Color.DarkGray;
            this.btnFiltreyiTemizle.StatePressed.Border.Color2 = System.Drawing.Color.DimGray;
            this.btnFiltreyiTemizle.StatePressed.Border.ColorAngle = 130F;
            this.btnFiltreyiTemizle.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnFiltreyiTemizle.StatePressed.Border.Rounding = 18;
            this.btnFiltreyiTemizle.StatePressed.Border.Width = 1;
            this.btnFiltreyiTemizle.StateTracking.Back.Color1 = System.Drawing.Color.Gray;
            this.btnFiltreyiTemizle.StateTracking.Back.Color2 = System.Drawing.Color.Gray;
            this.btnFiltreyiTemizle.StateTracking.Back.ColorAngle = 45F;
            this.btnFiltreyiTemizle.StateTracking.Border.Color1 = System.Drawing.Color.DarkGray;
            this.btnFiltreyiTemizle.StateTracking.Border.Color2 = System.Drawing.Color.DimGray;
            this.btnFiltreyiTemizle.StateTracking.Border.ColorAngle = 45F;
            this.btnFiltreyiTemizle.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnFiltreyiTemizle.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnFiltreyiTemizle.StateTracking.Border.Rounding = 18;
            this.btnFiltreyiTemizle.StateTracking.Border.Width = 1;
            this.btnFiltreyiTemizle.TabIndex = 32;
            this.btnFiltreyiTemizle.Values.Text = "Arama Filtresini Temizle";
            // 
            // txtArama
            // 
            this.txtArama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtArama.Location = new System.Drawing.Point(17, 553);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(457, 31);
            this.txtArama.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtArama.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtArama.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtArama.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtArama.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtArama.StateCommon.Border.Rounding = 18;
            this.txtArama.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtArama.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtArama.TabIndex = 31;
            // 
            // productsDataGrid
            // 
            this.productsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.productsDataGrid.Location = new System.Drawing.Point(11, 93);
            this.productsDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.productsDataGrid.Name = "productsDataGrid";
            this.productsDataGrid.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.productsDataGrid.ReadOnly = true;
            this.productsDataGrid.RowHeadersWidth = 51;
            this.productsDataGrid.RowTemplate.Height = 24;
            this.productsDataGrid.Size = new System.Drawing.Size(678, 463);
            this.productsDataGrid.StateCommon.Background.Color1 = System.Drawing.Color.LightGray;
            this.productsDataGrid.StateCommon.Background.Color2 = System.Drawing.Color.LightGray;
            this.productsDataGrid.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.productsDataGrid.StateNormal.DataCell.Back.Color1 = System.Drawing.Color.LightGray;
            this.productsDataGrid.StateNormal.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.productsDataGrid.StateNormal.DataCell.Border.Color2 = System.Drawing.Color.Black;
            this.productsDataGrid.StateNormal.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.productsDataGrid.StateNormal.HeaderColumn.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.productsDataGrid.StateNormal.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.productsDataGrid.StateNormal.HeaderColumn.Border.Color2 = System.Drawing.Color.Black;
            this.productsDataGrid.StateNormal.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.productsDataGrid.StateNormal.HeaderRow.Back.Color1 = System.Drawing.Color.LightGray;
            this.productsDataGrid.StateNormal.HeaderRow.Border.Color1 = System.Drawing.Color.Black;
            this.productsDataGrid.StateNormal.HeaderRow.Border.Color2 = System.Drawing.Color.Black;
            this.productsDataGrid.StateNormal.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.productsDataGrid.TabIndex = 43;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Name";
            this.Column6.HeaderText = "Ürün Adı";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Type";
            this.Column7.HeaderText = "Ürün Türü";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Quantity";
            this.Column8.HeaderText = "Stok Miktarı";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "BuyFee";
            this.Column9.HeaderText = "Alış Fiyatı";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "SellFee";
            this.Column10.HeaderText = "Satış Fiyatı";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 125;
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblUrunAdi.Location = new System.Drawing.Point(17, 12);
            this.lblUrunAdi.Margin = new System.Windows.Forms.Padding(2);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(76, 23);
            this.lblUrunAdi.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblUrunAdi.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.TabIndex = 44;
            this.lblUrunAdi.Values.Text = "Ürün Adı";
            // 
            // lblUrunTuru
            // 
            this.lblUrunTuru.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblUrunTuru.Location = new System.Drawing.Point(155, 10);
            this.lblUrunTuru.Margin = new System.Windows.Forms.Padding(2);
            this.lblUrunTuru.Name = "lblUrunTuru";
            this.lblUrunTuru.Size = new System.Drawing.Size(86, 23);
            this.lblUrunTuru.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblUrunTuru.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunTuru.TabIndex = 45;
            this.lblUrunTuru.Values.Text = "Ürün Türü";
            // 
            // lblStokMiktari
            // 
            this.lblStokMiktari.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblStokMiktari.Location = new System.Drawing.Point(316, 10);
            this.lblStokMiktari.Margin = new System.Windows.Forms.Padding(2);
            this.lblStokMiktari.Name = "lblStokMiktari";
            this.lblStokMiktari.Size = new System.Drawing.Size(98, 23);
            this.lblStokMiktari.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblStokMiktari.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStokMiktari.TabIndex = 46;
            this.lblStokMiktari.Values.Text = "Stok Miktarı";
            // 
            // lblAlisFiyati
            // 
            this.lblAlisFiyati.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblAlisFiyati.Location = new System.Drawing.Point(484, 10);
            this.lblAlisFiyati.Margin = new System.Windows.Forms.Padding(2);
            this.lblAlisFiyati.Name = "lblAlisFiyati";
            this.lblAlisFiyati.Size = new System.Drawing.Size(83, 23);
            this.lblAlisFiyati.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblAlisFiyati.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlisFiyati.TabIndex = 47;
            this.lblAlisFiyati.Values.Text = "Alış Fiyatı";
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblSatisFiyati.Location = new System.Drawing.Point(623, 12);
            this.lblSatisFiyati.Margin = new System.Windows.Forms.Padding(2);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(93, 23);
            this.lblSatisFiyati.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.lblSatisFiyati.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisFiyati.TabIndex = 48;
            this.lblSatisFiyati.Values.Text = "Satış Fiyatı";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(17, 93);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(484, 553);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // txtUrunTuru
            // 
            this.txtUrunTuru.Location = new System.Drawing.Point(155, 42);
            this.txtUrunTuru.Name = "txtUrunTuru";
            this.txtUrunTuru.Size = new System.Drawing.Size(146, 31);
            this.txtUrunTuru.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtUrunTuru.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtUrunTuru.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtUrunTuru.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUrunTuru.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtUrunTuru.StateCommon.Border.Rounding = 18;
            this.txtUrunTuru.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtUrunTuru.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunTuru.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtUrunTuru.TabIndex = 49;
            // 
            // FormStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1186, 612);
            this.Controls.Add(this.txtUrunTuru);
            this.Controls.Add(this.lblSatisFiyati);
            this.Controls.Add(this.lblAlisFiyati);
            this.Controls.Add(this.lblStokMiktari);
            this.Controls.Add(this.lblUrunTuru);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.productsDataGrid);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnFiltreyiTemizle);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.numericStokMiktari);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtAlis);
            this.Controls.Add(this.txtSatis);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(950, 499);
            this.Name = "FormStok";
            this.ShowIcon = false;
            this.Text = "Stok";
            this.Load += new System.EventHandler(this.FormStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numericStokMiktari;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSil;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEkle;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUrunAdi;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAlis;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSatis;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFiltreyiTemizle;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtArama;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView productsDataGrid;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblUrunAdi;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblUrunTuru;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblStokMiktari;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblAlisFiyati;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblSatisFiyati;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUrunTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}