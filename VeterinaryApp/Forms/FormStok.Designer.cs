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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.numericStokMiktari = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.comboUrunTuru = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnSil = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEkle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtUrunAdi = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtAlis = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtSatis = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnFiltreyiTemizle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtArama = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboUrunTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(640, 577);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // numericStokMiktari
            // 
            this.numericStokMiktari.Location = new System.Drawing.Point(422, 48);
            this.numericStokMiktari.Margin = new System.Windows.Forms.Padding(4);
            this.numericStokMiktari.Name = "numericStokMiktari";
            this.numericStokMiktari.Size = new System.Drawing.Size(211, 38);
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
            // comboUrunTuru
            // 
            this.comboUrunTuru.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonFormClose;
            this.comboUrunTuru.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.comboUrunTuru.DropDownWidth = 134;
            this.comboUrunTuru.Location = new System.Drawing.Point(207, 48);
            this.comboUrunTuru.Margin = new System.Windows.Forms.Padding(4);
            this.comboUrunTuru.MaxDropDownItems = 10;
            this.comboUrunTuru.Name = "comboUrunTuru";
            this.comboUrunTuru.Size = new System.Drawing.Size(207, 37);
            this.comboUrunTuru.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.comboUrunTuru.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Black;
            this.comboUrunTuru.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Black;
            this.comboUrunTuru.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboUrunTuru.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.comboUrunTuru.StateCommon.ComboBox.Border.Rounding = 18;
            this.comboUrunTuru.StateCommon.ComboBox.Border.Width = 1;
            this.comboUrunTuru.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Silver;
            this.comboUrunTuru.StateCommon.DropBack.Color1 = System.Drawing.Color.DarkGray;
            this.comboUrunTuru.StateCommon.DropBack.Color2 = System.Drawing.Color.Silver;
            this.comboUrunTuru.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.comboUrunTuru.TabIndex = 38;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(1226, 48);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnSil.Size = new System.Drawing.Size(183, 49);
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
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(1022, 48);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnEkle.Size = new System.Drawing.Size(183, 49);
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
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(23, 50);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(176, 36);
            this.txtUrunAdi.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtUrunAdi.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtUrunAdi.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtUrunAdi.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUrunAdi.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtUrunAdi.StateCommon.Border.Rounding = 18;
            this.txtUrunAdi.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtUrunAdi.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdi.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtUrunAdi.TabIndex = 35;
            // 
            // txtAlis
            // 
            this.txtAlis.Location = new System.Drawing.Point(646, 48);
            this.txtAlis.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlis.Name = "txtAlis";
            this.txtAlis.Size = new System.Drawing.Size(164, 36);
            this.txtAlis.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtAlis.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtAlis.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtAlis.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAlis.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtAlis.StateCommon.Border.Rounding = 18;
            this.txtAlis.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtAlis.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlis.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtAlis.TabIndex = 34;
            // 
            // txtSatis
            // 
            this.txtSatis.Location = new System.Drawing.Point(831, 48);
            this.txtSatis.Margin = new System.Windows.Forms.Padding(4);
            this.txtSatis.Name = "txtSatis";
            this.txtSatis.Size = new System.Drawing.Size(167, 36);
            this.txtSatis.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtSatis.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtSatis.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtSatis.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSatis.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtSatis.StateCommon.Border.Rounding = 18;
            this.txtSatis.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtSatis.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatis.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtSatis.TabIndex = 33;
            // 
            // btnFiltreyiTemizle
            // 
            this.btnFiltreyiTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFiltreyiTemizle.Location = new System.Drawing.Point(686, 577);
            this.btnFiltreyiTemizle.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnFiltreyiTemizle.Size = new System.Drawing.Size(347, 49);
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
            this.txtArama.Location = new System.Drawing.Point(23, 577);
            this.txtArama.Margin = new System.Windows.Forms.Padding(4);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(609, 36);
            this.txtArama.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtArama.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtArama.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtArama.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtArama.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtArama.StateCommon.Border.Rounding = 18;
            this.txtArama.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtArama.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtArama.TabIndex = 31;
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kryptonDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(13, 124);
            this.kryptonDataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowHeadersWidth = 51;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(1235, 419);
            this.kryptonDataGridView1.StateCommon.Background.Color1 = System.Drawing.Color.DimGray;
            this.kryptonDataGridView1.StateCommon.Background.Color2 = System.Drawing.Color.DimGray;
            this.kryptonDataGridView1.StateCommon.Background.ColorAngle = 45F;
            this.kryptonDataGridView1.StateCommon.Background.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonDataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonDataGridView1.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.DimGray;
            this.kryptonDataGridView1.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.DimGray;
            this.kryptonDataGridView1.StateCommon.DataCell.Back.ColorAngle = 45F;
            this.kryptonDataGridView1.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonDataGridView1.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.WhiteSmoke;
            this.kryptonDataGridView1.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.DarkGray;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.DarkGray;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.ColorAngle = 45F;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.Rounding = 4;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.WhiteSmoke;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.WhiteSmoke;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.kryptonDataGridView1.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.Gray;
            this.kryptonDataGridView1.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.Gray;
            this.kryptonDataGridView1.StateCommon.HeaderRow.Back.ColorAngle = 45F;
            this.kryptonDataGridView1.StateCommon.HeaderRow.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonDataGridView1.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.StateCommon.HeaderRow.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.TabIndex = 30;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ürün Adı";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ürün Türü";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Stok Miktarı";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Alış Fiyatı";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Satış Fiyatı";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(13, 124);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // FormStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1582, 753);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Controls.Add(this.btnFiltreyiTemizle);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.numericStokMiktari);
            this.Controls.Add(this.comboUrunTuru);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtAlis);
            this.Controls.Add(this.txtSatis);
            this.MinimumSize = new System.Drawing.Size(1261, 605);
            this.Name = "FormStok";
            this.ShowIcon = false;
            this.Text = "Stok";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboUrunTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numericStokMiktari;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboUrunTuru;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSil;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEkle;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUrunAdi;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAlis;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSatis;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFiltreyiTemizle;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtArama;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}