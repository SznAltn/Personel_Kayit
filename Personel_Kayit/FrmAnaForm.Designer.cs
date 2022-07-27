namespace Personel_Kayit
{
    partial class FrmAnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Mskmaas = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Txtmeslek = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cmbsehir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtad = new System.Windows.Forms.TextBox();
            this.Txtsoyad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btngrafikler = new System.Windows.Forms.Button();
            this.Btnistatistik = new System.Windows.Forms.Button();
            this.Btntemizle = new System.Windows.Forms.Button();
            this.Btnguncelle = new System.Windows.Forms.Button();
            this.Btnsil = new System.Windows.Forms.Button();
            this.Btnkaydet = new System.Windows.Forms.Button();
            this.Btnlistele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabaniDataSet = new Personel_Kayit.PersonelVeriTabaniDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbl_PersonelTableAdapter = new Personel_Kayit.PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Mskmaas);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.Txtmeslek);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Cmbsehir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txtid);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txtad);
            this.groupBox1.Controls.Add(this.Txtsoyad);
            this.groupBox1.Location = new System.Drawing.Point(2, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(182, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // Mskmaas
            // 
            this.Mskmaas.Location = new System.Drawing.Point(82, 117);
            this.Mskmaas.Margin = new System.Windows.Forms.Padding(2);
            this.Mskmaas.Mask = "0000";
            this.Mskmaas.Name = "Mskmaas";
            this.Mskmaas.Size = new System.Drawing.Size(97, 23);
            this.Mskmaas.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "PerMaas:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(129, 139);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 19);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bekar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Txtmeslek
            // 
            this.Txtmeslek.Location = new System.Drawing.Point(84, 160);
            this.Txtmeslek.Margin = new System.Windows.Forms.Padding(2);
            this.Txtmeslek.Name = "Txtmeslek";
            this.Txtmeslek.Size = new System.Drawing.Size(97, 23);
            this.Txtmeslek.TabIndex = 9;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(82, 139);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 19);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evli";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "PerMeslek:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "PerSehir:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "PerDurum:";
            // 
            // Cmbsehir
            // 
            this.Cmbsehir.Location = new System.Drawing.Point(82, 92);
            this.Cmbsehir.Margin = new System.Windows.Forms.Padding(2);
            this.Cmbsehir.Name = "Cmbsehir";
            this.Cmbsehir.Size = new System.Drawing.Size(97, 23);
            this.Cmbsehir.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "PerSoyad:";
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(82, 20);
            this.Txtid.Margin = new System.Windows.Forms.Padding(2);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(97, 23);
            this.Txtid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "PerAd:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Perid:";
            // 
            // Txtad
            // 
            this.Txtad.Location = new System.Drawing.Point(82, 44);
            this.Txtad.Margin = new System.Windows.Forms.Padding(2);
            this.Txtad.Name = "Txtad";
            this.Txtad.Size = new System.Drawing.Size(97, 23);
            this.Txtad.TabIndex = 6;
            // 
            // Txtsoyad
            // 
            this.Txtsoyad.Location = new System.Drawing.Point(82, 68);
            this.Txtsoyad.Margin = new System.Windows.Forms.Padding(2);
            this.Txtsoyad.Name = "Txtsoyad";
            this.Txtsoyad.Size = new System.Drawing.Size(97, 23);
            this.Txtsoyad.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.Btngrafikler);
            this.groupBox2.Controls.Add(this.Btnistatistik);
            this.groupBox2.Controls.Add(this.Btntemizle);
            this.groupBox2.Controls.Add(this.Btnguncelle);
            this.groupBox2.Controls.Add(this.Btnsil);
            this.groupBox2.Controls.Add(this.Btnkaydet);
            this.groupBox2.Controls.Add(this.Btnlistele);
            this.groupBox2.Location = new System.Drawing.Point(186, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(195, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // Btngrafikler
            // 
            this.Btngrafikler.Location = new System.Drawing.Point(60, 133);
            this.Btngrafikler.Margin = new System.Windows.Forms.Padding(2);
            this.Btngrafikler.Name = "Btngrafikler";
            this.Btngrafikler.Size = new System.Drawing.Size(68, 25);
            this.Btngrafikler.TabIndex = 6;
            this.Btngrafikler.Text = "Grafikler";
            this.Btngrafikler.UseVisualStyleBackColor = true;
            this.Btngrafikler.Click += new System.EventHandler(this.Btngrafikler_Click);
            // 
            // Btnistatistik
            // 
            this.Btnistatistik.Location = new System.Drawing.Point(60, 109);
            this.Btnistatistik.Margin = new System.Windows.Forms.Padding(2);
            this.Btnistatistik.Name = "Btnistatistik";
            this.Btnistatistik.Size = new System.Drawing.Size(68, 21);
            this.Btnistatistik.TabIndex = 5;
            this.Btnistatistik.Text = "İstatistik";
            this.Btnistatistik.UseVisualStyleBackColor = true;
            this.Btnistatistik.Click += new System.EventHandler(this.Btnistatistik_Click);
            // 
            // Btntemizle
            // 
            this.Btntemizle.Location = new System.Drawing.Point(60, 84);
            this.Btntemizle.Margin = new System.Windows.Forms.Padding(2);
            this.Btntemizle.Name = "Btntemizle";
            this.Btntemizle.Size = new System.Drawing.Size(68, 21);
            this.Btntemizle.TabIndex = 4;
            this.Btntemizle.Text = "Temizle";
            this.Btntemizle.UseVisualStyleBackColor = true;
            this.Btntemizle.Click += new System.EventHandler(this.Btntemizle_Click);
            // 
            // Btnguncelle
            // 
            this.Btnguncelle.Location = new System.Drawing.Point(60, 60);
            this.Btnguncelle.Margin = new System.Windows.Forms.Padding(2);
            this.Btnguncelle.Name = "Btnguncelle";
            this.Btnguncelle.Size = new System.Drawing.Size(68, 20);
            this.Btnguncelle.TabIndex = 3;
            this.Btnguncelle.Text = "Güncelle";
            this.Btnguncelle.UseVisualStyleBackColor = true;
            this.Btnguncelle.Click += new System.EventHandler(this.Btnguncelle_Click);
            // 
            // Btnsil
            // 
            this.Btnsil.Location = new System.Drawing.Point(123, 38);
            this.Btnsil.Margin = new System.Windows.Forms.Padding(2);
            this.Btnsil.Name = "Btnsil";
            this.Btnsil.Size = new System.Drawing.Size(68, 20);
            this.Btnsil.TabIndex = 2;
            this.Btnsil.Text = "Sil";
            this.Btnsil.UseVisualStyleBackColor = true;
            this.Btnsil.Click += new System.EventHandler(this.Btnsil_Click);
            // 
            // Btnkaydet
            // 
            this.Btnkaydet.Location = new System.Drawing.Point(4, 38);
            this.Btnkaydet.Margin = new System.Windows.Forms.Padding(2);
            this.Btnkaydet.Name = "Btnkaydet";
            this.Btnkaydet.Size = new System.Drawing.Size(68, 18);
            this.Btnkaydet.TabIndex = 1;
            this.Btnkaydet.Text = "Kaydet";
            this.Btnkaydet.UseVisualStyleBackColor = true;
            this.Btnkaydet.Click += new System.EventHandler(this.Btnkaydet_Click);
            // 
            // Btnlistele
            // 
            this.Btnlistele.Location = new System.Drawing.Point(60, 15);
            this.Btnlistele.Margin = new System.Windows.Forms.Padding(2);
            this.Btnlistele.Name = "Btnlistele";
            this.Btnlistele.Size = new System.Drawing.Size(68, 20);
            this.Btnlistele.TabIndex = 0;
            this.Btnlistele.Text = "Listele";
            this.Btnlistele.UseVisualStyleBackColor = true;
            this.Btnlistele.Click += new System.EventHandler(this.Btnlistele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(2, 213);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(528, 173);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 153);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelVeriTabaniDataSet;
            // 
            // personelVeriTabaniDataSet
            // 
            this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
            this.personelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(385, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(574, 119);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "label8";
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Raporlar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(721, 421);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "FrmAnaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox Mskmaas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox Txtmeslek;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Cmbsehir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtad;
        private System.Windows.Forms.TextBox Txtsoyad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btngrafikler;
        private System.Windows.Forms.Button Btnistatistik;
        private System.Windows.Forms.Button Btntemizle;
        private System.Windows.Forms.Button Btnguncelle;
        private System.Windows.Forms.Button Btnsil;
        private System.Windows.Forms.Button Btnkaydet;
        private System.Windows.Forms.Button Btnlistele;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PersonelVeriTabaniDataSet personelVeriTabaniDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

