/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** PROJE NUMARASI.........: 01
** ÖĞRENCİ ADI............: İREM TEK
** ÖĞRENCİ NUMARASI.......: B161200048
** DERSİN ALINDIĞI GRUP...: A
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisHekimiOtomasyonu
{
    public partial class HastaKayit : Form
    {
        public HastaKayit()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            //Hata Kontrol Mekanizması Try Catch
            try
            {
                string AdSoyad = txtAdSoyad.Text;
                string TCKimlikNo = txtTcNo.Text;
                int Yas = Convert.ToInt32(txtYas.Text);
                string Telefon = txtTelefon.Text;

                //Nesne Türetmek
                Hasta h = new Hasta();

                h.HastaKayit(AdSoyad,TCKimlikNo, Yas,Telefon);
                if ((!string.IsNullOrWhiteSpace(txtAdSoyad.Text)) || (!!string.IsNullOrWhiteSpace(txtTcNo.Text)) || (!string.IsNullOrWhiteSpace(txtYas.Text)) || (!string.IsNullOrWhiteSpace(txtTelefon.Text)))
                {
                    //Switch Case Kullanımı
                    switch (cboxTedavi.Text)
                    {
                        case "Kanal Tedavisi":
                            KanalTedavisi tedavi = new KanalTedavisi();
                            tedavi.TedaviAdi = cboxTedavi.Text;
                            tedavi.TedaviSure1 = "2 Saat";
                            dgwHastaSira.Rows.Add(new object[] {h.AdSoyad,h.TcKimlikNo,h.Yas,h.Telefon,tedavi.TedaviAdi,tedavi.TedaviSure1 });
                            MessageBox.Show("Hasta Kaydı Alındı. Bekleme alanına yönlendiriyorsunuz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //dgwHastaSira.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            tabControl1.SelectedTab = tabPage2;
                            break;
                        case "Tel Taktırma":
                            TelTedavisi tedavi2 = new TelTedavisi();
                            tedavi2.TedaviAdi = cboxTedavi.Text;
                            tedavi2.TedaviSure1 = "1 Saat";
                            dgwHastaSira.Rows.Add(new object[] { h.AdSoyad, h.TcKimlikNo, h.Yas, h.Telefon, tedavi2.TedaviAdi, tedavi2.TedaviSure1 });
                            MessageBox.Show("Hasta Kaydı Alındı. Bekleme alanına yönlendiriyorsunuz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //dgwHastaSira.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            tabControl1.SelectedTab = tabPage2;
                            break;
                        case "Diş Çektirme":
                            DisCekme tedavi3 = new DisCekme();
                            tedavi3.TedaviAdi = cboxTedavi.Text;
                            tedavi3.TedaviSure1 = "30 Dakika";
                            dgwHastaSira.Rows.Add(new object[] { h.AdSoyad, h.TcKimlikNo, h.Yas, h.Telefon, tedavi3.TedaviAdi, tedavi3.TedaviSure1 });
                            MessageBox.Show("Hasta Kaydı Alındı. Bekleme alanına yönlendiriyorsunuz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //dgwHastaSira.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            tabControl1.SelectedTab = tabPage2;
                            break;
                        default:
                            MessageBox.Show("Hatalı Girdi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                   
                }
               
            }

            catch (Exception except)
            {

                MessageBox.Show(except.Message);
            }
        }

        private void HastaKayit_Load(object sender, EventArgs e)
        {
            dgwHastaSira.Columns[5].Visible = false;
            //Array Kullanımı
            string [] Tedavi = { "Kanal Tedavisi", "Tel Taktırma", "Diş Çektirme" };
            cboxTedavi.Items.AddRange(Tedavi);
        }

        private void dgwHastaSira_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Hata Kontrol Mekanizması Try Catch
            try
            {

          
                dgwHastaSira.Rows[e.RowIndex].Selected = true;

                //if kullanımı
                if (dgwHastaSira.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
                {
                    lbltedavi.Text = (dgwHastaSira.Rows[e.RowIndex].Cells[4].Value.ToString());
                    lblSure.Text = (dgwHastaSira.Rows[e.RowIndex].Cells[5].Value.ToString());
                    
                    
                    txtAdSoyadCikis.Text= (dgwHastaSira.Rows[e.RowIndex].Cells[0].Value.ToString());
                    txtTCNoCikis.Text= (dgwHastaSira.Rows[e.RowIndex].Cells[1].Value.ToString());
                    txtYasCikis.Text= (dgwHastaSira.Rows[e.RowIndex].Cells[2].Value.ToString());
                    txtTelefonCikis.Text= (dgwHastaSira.Rows[e.RowIndex].Cells[3].Value.ToString());
                    txtGorduguTed.Text= lbltedavi.Text;
                }
                
            }
            catch (Exception except)
            {

                MessageBox.Show(except.Message);
            }
        }

        private void btnHastaCikis_Click(object sender, EventArgs e)
        {
            //Hata Kontrol Mekanizması Try Catch
            try
            {
               //if else kullanımı karar yapıları
                if (lbltedavi.Text=="Kanal Tedavisi")
                {
                    KanalTedavisi kt = new KanalTedavisi(500,200,1500);
                    lbltutar.Text = kt.UcretHesapla().ToString()+" ₺";
                }
                else if (lbltedavi.Text=="Tel Taktırma")
                {
                    TelTedavisi tt = new TelTedavisi(500, 200, 1500);
                    lbltutar.Text = tt.UcretHesapla().ToString() + " ₺";
                }
                else if (lbltedavi.Text=="Diş Çektirme")
                {
                    DisCekme dc = new DisCekme(0, 50, 100);
                    lbltutar.Text = dc.UcretHesapla().ToString() + " ₺";
                }
                else
                {
                    MessageBox.Show("Hatalı Girdi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Hasta Çıkışı Yapılıyor... Ödeme Ekranına Yönlendiriliyorsunuz...","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                tabControl1.SelectedTab = tabPage3;
            }
            catch (Exception except)
            {

                MessageBox.Show(except.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Foreach Kullanımı
            foreach (DataGridViewRow row in dgwHastaSira.SelectedRows)
            {
                dgwHastaSira.Rows.RemoveAt(row.Index);

                lbltedavi.Text = "";
                lblSure.Text = "0";

            }
            txtAdSoyadCikis.Text = "";
            txtTCNoCikis.Text = "";
            txtYasCikis.Text = "";
            txtTelefonCikis.Text = "";
            txtGorduguTed.Text = "";
            lbltutar.Text = "0";
            MessageBox.Show("Ödeme Alındı... Hasta Çıkışı Yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tabControl1.SelectedTab = tabPage1;
            txtAdSoyad.Text = "";
            txtTcNo.Text = "";
            txtYas.Text = "";
            txtTelefon.Text = "";
            cboxTedavi.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Text = "";
            txtTcNo.Text = "";
            txtYas.Text = "";
            txtTelefon.Text = "";
            cboxTedavi.Text = "";
        }
    }
}
