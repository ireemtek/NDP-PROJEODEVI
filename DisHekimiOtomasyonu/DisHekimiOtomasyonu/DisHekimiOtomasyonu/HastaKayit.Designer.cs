namespace DisHekimiOtomasyonu
{
    partial class HastaKayit
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxTedavi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnHastaCikis = new System.Windows.Forms.Button();
            this.lbltedavi = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgwHastaSira = new System.Windows.Forms.DataGridView();
            this.adSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedavi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTelefonCikis = new System.Windows.Forms.TextBox();
            this.txtYasCikis = new System.Windows.Forms.TextBox();
            this.txtTCNoCikis = new System.Windows.Forms.TextBox();
            this.txtAdSoyadCikis = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbltutar = new System.Windows.Forms.Label();
            this.txtGorduguTed = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHastaSira)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hasta Kaydı";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxTedavi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtYas);
            this.groupBox1.Controls.Add(this.txtTcNo);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnKayit);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(183, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 311);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Kayıt";
            // 
            // cboxTedavi
            // 
            this.cboxTedavi.FormattingEnabled = true;
            this.cboxTedavi.Location = new System.Drawing.Point(127, 157);
            this.cboxTedavi.Name = "cboxTedavi";
            this.cboxTedavi.Size = new System.Drawing.Size(133, 26);
            this.cboxTedavi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Olunacak Tedavi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yaş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "TC KimlikNo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Soyad";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(127, 127);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(133, 24);
            this.txtTelefon.TabIndex = 4;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(127, 97);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(133, 24);
            this.txtYas.TabIndex = 3;
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(127, 67);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(133, 24);
            this.txtTcNo.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(127, 37);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(133, 24);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(139, 206);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(106, 39);
            this.btnKayit.TabIndex = 0;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnHastaCikis);
            this.tabPage2.Controls.Add(this.lbltedavi);
            this.tabPage2.Controls.Add(this.lblSure);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dgwHastaSira);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bekleme Ekranı";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnHastaCikis
            // 
            this.btnHastaCikis.Location = new System.Drawing.Point(694, 373);
            this.btnHastaCikis.Name = "btnHastaCikis";
            this.btnHastaCikis.Size = new System.Drawing.Size(75, 36);
            this.btnHastaCikis.TabIndex = 2;
            this.btnHastaCikis.Text = "Hasta Çıkışı Ver";
            this.btnHastaCikis.UseVisualStyleBackColor = true;
            this.btnHastaCikis.Click += new System.EventHandler(this.btnHastaCikis_Click);
            // 
            // lbltedavi
            // 
            this.lbltedavi.AutoSize = true;
            this.lbltedavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltedavi.Location = new System.Drawing.Point(527, 48);
            this.lbltedavi.Name = "lbltedavi";
            this.lbltedavi.Size = new System.Drawing.Size(0, 24);
            this.lbltedavi.TabIndex = 1;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(527, 91);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(21, 24);
            this.lblSure.TabIndex = 1;
            this.lblSure.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(377, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tedavi Süresi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(350, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Göreceği Tedavi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(333, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hasta Sırası";
            // 
            // dgwHastaSira
            // 
            this.dgwHastaSira.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgwHastaSira.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHastaSira.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adSoyad,
            this.tcNo,
            this.yas,
            this.telefon,
            this.tedavi,
            this.sure});
            this.dgwHastaSira.Location = new System.Drawing.Point(199, 271);
            this.dgwHastaSira.Name = "dgwHastaSira";
            this.dgwHastaSira.Size = new System.Drawing.Size(446, 150);
            this.dgwHastaSira.TabIndex = 0;
            this.dgwHastaSira.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwHastaSira_RowEnter);
            // 
            // adSoyad
            // 
            this.adSoyad.HeaderText = "Ad Soyad";
            this.adSoyad.Name = "adSoyad";
            // 
            // tcNo
            // 
            this.tcNo.HeaderText = "TCNo";
            this.tcNo.Name = "tcNo";
            // 
            // yas
            // 
            this.yas.HeaderText = "Yaş";
            this.yas.Name = "yas";
            // 
            // telefon
            // 
            this.telefon.HeaderText = "Telefon";
            this.telefon.Name = "telefon";
            // 
            // tedavi
            // 
            this.tedavi.HeaderText = "Tedavisi";
            this.tedavi.Name = "tedavi";
            this.tedavi.Visible = false;
            // 
            // sure
            // 
            this.sure.HeaderText = "Süre";
            this.sure.Name = "sure";
            this.sure.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hasta Çıkışı";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lbltutar);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtGorduguTed);
            this.groupBox2.Controls.Add(this.txtTelefonCikis);
            this.groupBox2.Controls.Add(this.txtYasCikis);
            this.groupBox2.Controls.Add(this.txtTCNoCikis);
            this.groupBox2.Controls.Add(this.txtAdSoyadCikis);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(187, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 335);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasta Çıkışı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Gördüğü Tedavi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Telefon";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 18);
            this.label11.TabIndex = 2;
            this.label11.Text = "Yaş";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 18);
            this.label12.TabIndex = 2;
            this.label12.Text = "TC KimlikNo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 18);
            this.label13.TabIndex = 2;
            this.label13.Text = "Ad Soyad";
            // 
            // txtTelefonCikis
            // 
            this.txtTelefonCikis.Location = new System.Drawing.Point(127, 127);
            this.txtTelefonCikis.Name = "txtTelefonCikis";
            this.txtTelefonCikis.Size = new System.Drawing.Size(133, 24);
            this.txtTelefonCikis.TabIndex = 4;
            // 
            // txtYasCikis
            // 
            this.txtYasCikis.Location = new System.Drawing.Point(127, 97);
            this.txtYasCikis.Name = "txtYasCikis";
            this.txtYasCikis.Size = new System.Drawing.Size(133, 24);
            this.txtYasCikis.TabIndex = 3;
            // 
            // txtTCNoCikis
            // 
            this.txtTCNoCikis.Location = new System.Drawing.Point(127, 67);
            this.txtTCNoCikis.Name = "txtTCNoCikis";
            this.txtTCNoCikis.Size = new System.Drawing.Size(133, 24);
            this.txtTCNoCikis.TabIndex = 2;
            // 
            // txtAdSoyadCikis
            // 
            this.txtAdSoyadCikis.Location = new System.Drawing.Point(127, 37);
            this.txtAdSoyadCikis.Name = "txtAdSoyadCikis";
            this.txtAdSoyadCikis.Size = new System.Drawing.Size(133, 24);
            this.txtAdSoyadCikis.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Green;
            this.label14.Location = new System.Drawing.Point(6, 238);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(208, 29);
            this.label14.TabIndex = 6;
            this.label14.Text = "Ödenecek Tutar:";
            // 
            // lbltutar
            // 
            this.lbltutar.AutoSize = true;
            this.lbltutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltutar.ForeColor = System.Drawing.Color.Green;
            this.lbltutar.Location = new System.Drawing.Point(220, 238);
            this.lbltutar.Name = "lbltutar";
            this.lbltutar.Size = new System.Drawing.Size(27, 29);
            this.lbltutar.TabIndex = 6;
            this.lbltutar.Text = "0";
            // 
            // txtGorduguTed
            // 
            this.txtGorduguTed.Location = new System.Drawing.Point(127, 160);
            this.txtGorduguTed.Name = "txtGorduguTed";
            this.txtGorduguTed.Size = new System.Drawing.Size(133, 24);
            this.txtGorduguTed.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ödemeyi Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(694, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(290, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 39);
            this.button3.TabIndex = 0;
            this.button3.Text = "Temizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // HastaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "HastaKayit";
            this.Text = "Hasta Kayıt";
            this.Load += new System.EventHandler(this.HastaKayit_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHastaSira)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.ComboBox cboxTedavi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgwHastaSira;
        private System.Windows.Forms.Label lbltedavi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn yas;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedavi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sure;
        private System.Windows.Forms.Button btnHastaCikis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbltutar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTelefonCikis;
        private System.Windows.Forms.TextBox txtYasCikis;
        private System.Windows.Forms.TextBox txtTCNoCikis;
        private System.Windows.Forms.TextBox txtAdSoyadCikis;
        private System.Windows.Forms.TextBox txtGorduguTed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

