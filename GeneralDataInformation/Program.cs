using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralDataInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Değişken Nedir?       
              Değişkenleri en sabit şekilde verilerin depolandğı yerler olarak tanımlayabiliriz. Değişkenlerin içine verilerimizi koyabiliririz veya değişkenlerimizin içindeki verileri C# programındaki işlemlerimiz için kullanabilliriz.
            */

            /*
             Değisken İsimlendirme Kuralları

                1) C#'da değişken isimlendirmede "Büyük-Küçük" harf duyarlılığı (case sensitive) vardır.
                2) Değişken isimlerinde boşluk bulunamaz.
                3) Değişken isimleri özel karakterler ile başlayamaz.
                4) Değişken isimleri özel karakter barındıramaz. (Özel/İstisnai karakter olarak yalnızca ‘ _ ’ ifadesi kullanılabilir. )
                5) Değişken isimleri sayı ile başlayamaz ancak sayı ile bitebilir.
                6) Değişken isimleri Türkçe karakterleri içermemelidir.
                7) Değişken isimleri anahtar kelimeler olamaz.
                8) Değişken isimleri 255 karakterden fazla olamaz.

            EKSTRA : 

             ** Kullanmayacağımız değişkenleri asla tanımlamamalıyız.
             ** Değer aralıklarına göre doğru veri tiplerini seçmeye özen göstermeliyiz... (Değisken Yönetimi = Performans Yönetimi)
             ** Bir değisken adı eğer iki ya da daha fazla kelimeden oluşuyor ise mutlaka izin verilen özel bir karakterle (_) birbirinden ayrılmalıdır..
             *
            */



            // SAYISAL VERİ TİPLERİ 

            //DEĞISKEN TANIMLAMA FORMATI
            //veriTipi degiskenAdi = degiskenDegeri;

            // Int16 Int32 Int64 => Class tanımlaması.
            // float int double => alias / kod içerisinden çağrılması.

            //sbyte => -128 ~ 127 Aralığı => 8 BİT
            sbyte degiskenBir = 24;
            sbyte degisken_bir = 24;

            Console.WriteLine(degiskenBir);

            //byte => 0 ~ 255 => 8 BİT
            byte degisken_Iki = 45;

            //short => -32767 ~ 32768 => 16 BİT
            short degiskenUc = -23456;

            //ushort => 0 ~ 65536 => 16 BİT
            ushort degiskenDort = 234;

            //int => -2.1 Milyar ~ 2.1 Milyar => 32 BİT
            int degiskenBes = -23456789;

            //uint => 0 ~ 4.2 Milyar => 32 BİT
            uint degiskenAlti = 3455435;

            //long => -9.1 Katrilyon ~ 9.1 Katrilyon => 64 BİT
            long degiskenYedi = -4565365645;

            //ulong => 0 ~ 18 Katrilyon => 64 BİT
            ulong degiskenSekiz = 9350685965;


            ////////////////// ONDALIKLI VERİ TİPLERİ ///////////////////////

            //float => .'dan sonra 7 hane destegi => 32 BİT
            float ondalikliBir = 1.245F;

            //double => .'dan sonra 13-14 hane destegi => 64 BİT
            double ondalikliIki = 2.343454D;

            //decimal => .'dan sonra 27-28 hane destegi => 128 BİT
            decimal ondalikliUc = 3.6546756M;



            // METİNSEL VERİ TİPLERİ

            //char => Üzerinde tek bir karakteri barindirabilen veri tipidir.
            char basHarfim = 'o';// 16 bit => Unicode Karakter
            char ozelKarakterim = '$';

            //string => Ansiklopedik verilerden tutun da tek karakterlik verilere kadar tum metinsel ifadeleri kapsayan veri tipidir.
            string bosMetin = "";
            string uzunMetin = "Öyle döktüresim öyle bir yazasım var ki buraya yazsam roman olurdu.... =) ";

            //  \n => Bir alt satıra gecmek icin kullanılır.
            string ikiSatirlikMetin = "İlk satırımı yazıyorum\nİkinci satırıma geçmiş oldum.";
            Console.WriteLine(ikiSatirlikMetin);

            //  \t => Metin arasında bir tab'lık bosluk birakmak icin kullanılır.
            string tabliMetin = "Cümlemi kurdum.\tBu cümlem de bir tab ileride";
            Console.WriteLine(tabliMetin);

            //  \r => Kendisinden önce gelen metinleri sonraki metin boyutundaki karakter sayısı kadar siler.
            string tekKalanMetin = "Bu cümle basıldığında kendi kendini imha edecektir:) \r İmha edilmeyecek olan cümleM:)";
            Console.WriteLine(tekKalanMetin);

            // "Escape Sequences" - "Kaçış Karakterleri"

            string ciftTirnakliMesaj = "Benim adım \"Emre\"";
            Console.WriteLine(ciftTirnakliMesaj);



            // MANTIKSAL VERİ TİPİ

            bool bugunTatilMi = false;

            bool senGercekMisin = true;

            bool buyukMu = 19 > 6;


            Console.ReadKey();
        }
    }
}
