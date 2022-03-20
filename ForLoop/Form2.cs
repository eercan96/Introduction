using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLoop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //Asagidaki dizide yer alan her bir elemani, listbox icerisine ekleyiniz...
            string[] takimlar = { "Galatasaray", "Fenerbahce", "Besiktas", "Trabzonspor", "Bursaspor", "Ankaragücü" };

            for (int index = 0; index < takimlar.Length; index++)
            {
                listBox1.Items.Add(takimlar[index]);
            }

        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //Sayisal bir dizi tanimlayin ve Array sınıfını kullanmadan o dizinin en buyuk elemanini gosterin...
            int[] sayisal = { 12, 45, 23, 76, 119, 85, 46, 223, 4, 6 };
            int enBuyukEleman = 0;
            for (int index = 0; index < sayisal.Length; index++)
            {
                if (enBuyukEleman < sayisal[index])
                {
                    enBuyukEleman = sayisal[index];
                }
            }
            MessageBox.Show("En Büyük Eleman => " + enBuyukEleman);
            // MessageBox.Show($"En Büyük Eleman => {enBuyukEleman}");

        }

        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            //Asagidaki dizide kac tane cift kac tane tek sayi vardir kullaniciyi bilgilendiriniz..
            int[] sayisal = { 12, 45, 23, 76, 119, 85, 46, 223, 4, 6, 25 };
            int tekSayilar = 0;
            int ciftSayilar = 0;

            for (int index = 0; index < sayisal.Length; index++)
            {
                if (sayisal[index] % 2 == 0)
                {
                    ciftSayilar++;
                }
                else
                {
                    tekSayilar++;
                }
            }

            MessageBox.Show(string.Format("Bu dizide toplam {0} adet çift sayı, {1} adet tek sayı bulunmaktadır.", ciftSayilar, tekSayilar));
            // MessageBox.Show($"Bu dizide toplam {ciftSayilar} adet sayı, {tekSayilar} adet tek sayı bulunmaktadır.");

        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            //asagidaki "adim" degiskeninde yer alan metni tersten isterseniz formun tepesine, isterseniz MessageBox'la yazdiriniz...

            //NOT => STRING'LER BİRER CHAR DİZİSİDİR...
            string adim = "emreercan";
            string terstenYazim = "";

            for (int index = adim.Length - 1; index >= 0; index--)
            {
                terstenYazim += adim[index];
            }
            MessageBox.Show("Tersten Yazım => " + terstenYazim);
            // MessageBox.Show($"Tersten Yazım => {terstenYazim}");

        }

        private void btnOrnekBes_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //Karmasik 10 adet sayiyi listbox icerisine ekleyiniz...
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int karmasikSayi = rnd.Next(0, 101);
                listBox1.Items.Add(karmasikSayi);
            }

        }

        private void btnOrnekAlti_Click(object sender, EventArgs e)
        {
            //Form uzerinde yer alan tum butonlarin arkaplan renkleri kırmızı, yazi renkleri ise sarı olsun...

            //Eger icinde bulundugunuz forma isaret etmek istiyorsaniz, kullanacaginiz anahtar kelime "this" anahtar kelimesidir...
            for (int i = 0; i < this.Controls.Count; i++)
            {
                //Eger karar yapilarinizda bir tip kontrolu yapiyorsaniz, ==, != gibi operatorler size cevap vermez. Yapmaniz gereken, bu operatorlerin yerine "is" anahtar kelimesini kullanmak...
                if (this.Controls[i] is Button)
                {
                    this.Controls[i].BackColor = Color.Maroon;
                    this.Controls[i].ForeColor = Color.Orange;
                }
                else if (this.Controls[i] is ListBox)
                {
                    this.Controls[i].BackColor = Color.DarkBlue;
                    this.Controls[i].ForeColor = Color.Yellow;
                    listBox1.Font = new Font("Tahoma", 13);
                }
            }

        }

        private void btnOrnekYedi_Click(object sender, EventArgs e)
        {
            //Disaridan girilen sayisal ifadenin rakam degerleri toplamini gosteriniz...
            //Ornegin 123 girilirse 1+2+3 = 6 sonucu donmelidir...

            int toplamHavuzu = 0;
            for (int i = 0; i < txtGirisAlani.Text.Length; i++)
            {
                //Char'ı int'e cevirdigimiz zaman bize ASCII degeri verecegi icin, oncelikle onu string'e cevirip daha sonra int'a cevirmek daha dogru olacaktir...
                int cevrilenDeger = Convert.ToInt32(txtGirisAlani.Text[i].ToString());
                toplamHavuzu += cevrilenDeger;
            }
            MessageBox.Show(toplamHavuzu.ToString());

        }
    }
}
