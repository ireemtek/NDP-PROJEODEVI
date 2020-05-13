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
****************************************************************************/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiOtomasyonu
{
    class Hasta:IHasta
    {
        //Kapsüllenmiş (Encapsulation) private alanlar (Fields)
        private string _adSoyad;
        private string _tcKimlikNo;
        private int _yas;
        private string _telefon;

        //Properties Özellikler
        public string AdSoyad { get => _adSoyad; set => _adSoyad = value; }
        public string TcKimlikNo { get => _tcKimlikNo; set => _tcKimlikNo = value; }
        public int Yas { get => _yas; set => _yas = value; }
        public string Telefon { get => _telefon; set => _telefon = value; }

        //interfaceden gelen method
        public void HastaKayit(string AdSoyad, string TCKimlikNo, int Yas, string Telefon)
        {
            this._adSoyad = AdSoyad;
            this._tcKimlikNo = TCKimlikNo;
            this._yas = Yas;
            this._telefon = Telefon;
        }
    }
}
