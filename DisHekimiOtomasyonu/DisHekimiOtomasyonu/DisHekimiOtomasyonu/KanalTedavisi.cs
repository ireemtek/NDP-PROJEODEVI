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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiOtomasyonu
{
    class KanalTedavisi:Tedavi
    {
        //parametresiz Constructor
        public KanalTedavisi()
        {
            
        }
        //parametreli Constructor
        public KanalTedavisi(double TechizatUcreti, double MalzemeUcreti, double Fiyat) :base( TechizatUcreti,  MalzemeUcreti,  Fiyat)
        {

        }
        private string KanalAd;
        public override string TedaviAdi
        {
            get => KanalAd;
            set => KanalAd = value;
        }

        //Pollymorpihsm Method
        public override double UcretHesapla()
        {
            double zam = 0.20;
            return (Techizatucreti+Malzemeucreti+Fiyat)+ (Techizatucreti + Malzemeucreti + Fiyat)*zam;
        }
    }
}
