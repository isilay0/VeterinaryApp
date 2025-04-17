namespace VeterinaryApp.Forms
{
    partial class FormHasta
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
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonHeader2 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.DataGridViewHayvanBilgi = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.DataGridViewMusteriBilgi = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel4 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel3 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtHayvanArat = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonPanel5 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.txtMusteriArat = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewHayvanBilgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMusteriBilgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).BeginInit();
            this.kryptonPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel14.Location = new System.Drawing.Point(16, 46);
            this.kryptonLabel14.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(90, 20);
            this.kryptonLabel14.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel14.TabIndex = 30;
            this.kryptonLabel14.Values.Text = "Müşteri Arat : ";
            // 
            // kryptonHeader2
            // 
            this.kryptonHeader2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kryptonHeader2.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonHeader2.Name = "kryptonHeader2";
            this.kryptonHeader2.Size = new System.Drawing.Size(860, 36);
            this.kryptonHeader2.StateCommon.Back.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.kryptonHeader2.StateCommon.Back.Color2 = System.Drawing.SystemColors.ScrollBar;
            this.kryptonHeader2.StateCommon.Border.Color1 = System.Drawing.SystemColors.ControlDarkDark;
            this.kryptonHeader2.StateCommon.Border.Color2 = System.Drawing.SystemColors.ControlDarkDark;
            this.kryptonHeader2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonHeader2.TabIndex = 15;
            this.kryptonHeader2.Values.Description = "";
            this.kryptonHeader2.Values.Heading = "Müşteri Bilgileri";
            this.kryptonHeader2.Values.Image = global::VeterinaryApp.Properties.Resources.person_icon1;
            // 
            // DataGridViewHayvanBilgi
            // 
            this.DataGridViewHayvanBilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewHayvanBilgi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.DataGridViewHayvanBilgi.Location = new System.Drawing.Point(9, 89);
            this.DataGridViewHayvanBilgi.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridViewHayvanBilgi.Name = "DataGridViewHayvanBilgi";
            this.DataGridViewHayvanBilgi.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.DataGridViewHayvanBilgi.ReadOnly = true;
            this.DataGridViewHayvanBilgi.RowHeadersWidth = 51;
            this.DataGridViewHayvanBilgi.RowTemplate.Height = 24;
            this.DataGridViewHayvanBilgi.Size = new System.Drawing.Size(1103, 292);
            this.DataGridViewHayvanBilgi.StateNormal.DataCell.Back.Color1 = System.Drawing.Color.LightGray;
            this.DataGridViewHayvanBilgi.StateNormal.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.DataGridViewHayvanBilgi.StateNormal.DataCell.Border.Color2 = System.Drawing.Color.Black;
            this.DataGridViewHayvanBilgi.StateNormal.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridViewHayvanBilgi.StateNormal.HeaderColumn.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.DataGridViewHayvanBilgi.StateNormal.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.DataGridViewHayvanBilgi.StateNormal.HeaderColumn.Border.Color2 = System.Drawing.Color.Black;
            this.DataGridViewHayvanBilgi.StateNormal.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridViewHayvanBilgi.StateNormal.HeaderRow.Back.Color1 = System.Drawing.Color.LightGray;
            this.DataGridViewHayvanBilgi.StateNormal.HeaderRow.Border.Color1 = System.Drawing.Color.Black;
            this.DataGridViewHayvanBilgi.StateNormal.HeaderRow.Border.Color2 = System.Drawing.Color.Black;
            this.DataGridViewHayvanBilgi.StateNormal.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridViewHayvanBilgi.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ADI";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "CİNSİ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "YAŞI";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "CİNSİYETİ";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "ŞİKAYETİ";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "BAKAN DOKTOR";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(16, 44);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(89, 20);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.TabIndex = 31;
            this.kryptonLabel1.Values.Text = "Hayvan Arat : ";
            // 
            // DataGridViewMusteriBilgi
            // 
            this.DataGridViewMusteriBilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewMusteriBilgi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DataGridViewMusteriBilgi.Location = new System.Drawing.Point(9, 93);
            this.DataGridViewMusteriBilgi.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridViewMusteriBilgi.Name = "DataGridViewMusteriBilgi";
            this.DataGridViewMusteriBilgi.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.DataGridViewMusteriBilgi.ReadOnly = true;
            this.DataGridViewMusteriBilgi.RowHeadersWidth = 51;
            this.DataGridViewMusteriBilgi.RowTemplate.Height = 24;
            this.DataGridViewMusteriBilgi.Size = new System.Drawing.Size(1086, 292);
            this.DataGridViewMusteriBilgi.StateNormal.DataCell.Back.Color1 = System.Drawing.Color.LightGray;
            this.DataGridViewMusteriBilgi.StateNormal.DataCell.Border.Color1 = System.Drawing.Color.Black;
            this.DataGridViewMusteriBilgi.StateNormal.DataCell.Border.Color2 = System.Drawing.Color.Black;
            this.DataGridViewMusteriBilgi.StateNormal.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridViewMusteriBilgi.StateNormal.HeaderColumn.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.DataGridViewMusteriBilgi.StateNormal.HeaderColumn.Border.Color1 = System.Drawing.Color.Black;
            this.DataGridViewMusteriBilgi.StateNormal.HeaderColumn.Border.Color2 = System.Drawing.Color.Black;
            this.DataGridViewMusteriBilgi.StateNormal.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridViewMusteriBilgi.StateNormal.HeaderRow.Back.Color1 = System.Drawing.Color.LightGray;
            this.DataGridViewMusteriBilgi.StateNormal.HeaderRow.Border.Color1 = System.Drawing.Color.Black;
            this.DataGridViewMusteriBilgi.StateNormal.HeaderRow.Border.Color2 = System.Drawing.Color.Black;
            this.DataGridViewMusteriBilgi.StateNormal.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridViewMusteriBilgi.TabIndex = 32;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "AD";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Surname";
            this.Column2.HeaderText = "SOYAD";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Address";
            this.Column3.HeaderText = "ADRES";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PhoneNumber";
            this.Column4.HeaderText = "TEL NO";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "City";
            this.Column5.HeaderText = "İL";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "District";
            this.Column6.HeaderText = "İLÇE";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeader1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(860, 36);
            this.kryptonHeader1.StateCommon.Back.Color1 = System.Drawing.SystemColors.ScrollBar;
            this.kryptonHeader1.StateCommon.Back.Color2 = System.Drawing.SystemColors.ScrollBar;
            this.kryptonHeader1.StateCommon.Border.Color1 = System.Drawing.SystemColors.ControlDarkDark;
            this.kryptonHeader1.StateCommon.Border.Color2 = System.Drawing.SystemColors.ControlDarkDark;
            this.kryptonHeader1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonHeader1.TabIndex = 1;
            this.kryptonHeader1.Values.Description = "";
            this.kryptonHeader1.Values.Heading = "Hayvan Bilgileri";
            this.kryptonHeader1.Values.Image = global::VeterinaryApp.Properties.Resources.cat_icon;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(860, 526);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.SystemColors.Control;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.SystemColors.Control;
            this.kryptonPanel1.TabIndex = 4;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.AutoSize = true;
            this.kryptonPanel2.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonPanel2.Size = new System.Drawing.Size(860, 526);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel4.Controls.Add(this.kryptonPanel5);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(860, 526);
            this.kryptonPanel4.TabIndex = 3;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.txtHayvanArat);
            this.kryptonPanel3.Controls.Add(this.DataGridViewHayvanBilgi);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel3.Controls.Add(this.kryptonHeader1);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 355);
            this.kryptonPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonPanel3.Size = new System.Drawing.Size(860, 171);
            this.kryptonPanel3.TabIndex = 1;
            // 
            // txtHayvanArat
            // 
            this.txtHayvanArat.Location = new System.Drawing.Point(104, 44);
            this.txtHayvanArat.Margin = new System.Windows.Forms.Padding(2);
            this.txtHayvanArat.Name = "txtHayvanArat";
            this.txtHayvanArat.Size = new System.Drawing.Size(174, 33);
            this.txtHayvanArat.StateCommon.Back.Color1 = System.Drawing.Color.LightGray;
            this.txtHayvanArat.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtHayvanArat.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtHayvanArat.StateCommon.Border.Rounding = 15;
            this.txtHayvanArat.TabIndex = 35;
            this.txtHayvanArat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHayvanArat_KeyPress);
            // 
            // kryptonPanel5
            // 
            this.kryptonPanel5.Controls.Add(this.txtMusteriArat);
            this.kryptonPanel5.Controls.Add(this.DataGridViewMusteriBilgi);
            this.kryptonPanel5.Controls.Add(this.kryptonLabel14);
            this.kryptonPanel5.Controls.Add(this.kryptonHeader2);
            this.kryptonPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel5.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.kryptonPanel5.Name = "kryptonPanel5";
            this.kryptonPanel5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonPanel5.Size = new System.Drawing.Size(860, 355);
            this.kryptonPanel5.TabIndex = 0;
            // 
            // txtMusteriArat
            // 
            this.txtMusteriArat.Location = new System.Drawing.Point(104, 46);
            this.txtMusteriArat.Margin = new System.Windows.Forms.Padding(2);
            this.txtMusteriArat.Name = "txtMusteriArat";
            this.txtMusteriArat.Size = new System.Drawing.Size(174, 33);
            this.txtMusteriArat.StateCommon.Back.Color1 = System.Drawing.Color.LightGray;
            this.txtMusteriArat.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.txtMusteriArat.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMusteriArat.StateCommon.Border.Rounding = 15;
            this.txtMusteriArat.TabIndex = 34;
            this.txtMusteriArat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMusteriArat_KeyPress);
            // 
            // FormHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 526);
            this.Controls.Add(this.kryptonPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormHasta";
            this.Text = "Bilgiler";
            this.Load += new System.EventHandler(this.FormHasta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewHayvanBilgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMusteriBilgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel5)).EndInit();
            this.kryptonPanel5.ResumeLayout(false);
            this.kryptonPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DataGridViewHayvanBilgi;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DataGridViewMusteriBilgi;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtHayvanArat;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMusteriArat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}