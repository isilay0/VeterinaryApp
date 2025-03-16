namespace VeterinaryApp.Forms
{
    partial class FormMuayene
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMuayene));
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnGuncelle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTarih = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.numericMuayeneUcreti = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.btnFiltreyiTemizle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnEkle = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtDoktorNotu = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtArama = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.comboDoktor = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtIslem = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboDoktor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kryptonDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(0, 117);
            this.kryptonDataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.RowHeadersWidth = 51;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(840, 214);
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
            this.kryptonDataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Veteriner";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "İşlem";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Doktor Notu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ücret";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tarih";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(247, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Yapılan İşlem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Veteriner Seçimi";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(389, 431);
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
            this.btnSil.Size = new System.Drawing.Size(143, 50);
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
            this.btnSil.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
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
            this.btnSil.TabIndex = 8;
            this.btnSil.Values.Text = "Sil";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(389, 373);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.OverrideDefault.Back.Color1 = System.Drawing.Color.Gray;
            this.btnGuncelle.OverrideDefault.Back.Color2 = System.Drawing.Color.DimGray;
            this.btnGuncelle.OverrideDefault.Back.ColorAngle = 45F;
            this.btnGuncelle.OverrideDefault.Border.Color1 = System.Drawing.Color.Gray;
            this.btnGuncelle.OverrideDefault.Border.Color2 = System.Drawing.Color.DimGray;
            this.btnGuncelle.OverrideDefault.Border.ColorAngle = 45F;
            this.btnGuncelle.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGuncelle.OverrideDefault.Border.Rounding = 18;
            this.btnGuncelle.OverrideDefault.Border.Width = 1;
            this.btnGuncelle.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnGuncelle.Size = new System.Drawing.Size(143, 50);
            this.btnGuncelle.StateCommon.Back.Color1 = System.Drawing.Color.Gray;
            this.btnGuncelle.StateCommon.Back.Color2 = System.Drawing.Color.Gray;
            this.btnGuncelle.StateCommon.Back.ColorAngle = 45F;
            this.btnGuncelle.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnGuncelle.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnGuncelle.StateCommon.Border.ColorAngle = 45F;
            this.btnGuncelle.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGuncelle.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnGuncelle.StateCommon.Border.Rounding = 18;
            this.btnGuncelle.StateCommon.Border.Width = 1;
            this.btnGuncelle.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnGuncelle.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnGuncelle.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.StatePressed.Back.Color1 = System.Drawing.Color.DarkGray;
            this.btnGuncelle.StatePressed.Back.Color2 = System.Drawing.Color.DimGray;
            this.btnGuncelle.StatePressed.Back.ColorAngle = 130F;
            this.btnGuncelle.StatePressed.Border.Color1 = System.Drawing.Color.DarkGray;
            this.btnGuncelle.StatePressed.Border.Color2 = System.Drawing.Color.DimGray;
            this.btnGuncelle.StatePressed.Border.ColorAngle = 130F;
            this.btnGuncelle.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGuncelle.StatePressed.Border.Rounding = 18;
            this.btnGuncelle.StatePressed.Border.Width = 1;
            this.btnGuncelle.StateTracking.Back.Color1 = System.Drawing.Color.Gray;
            this.btnGuncelle.StateTracking.Back.Color2 = System.Drawing.Color.Gray;
            this.btnGuncelle.StateTracking.Back.ColorAngle = 45F;
            this.btnGuncelle.StateTracking.Border.Color1 = System.Drawing.Color.DarkGray;
            this.btnGuncelle.StateTracking.Border.Color2 = System.Drawing.Color.DimGray;
            this.btnGuncelle.StateTracking.Border.ColorAngle = 45F;
            this.btnGuncelle.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGuncelle.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnGuncelle.StateTracking.Border.Rounding = 18;
            this.btnGuncelle.StateTracking.Border.Width = 1;
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Values.Text = "Güncelle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(363, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Muayene Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(361, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Muayene Ücreti";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(348, 251);
            this.dtpTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(221, 40);
            this.dtpTarih.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.dtpTarih.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.dtpTarih.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.dtpTarih.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpTarih.StateCommon.Border.Rounding = 18;
            this.dtpTarih.StateCommon.Border.Width = 1;
            this.dtpTarih.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.StateNormal.Content.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.TabIndex = 5;
            this.dtpTarih.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            // 
            // numericMuayeneUcreti
            // 
            this.numericMuayeneUcreti.Location = new System.Drawing.Point(348, 150);
            this.numericMuayeneUcreti.Margin = new System.Windows.Forms.Padding(4);
            this.numericMuayeneUcreti.Name = "numericMuayeneUcreti";
            this.numericMuayeneUcreti.Size = new System.Drawing.Size(221, 38);
            this.numericMuayeneUcreti.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.numericMuayeneUcreti.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.numericMuayeneUcreti.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.numericMuayeneUcreti.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.numericMuayeneUcreti.StateCommon.Border.Rounding = 18;
            this.numericMuayeneUcreti.StateCommon.Border.Width = 1;
            this.numericMuayeneUcreti.TabIndex = 4;
            this.numericMuayeneUcreti.UpDownButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Gallery;
            // 
            // btnFiltreyiTemizle
            // 
            this.btnFiltreyiTemizle.Location = new System.Drawing.Point(436, 42);
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
            this.btnFiltreyiTemizle.TabIndex = 8;
            this.btnFiltreyiTemizle.Values.Text = "Arama Filtresini Temizle";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(389, 315);
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
            this.btnEkle.Size = new System.Drawing.Size(143, 50);
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
            this.btnEkle.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
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
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Values.Text = "Ekle";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 485);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // txtDoktorNotu
            // 
            this.txtDoktorNotu.Location = new System.Drawing.Point(9, 116);
            this.txtDoktorNotu.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoktorNotu.Multiline = true;
            this.txtDoktorNotu.Name = "txtDoktorNotu";
            this.txtDoktorNotu.Size = new System.Drawing.Size(331, 366);
            this.txtDoktorNotu.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtDoktorNotu.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtDoktorNotu.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtDoktorNotu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDoktorNotu.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtDoktorNotu.StateCommon.Border.Rounding = 18;
            this.txtDoktorNotu.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtDoktorNotu.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDoktorNotu.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtDoktorNotu.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(396, 50);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonPanel2.Controls.Add(this.pictureBox3);
            this.kryptonPanel2.Controls.Add(this.pictureBox1);
            this.kryptonPanel2.Controls.Add(this.kryptonDataGridView1);
            this.kryptonPanel2.Controls.Add(this.btnFiltreyiTemizle);
            this.kryptonPanel2.Controls.Add(this.txtArama);
            this.kryptonPanel2.Location = new System.Drawing.Point(599, -3);
            this.kryptonPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(840, 711);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.DimGray;
            this.kryptonPanel2.StateCommon.Color2 = System.Drawing.Color.Gray;
            this.kryptonPanel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(0, 117);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(32, 50);
            this.txtArama.Margin = new System.Windows.Forms.Padding(4);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(357, 36);
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
            this.txtArama.TabIndex = 2;
            // 
            // comboDoktor
            // 
            this.comboDoktor.DropBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonFormClose;
            this.comboDoktor.DropButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Alternate;
            this.comboDoktor.DropDownWidth = 134;
            this.comboDoktor.Location = new System.Drawing.Point(23, 50);
            this.comboDoktor.Margin = new System.Windows.Forms.Padding(4);
            this.comboDoktor.MaxDropDownItems = 10;
            this.comboDoktor.Name = "comboDoktor";
            this.comboDoktor.Size = new System.Drawing.Size(207, 37);
            this.comboDoktor.StateCommon.ComboBox.Back.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.comboDoktor.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.Black;
            this.comboDoktor.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.Black;
            this.comboDoktor.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboDoktor.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.comboDoktor.StateCommon.ComboBox.Border.Rounding = 18;
            this.comboDoktor.StateCommon.ComboBox.Border.Width = 1;
            this.comboDoktor.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Silver;
            this.comboDoktor.StateCommon.DropBack.Color1 = System.Drawing.Color.DarkGray;
            this.comboDoktor.StateCommon.DropBack.Color2 = System.Drawing.Color.Silver;
            this.comboDoktor.StateCommon.Item.Back.Color1 = System.Drawing.Color.White;
            this.comboDoktor.TabIndex = 2;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.label4);
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Controls.Add(this.btnSil);
            this.kryptonPanel1.Controls.Add(this.btnGuncelle);
            this.kryptonPanel1.Controls.Add(this.label3);
            this.kryptonPanel1.Controls.Add(this.label2);
            this.kryptonPanel1.Controls.Add(this.btnEkle);
            this.kryptonPanel1.Controls.Add(this.dtpTarih);
            this.kryptonPanel1.Controls.Add(this.numericMuayeneUcreti);
            this.kryptonPanel1.Controls.Add(this.txtDoktorNotu);
            this.kryptonPanel1.Controls.Add(this.comboDoktor);
            this.kryptonPanel1.Controls.Add(this.txtIslem);
            this.kryptonPanel1.Location = new System.Drawing.Point(3, -3);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonPanel1.Size = new System.Drawing.Size(573, 485);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.DimGray;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.DimGray;
            this.kryptonPanel1.StateCommon.ColorAngle = 45F;
            this.kryptonPanel1.StateCommon.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonPanel1.TabIndex = 6;
            // 
            // txtIslem
            // 
            this.txtIslem.Location = new System.Drawing.Point(237, 50);
            this.txtIslem.Margin = new System.Windows.Forms.Padding(4);
            this.txtIslem.Name = "txtIslem";
            this.txtIslem.Size = new System.Drawing.Size(332, 36);
            this.txtIslem.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.txtIslem.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtIslem.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.txtIslem.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtIslem.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtIslem.StateCommon.Border.Rounding = 18;
            this.txtIslem.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtIslem.StateCommon.Content.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIslem.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtIslem.TabIndex = 1;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.White;
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 16;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // FormMuayene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 705);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.MinimumSize = new System.Drawing.Size(1461, 752);
            this.Name = "FormMuayene";
            this.ShowIcon = false;
            this.Text = "Muayene";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboDoktor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSil;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGuncelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpTarih;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown numericMuayeneUcreti;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnFiltreyiTemizle;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnEkle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDoktorNotu;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtArama;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboDoktor;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtIslem;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}