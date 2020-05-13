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
    //Hasta kaydı oluşturmak için kullanılan arayüz
    interface IHasta
    {
        void HastaKayit(string AdSoyad,string TCKimlikNo,int Yas,string Telefon);
    }
}
