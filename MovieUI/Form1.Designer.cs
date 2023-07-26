
namespace MovieUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgKategori = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKtId = new System.Windows.Forms.TextBox();
            this.txtKtAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdAktif = new System.Windows.Forms.RadioButton();
            this.rdPasif = new System.Windows.Forms.RadioButton();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFilmGuncelle = new System.Windows.Forms.Button();
            this.btnFilmSil = new System.Windows.Forms.Button();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.btnFilmListele = new System.Windows.Forms.Button();
            this.rdFilmPasif = new System.Windows.Forms.RadioButton();
            this.rdFilmAktif = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFilmId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgMovie = new System.Windows.Forms.DataGridView();
            this.txtFilmSuresi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFilmImdb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFilmKategori = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblKategoriSayisi = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKategori)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMovie)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 807);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.btnListele);
            this.groupBox1.Controls.Add(this.rdPasif);
            this.groupBox1.Controls.Add(this.rdAktif);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKtAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtgKategori);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori İşlemleri";
            // 
            // dtgKategori
            // 
            this.dtgKategori.AllowUserToAddRows = false;
            this.dtgKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKategori.Location = new System.Drawing.Point(6, 19);
            this.dtgKategori.Name = "dtgKategori";
            this.dtgKategori.ReadOnly = true;
            this.dtgKategori.Size = new System.Drawing.Size(360, 150);
            this.dtgKategori.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori Id";
            // 
            // txtKtId
            // 
            this.txtKtId.Location = new System.Drawing.Point(110, 191);
            this.txtKtId.Name = "txtKtId";
            this.txtKtId.Size = new System.Drawing.Size(256, 20);
            this.txtKtId.TabIndex = 2;
            // 
            // txtKtAdi
            // 
            this.txtKtAdi.Location = new System.Drawing.Point(110, 217);
            this.txtKtAdi.Name = "txtKtAdi";
            this.txtKtAdi.Size = new System.Drawing.Size(256, 20);
            this.txtKtAdi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Durumu";
            // 
            // rdAktif
            // 
            this.rdAktif.AutoSize = true;
            this.rdAktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdAktif.Location = new System.Drawing.Point(110, 246);
            this.rdAktif.Name = "rdAktif";
            this.rdAktif.Size = new System.Drawing.Size(59, 24);
            this.rdAktif.TabIndex = 6;
            this.rdAktif.TabStop = true;
            this.rdAktif.Text = "Aktif";
            this.rdAktif.UseVisualStyleBackColor = true;
            // 
            // rdPasif
            // 
            this.rdPasif.AutoSize = true;
            this.rdPasif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdPasif.Location = new System.Drawing.Point(175, 246);
            this.rdPasif.Name = "rdPasif";
            this.rdPasif.Size = new System.Drawing.Size(62, 24);
            this.rdPasif.TabIndex = 7;
            this.rdPasif.TabStop = true;
            this.rdPasif.Text = "Pasif";
            this.rdPasif.UseVisualStyleBackColor = true;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(110, 276);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(127, 23);
            this.btnListele.TabIndex = 8;
            this.btnListele.Text = "Kategori Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(239, 276);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(127, 23);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Kategori Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(239, 305);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(127, 23);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Kategori Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(110, 305);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(127, 23);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Kategori Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFilmKategori);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtFilmSuresi);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtFilmImdb);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnFilmGuncelle);
            this.groupBox2.Controls.Add(this.btnFilmSil);
            this.groupBox2.Controls.Add(this.btnFilmEkle);
            this.groupBox2.Controls.Add(this.btnFilmListele);
            this.groupBox2.Controls.Add(this.rdFilmPasif);
            this.groupBox2.Controls.Add(this.rdFilmAktif);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtFilmAdi);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtFilmId);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtgMovie);
            this.groupBox2.Location = new System.Drawing.Point(390, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(826, 339);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Film İşlemleri";
            // 
            // btnFilmGuncelle
            // 
            this.btnFilmGuncelle.Location = new System.Drawing.Point(239, 305);
            this.btnFilmGuncelle.Name = "btnFilmGuncelle";
            this.btnFilmGuncelle.Size = new System.Drawing.Size(127, 23);
            this.btnFilmGuncelle.TabIndex = 12;
            this.btnFilmGuncelle.Text = "Film Güncelle";
            this.btnFilmGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnFilmSil
            // 
            this.btnFilmSil.Location = new System.Drawing.Point(110, 305);
            this.btnFilmSil.Name = "btnFilmSil";
            this.btnFilmSil.Size = new System.Drawing.Size(127, 23);
            this.btnFilmSil.TabIndex = 11;
            this.btnFilmSil.Text = "Film Sil";
            this.btnFilmSil.UseVisualStyleBackColor = true;
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.Location = new System.Drawing.Point(239, 276);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(127, 23);
            this.btnFilmEkle.TabIndex = 10;
            this.btnFilmEkle.Text = "Film Ekle";
            this.btnFilmEkle.UseVisualStyleBackColor = true;
            // 
            // btnFilmListele
            // 
            this.btnFilmListele.Location = new System.Drawing.Point(110, 276);
            this.btnFilmListele.Name = "btnFilmListele";
            this.btnFilmListele.Size = new System.Drawing.Size(127, 23);
            this.btnFilmListele.TabIndex = 8;
            this.btnFilmListele.Text = "Film Listele";
            this.btnFilmListele.UseVisualStyleBackColor = true;
            // 
            // rdFilmPasif
            // 
            this.rdFilmPasif.AutoSize = true;
            this.rdFilmPasif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdFilmPasif.Location = new System.Drawing.Point(175, 246);
            this.rdFilmPasif.Name = "rdFilmPasif";
            this.rdFilmPasif.Size = new System.Drawing.Size(62, 24);
            this.rdFilmPasif.TabIndex = 7;
            this.rdFilmPasif.TabStop = true;
            this.rdFilmPasif.Text = "Pasif";
            this.rdFilmPasif.UseVisualStyleBackColor = true;
            // 
            // rdFilmAktif
            // 
            this.rdFilmAktif.AutoSize = true;
            this.rdFilmAktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdFilmAktif.Location = new System.Drawing.Point(110, 246);
            this.rdFilmAktif.Name = "rdFilmAktif";
            this.rdFilmAktif.Size = new System.Drawing.Size(59, 24);
            this.rdFilmAktif.TabIndex = 6;
            this.rdFilmAktif.TabStop = true;
            this.rdFilmAktif.Text = "Aktif";
            this.rdFilmAktif.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Durumu";
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.Location = new System.Drawing.Point(110, 217);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(256, 20);
            this.txtFilmAdi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(38, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Film Adı";
            // 
            // txtFilmId
            // 
            this.txtFilmId.Location = new System.Drawing.Point(110, 191);
            this.txtFilmId.Name = "txtFilmId";
            this.txtFilmId.Size = new System.Drawing.Size(256, 20);
            this.txtFilmId.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(47, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Film Id";
            // 
            // dtgMovie
            // 
            this.dtgMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMovie.Location = new System.Drawing.Point(6, 19);
            this.dtgMovie.Name = "dtgMovie";
            this.dtgMovie.Size = new System.Drawing.Size(810, 150);
            this.dtgMovie.TabIndex = 0;
            // 
            // txtFilmSuresi
            // 
            this.txtFilmSuresi.Location = new System.Drawing.Point(493, 217);
            this.txtFilmSuresi.Name = "txtFilmSuresi";
            this.txtFilmSuresi.Size = new System.Drawing.Size(256, 20);
            this.txtFilmSuresi.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(400, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Film Süresi";
            // 
            // txtFilmImdb
            // 
            this.txtFilmImdb.Location = new System.Drawing.Point(493, 191);
            this.txtFilmImdb.Name = "txtFilmImdb";
            this.txtFilmImdb.Size = new System.Drawing.Size(256, 20);
            this.txtFilmImdb.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(393, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "IMDB Puanı";
            // 
            // txtFilmKategori
            // 
            this.txtFilmKategori.Location = new System.Drawing.Point(493, 248);
            this.txtFilmKategori.Name = "txtFilmKategori";
            this.txtFilmKategori.Size = new System.Drawing.Size(256, 20);
            this.txtFilmKategori.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(419, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Kategori";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 357);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1204, 438);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.label20, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label19, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label17, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label16, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label14, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label15, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblKategoriSayisi, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1198, 272);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(133, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Kategori Sayısı";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(549, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "Film Sayısı";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(928, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 24);
            this.label12.TabIndex = 2;
            this.label12.Text = "En Başarılı Film";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(531, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 24);
            this.label14.TabIndex = 4;
            this.label14.Text = "Ortalama Puan";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(932, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 24);
            this.label15.TabIndex = 5;
            this.label15.Text = "Kategori Sayısı";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(113, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(172, 24);
            this.label13.TabIndex = 6;
            this.label13.Text = "Bilim Kurgu Filmleri";
            // 
            // lblKategoriSayisi
            // 
            this.lblKategoriSayisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKategoriSayisi.AutoSize = true;
            this.lblKategoriSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategoriSayisi.Location = new System.Drawing.Point(185, 79);
            this.lblKategoriSayisi.Name = "lblKategoriSayisi";
            this.lblKategoriSayisi.Size = new System.Drawing.Size(29, 31);
            this.lblKategoriSayisi.TabIndex = 7;
            this.lblKategoriSayisi.Text = "0";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(584, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 31);
            this.label16.TabIndex = 8;
            this.label16.Text = "0";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(983, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 31);
            this.label17.TabIndex = 9;
            this.label17.Text = "0";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(185, 215);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 31);
            this.label18.TabIndex = 10;
            this.label18.Text = "0";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(584, 215);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 31);
            this.label19.TabIndex = 11;
            this.label19.Text = "0";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(983, 215);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 31);
            this.label20.TabIndex = 12;
            this.label20.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 807);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKategori)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMovie)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFilmKategori;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFilmSuresi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFilmImdb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFilmGuncelle;
        private System.Windows.Forms.Button btnFilmSil;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.Button btnFilmListele;
        private System.Windows.Forms.RadioButton rdFilmPasif;
        private System.Windows.Forms.RadioButton rdFilmAktif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFilmId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgMovie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.RadioButton rdPasif;
        private System.Windows.Forms.RadioButton rdAktif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKtAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgKategori;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblKategoriSayisi;
    }
}

