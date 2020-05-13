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
    public partial class KarsilamaEkrani : Form
    {
        public KarsilamaEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HastaKayit hk = new HastaKayit();
            //if else Kullanımı
            if (textBox1.Text=="doktor" && textBox2.Text=="1234")
            {
                hk.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ve ya Şifre Hatalı. !");
            }
        }
    }
}
