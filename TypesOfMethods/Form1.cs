using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypesOfMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* 4 çeşit metot tipi vardır ; 

        **Geriye değer döndürmeyen ve parametre almayan,
        **Geriye değer döndürmeyen ve parametre alan,
        **Geriye değer döndüren ve parametre almayan,
        **Geriye değer döndüren ve parametre alan. 

 :)(:

 */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //3
            MessageBox.Show(BilgiGoster());
            string bilgileriSakla = BilgiGoster();
            MessageBox.Show(bilgileriSakla);
            //4
            MessageBox.Show(BilgileriAlGoster(textBox1.Text, textBox2.Text, textBox3.Text));
            BilgileriAlGoster();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // 1
            IkiSayiyiTopla();
            //2
            IkiSayıyıAlTopla(6, 9);
        }
        void IkiSayiyiTopla()
        {
            int sayi1 = 10;
            int sayi2 = 15;
            int sonuc = sayi1 + sayi2;
            MessageBox.Show("Method 1 : " + sonuc.ToString());
        }
        // Geriye değer döndürmeyen ve parametre alan metot ; 

        int x, y;
        void IkiSayıyıAlTopla(int x, int y)
        {

            // Dışarıdan alınan iki sayıyı toplama
            int toplam = x + y;

            MessageBox.Show("Metot 2 : " + toplam.ToString());
        }
        // Geriye değer döndüren ve parametre almayan metot ; 

        string BilgiGoster()
        {

            string isim = textBox1.Text;
            string soyisim = textBox2.Text;
            string dogumYili = textBox3.Text;

            int yas = DateTime.Now.Year - Convert.ToInt32(dogumYili);
            return "Sayın " + isim + " " + soyisim.ToUpper() + " yaşınız : " + yas;

            // MessageBox.Show("Merhabalar" + isim + " " + soyisim.ToUpper() + "yaşınız: " + yas);
            //string.Format("Sayın {0} {1} {2}" , isim, soyisim.ToUpper(), yas);
        }

        // Geriye değer döndüren ve parametre alan metot ; 

        string BilgileriAlGoster(string ad, string soyad, string yil)
        {

            int yas = DateTime.Now.Year - Convert.ToInt32(yil);

            return string.Format("Sayın {0} {1} yaşınız {2}", ad, soyad.ToUpper(), yas);

        }
        void BilgileriAlGoster()
        {
            MessageBox.Show("Bilgi yok  ");
        }
    }
}
