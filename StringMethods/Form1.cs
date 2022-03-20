using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TRIM , belli karakterleri baştan ve sondan siler. Ayrıca boşlukları da temizler ! 


            textBox1.Text = textBox1.Text.Trim(); // sağdaki ve soldaki tüm boşlukları siler.

            textBox1.Text = textBox1.Text.Trim(' ', '+', '*', '\'');  //Textboxda başta ve sonra bırakılan boşlukları temizler. Bu şekilde char dizisi tanımlanır ve bu yukarıda bulunan karakterlerin başta ve sonda olmasını engeller. Tek tırnak engellemek için başına \ ters slash kullanılarak yazılır. /' şeklinde tek tırnak engellenir. 
            textBox1.Text = textBox1.Text.Trim(' ', '+', '*', '"', '\'', '\\');

            textBox1.Text = textBox1.Text.TrimStart(); // Yalnızca baştaki BOŞLUKLARI temizler.

            // "   metinleri   buraya     yazdım    ".TrimStart();
            textBox1.Text = textBox1.Text.TrimEnd(); // Yalnızca sondaki BOŞLUKLARI temizler.

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Stringlerin birbirine eşit olup olmadığını kontrol eder. Boolean bir değer döner ! 

            // bool esitMidir1 = textBox1.Text.Equals(textBox2.Text);

            bool esitMidir = textBox1.Text.Equals(textBox2.Text, StringComparison.OrdinalIgnoreCase);

            // StringComparison.OrdinalIgnoreCase --> metodu küçük-büyük harf gözetmeksizin karşılaştırma // i - I farkını algılamaz ! 
            // StringComparison.CurrentCultureIgnoreCase --> hem büyük-küçük harf gözetmeksizin hem de dil seçeneğine göre kıyaslama 

            EsitlikKontrol(esitMidir);
            EsitlikKontrolTernary();

            MessageBox.Show(esitMidir.ToString());

        }
        bool esitMidir = false;
        void EsitlikKontrol(bool esitlik)
        {
            // bool esitlik = textBox1.Text.Equals(textBox2.Text, StringComparison.OrdinalIgnoreCase); 
            if (esitlik)
            {
                MessageBox.Show("Evet hepimiz eşitiz");
            }
            else
            {
                MessageBox.Show("No");
            }
        }
        void EsitlikKontrolTernary()
        {
            bool karsilastirma = textBox1.Text.Equals(textBox2.Text, StringComparison.OrdinalIgnoreCase);
            string esitMidir = karsilastirma ? "doğrusun" : "yanlışın var!";
            MessageBox.Show(esitMidir);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // SUBSTRING ; String ifadede bulunan karakterlerden belirtilen index numarasından başlayarak string ifadenin sonuna kadar keser ve basar ! 

                textBox1.Text = textBox1.Text.Substring(5); // index'i 5 olan harften başla, sonuna kadar kes ; yani 6. karakterden sonuna kadar olan kısmı al, bas:)

                textBox2.Text = textBox2.Text.Substring(2, 5); // index'i 2 olan karakterden sonrasındaki 5 karakteri al ! Stringin boyutunu aşan bir substring işlemi yaparsak out of range hatası alırız. Bu hata string sınırlarını aşmak anlamına gelir.
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Indexlerine kontrol et !!! ");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // REVERSE; Metni ters çevirir

            string metin = textBox1.Text.Reverse().ToString();
            // IEnumerable
            MessageBox.Show(metin);

            foreach (var item in metin)
            {
                MessageBox.Show(item.ToString());
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Yazan metin içindeki istenilen karakteri arar ! Fakat birden fazla aynı değer olduğu durumlar olsa dahi yalnızca ilk bulduğu değeri(indexini) döndürür ! Tekrar eden karakter olsa dahi bulduğu zaman aramaya devam etmiyor! 
            // Aradığımız karakteri metin içinde bulamazsa, -1 değer döndürür ! 

            textBox1.Text = textBox1.Text.IndexOf('a').ToString(); // selina dersek, 5 döndürür ! 
            // textBox2.Text = textBox2.Text.IndexOf("alp").ToString(); //siyalp dersek, 3(aranılan karakterlerin en başındakinin indexini döndürür !  
            textBox2.Text = textBox2.Text.IndexOf('a', 3).ToString(); // ikinci parametre index sayısıdır, istenilen index sayısından sonraki karakterleri arar ! 

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //REMOVE ; karakterleri silmek için kullanılır.

            textBox1.Text = textBox1.Text.Remove(2); // belirtilen sayıdan sonraki karakterleri sil

            textBox2.Text = textBox2.Text.Remove(1, 2); // indexi 1 olandan itibaren sonrasındaki 2 karakter sil

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // CONTAINS ; belirtilen karakter(dizisinin) metin içinde geçip geçmediğini kontrol eder ! Boolean bir değer döndürür ! 

            bool iceriyorMuAcep = textBox1.Text.Contains('a');
            MessageBox.Show(iceriyorMuAcep.ToString());

            bool kelimeIceriyorMuAcep = textBox2.Text.Contains("selo");
            MessageBox.Show(kelimeIceriyorMuAcep.ToString());

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // REPLACE ; string ifade içinde bulunan değeri değiştirir.

            // 1. Karakter değiştirme ; 

            textBox1.Text = textBox1.Text.Replace('a', 'e');

            // 2. İfade değiştirme ; 

            textBox2.Text = textBox2.Text.Replace("emre", "ercan");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //SPLIT  string içersinindeki belirli ayraca(karakter) göre stringi parçalama/ayırma için kullanılır. Böldüğü ifadeleri bir diziye aktarır.

            string[] kelimeler = textBox1.Text.Split();

            foreach (var kelime in kelimeler)
            {
                MessageBox.Show(kelime.ToString());
            }

            //listbox1.Items.AddRange(kelimeler);  // listbox içine atmak istersek!:)

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // TO UPPER ; verilen ifade içindeki tüm harfleri büyütür.

            textBox1.Text = textBox1.Text.ToUpper();

            //TO LOWER ; verilen ifade içindeki tüm harfleri küçültür.

            textBox2.Text = textBox2.Text.ToLower();

        }
    }
}
