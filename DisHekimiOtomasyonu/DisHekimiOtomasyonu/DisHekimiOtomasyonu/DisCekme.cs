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
    class DisCekme : Tedavi
    {
        //parametresiz Constructor 
        public DisCekme()
        {

        }
        //parametreli Constructor
        public DisCekme(double TechizatUcreti, double MalzemeUcreti, double Fiyat) :base( TechizatUcreti,  MalzemeUcreti,  Fiyat)
        {
                
        }
        private string DisAd;
        public override string TedaviAdi { get => DisAd; set => DisAd=value; }

        //Pollymorpihsm Method
        public override double UcretHesapla()
        {
            
            return Malzemeucreti+Fiyat;
        }
    }
}
