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
    //Soyut bir Sınıf tanımladık bu sınıftan nesne türetilemez.
    abstract class Tedavi
    {
        protected double techizatucreti;
        protected double malzemeucreti;
        protected double fiyat;

        //Constructor Parametresiz
        public Tedavi()
        {

        }

        //Constructor Parametreli
        public Tedavi(double TechizatUcreti,double MalzemeUcreti,double Fiyat)
        {
            this.techizatucreti = TechizatUcreti;
            this.malzemeucreti = MalzemeUcreti;
            this.fiyat = Fiyat;
        }
        //Private Kapsüllenmiş alanlar (Fields)
        private string TedaviSure;


        //Properties Özellikler
        public abstract string TedaviAdi { get; set; }
        public string TedaviSure1 { get => TedaviSure; set => TedaviSure = value; }
        protected double Techizatucreti { get => techizatucreti; set => techizatucreti = value; }
        protected double Malzemeucreti { get => malzemeucreti; set => malzemeucreti = value; }
        protected double Fiyat { get => fiyat; set => fiyat = value; }

        //Pollymorphism kullanılacak Method
        public virtual double UcretHesapla()
        {
            return 0;
        }
    }
}
