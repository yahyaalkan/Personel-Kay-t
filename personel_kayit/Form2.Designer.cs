namespace personel_kayit
{
    partial class Form2
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
            btnİstatistik = new Button();
            maskedTxtMaaş = new MaskedTextBox();
            label7 = new Label();
            label6 = new Label();
            RadioBekar = new RadioButton();
            RadioEvli = new RadioButton();
            comboSehir = new ComboBox();
            label5 = new Label();
            btnListele = new Button();
            btnGüncelle = new Button();
            btnSil = new Button();
            btnKaydet = new Button();
            TxtSoyad = new TextBox();
            label4 = new Label();
            label2 = new Label();
            btnTemizle = new Button();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            TxtPerId = new TextBox();
            GroupBoxİslem = new GroupBox();
            btnGrafik = new Button();
            label1 = new Label();
            TxtAd = new TextBox();
            TxtMeslek = new TextBox();
            GroupBoxKayit = new GroupBox();
            GroupBoxPersonel = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            GroupBoxİslem.SuspendLayout();
            GroupBoxKayit.SuspendLayout();
            GroupBoxPersonel.SuspendLayout();
            SuspendLayout();
            // 
            // btnİstatistik
            // 
            btnİstatistik.Location = new Point(104, 220);
            btnİstatistik.Name = "btnİstatistik";
            btnİstatistik.Size = new Size(101, 34);
            btnİstatistik.TabIndex = 14;
            btnİstatistik.Text = "İstatistik";
            btnİstatistik.UseVisualStyleBackColor = true;
            // 
            // maskedTxtMaaş
            // 
            maskedTxtMaaş.Location = new Point(104, 236);
            maskedTxtMaaş.Mask = "0000";
            maskedTxtMaaş.Name = "maskedTxtMaaş";
            maskedTxtMaaş.Size = new Size(100, 23);
            maskedTxtMaaş.TabIndex = 8;
            maskedTxtMaaş.ValidatingType = typeof(int);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 209);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 14;
            label7.Text = "meslek";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 239);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 13;
            label6.Text = "maaş";
            // 
            // RadioBekar
            // 
            RadioBekar.AutoSize = true;
            RadioBekar.Location = new Point(153, 170);
            RadioBekar.Name = "RadioBekar";
            RadioBekar.Size = new Size(54, 19);
            RadioBekar.TabIndex = 6;
            RadioBekar.TabStop = true;
            RadioBekar.Text = "bekar";
            RadioBekar.UseVisualStyleBackColor = true;
            // 
            // RadioEvli
            // 
            RadioEvli.AutoSize = true;
            RadioEvli.Location = new Point(104, 170);
            RadioEvli.Name = "RadioEvli";
            RadioEvli.Size = new Size(43, 19);
            RadioEvli.TabIndex = 5;
            RadioEvli.TabStop = true;
            RadioEvli.Text = "evli";
            RadioEvli.UseVisualStyleBackColor = true;
            // 
            // comboSehir
            // 
            comboSehir.FormattingEnabled = true;
            comboSehir.Location = new Point(104, 122);
            comboSehir.Name = "comboSehir";
            comboSehir.Size = new Size(100, 23);
            comboSehir.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 172);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 8;
            label5.Text = "durum";
            // 
            // btnListele
            // 
            btnListele.Location = new Point(104, 22);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(101, 34);
            btnListele.TabIndex = 9;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(104, 141);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(101, 34);
            btnGüncelle.TabIndex = 12;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(104, 101);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(101, 34);
            btnSil.TabIndex = 11;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(104, 62);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(101, 34);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // TxtSoyad
            // 
            TxtSoyad.Location = new Point(104, 93);
            TxtSoyad.Name = "TxtSoyad";
            TxtSoyad.Size = new Size(100, 23);
            TxtSoyad.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 130);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 6;
            label4.Text = "sehir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 72);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 2;
            label2.Text = "Personel aad";
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(104, 180);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(101, 34);
            btnTemizle.TabIndex = 13;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 101);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "soyad";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 19);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(761, 173);
            dataGridView1.TabIndex = 0;
            // 
            // TxtPerId
            // 
            TxtPerId.Location = new Point(104, 35);
            TxtPerId.Name = "TxtPerId";
            TxtPerId.Size = new Size(100, 23);
            TxtPerId.TabIndex = 0;
            // 
            // GroupBoxİslem
            // 
            GroupBoxİslem.Controls.Add(btnGrafik);
            GroupBoxİslem.Controls.Add(btnİstatistik);
            GroupBoxİslem.Controls.Add(btnTemizle);
            GroupBoxİslem.Controls.Add(btnListele);
            GroupBoxİslem.Controls.Add(btnGüncelle);
            GroupBoxİslem.Controls.Add(btnSil);
            GroupBoxİslem.Controls.Add(btnKaydet);
            GroupBoxİslem.Location = new Point(393, 12);
            GroupBoxİslem.Name = "GroupBoxİslem";
            GroupBoxİslem.Size = new Size(309, 307);
            GroupBoxİslem.TabIndex = 15;
            GroupBoxİslem.TabStop = false;
            GroupBoxİslem.Text = "İşlemler";
            // 
            // btnGrafik
            // 
            btnGrafik.Location = new Point(104, 260);
            btnGrafik.Name = "btnGrafik";
            btnGrafik.Size = new Size(101, 34);
            btnGrafik.TabIndex = 15;
            btnGrafik.Text = "Grafik";
            btnGrafik.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 38);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Personel İd:";
            // 
            // TxtAd
            // 
            TxtAd.Location = new Point(104, 64);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(100, 23);
            TxtAd.TabIndex = 2;
            // 
            // TxtMeslek
            // 
            TxtMeslek.Location = new Point(104, 201);
            TxtMeslek.Name = "TxtMeslek";
            TxtMeslek.Size = new Size(100, 23);
            TxtMeslek.TabIndex = 7;
            // 
            // GroupBoxKayit
            // 
            GroupBoxKayit.Controls.Add(dataGridView1);
            GroupBoxKayit.Location = new Point(12, 344);
            GroupBoxKayit.Name = "GroupBoxKayit";
            GroupBoxKayit.Size = new Size(767, 195);
            GroupBoxKayit.TabIndex = 16;
            GroupBoxKayit.TabStop = false;
            GroupBoxKayit.Text = "Kayıtlar";
            // 
            // GroupBoxPersonel
            // 
            GroupBoxPersonel.Controls.Add(maskedTxtMaaş);
            GroupBoxPersonel.Controls.Add(label7);
            GroupBoxPersonel.Controls.Add(label6);
            GroupBoxPersonel.Controls.Add(RadioBekar);
            GroupBoxPersonel.Controls.Add(RadioEvli);
            GroupBoxPersonel.Controls.Add(comboSehir);
            GroupBoxPersonel.Controls.Add(label5);
            GroupBoxPersonel.Controls.Add(TxtSoyad);
            GroupBoxPersonel.Controls.Add(label4);
            GroupBoxPersonel.Controls.Add(label2);
            GroupBoxPersonel.Controls.Add(label3);
            GroupBoxPersonel.Controls.Add(TxtPerId);
            GroupBoxPersonel.Controls.Add(label1);
            GroupBoxPersonel.Controls.Add(TxtAd);
            GroupBoxPersonel.Controls.Add(TxtMeslek);
            GroupBoxPersonel.Location = new Point(26, 12);
            GroupBoxPersonel.Name = "GroupBoxPersonel";
            GroupBoxPersonel.Size = new Size(309, 307);
            GroupBoxPersonel.TabIndex = 14;
            GroupBoxPersonel.TabStop = false;
            GroupBoxPersonel.Text = "Personel Kayıt";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 587);
            Controls.Add(GroupBoxİslem);
            Controls.Add(GroupBoxKayit);
            Controls.Add(GroupBoxPersonel);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            GroupBoxİslem.ResumeLayout(false);
            GroupBoxKayit.ResumeLayout(false);
            GroupBoxPersonel.ResumeLayout(false);
            GroupBoxPersonel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnİstatistik;
        private MaskedTextBox maskedTxtMaaş;
        private Label label7;
        private Label label6;
        private RadioButton RadioBekar;
        private RadioButton RadioEvli;
        private ComboBox comboSehir;
        private Label label5;
        private Button btnListele;
        private Button btnGüncelle;
        private Button btnSil;
        private Button btnKaydet;
        private TextBox TxtSoyad;
        private Label label4;
        private Label label2;
        private Button btnTemizle;
        private Label label3;
        private DataGridView dataGridView1;
        private TextBox TxtPerId;
        private GroupBox GroupBoxİslem;
        private Button btnGrafik;
        private Label label1;
        private TextBox TxtAd;
        private TextBox TxtMeslek;
        private GroupBox GroupBoxKayit;
        private GroupBox GroupBoxPersonel;
    }
}