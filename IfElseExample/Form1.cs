using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfElseExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisKontrolu_Click(object sender, EventArgs e)
        {
            if (txtBirinciDeger.Text == "admin" && txtIkinciDeger.Text == "1234")
            {
                MessageBox.Show("Tebrikler, tum bilgileri dogru girdiniz...");
            }
            else
            {
                //Iki kosuldan herhangi birinin saglanmamasi durumu
                MessageBox.Show("Kullanıcı adınızı ya da şifrenizi yanlış girdiniz!");
            }
        }

        private void btnNotKontrolu_Click(object sender, EventArgs e)
        {
            //Girilen not 0 - 30 aralığı ise "FF" 30 - 50 aralığı "DD" 50 - 70 "BB" 70 - 100 "AA" aldınız şeklinde kullanıcıyı uyarınız..
            int not = Convert.ToInt32(txtBirinciDeger.Text);

            if (not >= 0 && not <= 30)
            {
                MessageBox.Show("Harf Notunuz: FF");
            }
            else if (not >= 31 && not <= 49)
            {
                MessageBox.Show("Harf Notunuz: DD");
            }
            else if (not >= 50 && not <= 69)
            {
                MessageBox.Show("Harf Notunuz: BB");
            }
            else if (not >= 70 && not <= 100)
            {
                MessageBox.Show("Harf Notunuz: AA");
            }
            else
            {
                MessageBox.Show("Girilen not geçerli değildir!");
            }
        }

        private void btnMarketKontrolu_Click(object sender, EventArgs e)
        {
            //Dışarıdan ürün adı girilecek, kasiyer bize ürünün hangi reyonda olduğunu söyleyecek...
            //Domates, Biber, Patlican => Sebze Reyonu
            //Diş Macunu, Parfüm, Şampuan => Kozmetik Reyonu
            //Cep Telefonu, Bilgisayar, Ses Sistemi => Teknoloji Reyonu
            //Başka bir ürün girilirse "Bu ürün bizde yok!" uyarisi verilsin!
            if (txtBirinciDeger.Text == "Domates" || txtBirinciDeger.Text == "Biber" || txtBirinciDeger.Text == "Patlıcan")
            {
                MessageBox.Show("Sebze reyonuna buyrun!");
            }
            else if (txtBirinciDeger.Text == "Diş Macunu" || txtBirinciDeger.Text == "Parfüm" || txtBirinciDeger.Text == "Şampuan")
            {
                MessageBox.Show("Kozmetik reyonuna lütfen");
            }
            else if (txtBirinciDeger.Text == "Cep Telefonu" || txtBirinciDeger.Text == "Bilgisayar" || txtBirinciDeger.Text == "Ses Sistemi")
            {
                MessageBox.Show("Teknoloji reyonunda bulabilirsiniz!");
            }
            else
            {
                MessageBox.Show("Bu ürün karşıki markette!");
            }
        }

        private void btnSatisIslemi_Click(object sender, EventArgs e)
        {
            //Disaridan siparis alinacak olan kitap miktari girilsin. Sipari sayisi 20'den azsa toplam ucretten %5, 20 - 50 araliginda ise %10, 50-100 araligi ise %15, 100'den fazla ise %25 indirim yapilsin. Kitabın birim fiyatı => 5 TLdir... Amac => Odenecek tutari kullaniciya gostermek...
            double birimFiyat = 5;
            double alinanSiparisMiktari = Convert.ToDouble(txtBirinciDeger.Text);
            double toplamOdenecekTutar = 0;



            if (alinanSiparisMiktari > 0 && alinanSiparisMiktari <= 20)
            {
                toplamOdenecekTutar = (birimFiyat * alinanSiparisMiktari) * 0.95;
            }
            else if (alinanSiparisMiktari >= 21 && alinanSiparisMiktari <= 50)
            {
                toplamOdenecekTutar = (birimFiyat * alinanSiparisMiktari) * 0.90;
            }
            else if (alinanSiparisMiktari >= 51 && alinanSiparisMiktari <= 100)
            {
                toplamOdenecekTutar = (birimFiyat * alinanSiparisMiktari) * 0.85;
            }
            else if (alinanSiparisMiktari > 100)
            {
                toplamOdenecekTutar = (birimFiyat * alinanSiparisMiktari) * 0.75;
            }

            MessageBox.Show("Ödemeniz gereken toplam tutar: " + toplamOdenecekTutar + " TL");

        }
    }
}
