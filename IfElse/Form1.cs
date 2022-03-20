using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfElseGeneral
{
    public partial class Form1 : Form
    {
        /*
          KARAR YAPILARI
          Uygulamanizin calismasi esnasinda farkli senaryolara gore farkli yonlendirmeler yapmaniz gerekebilir. Ornegin, kullanicidan gelen degerin araligina gore, uygulamadaki mantiksal islerinizin sonuclarina gore yonlendirmeler yapabiliriz. 
          3 temel karar yapısı karsimiza cikar => IF-ELSE ~ SWITCH-CASE ~ TERNARY OPERATORU
        */

        /*
         * KARSILASTIRMA OPERATORLERI
         * 1) ==  (Karsilikli iki degerin birbiriyle esit olmasi durumu)
         * 2) !=  (Karsilikli iki degerin birbiriyle esit olmamasi durumu)
         * 3) <   (Soldaki degerin sagdaki degerden kucuk olmasi durumu)
         * 4) >   (Soldaki degerin sagdaki degerden buyuk olmasi durumu)
         * 5) <=  (Soldaki degerin sagdaki degere esit ya da ondan kucuk olmasi durumu)
         * 6) >=  (Soldaki degerin sagdaki degere esit ya da ondan buyuk olmasi durumu)
         */
        double girilenNot;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdminKontrolu_Click(object sender, EventArgs e)
        {
            if (txtGirisAlani.Text == "admin")
            {
                MessageBox.Show("Hoşgeldin!");
            }
            else
            {
                MessageBox.Show("Tanıyamadım!");
            }

        }

        private void btnNotKontrolu_Click(object sender, EventArgs e)
        {
            try
            {
                //Eğer girilen not 0'dan küçükse 0'dan küçük bir not girişi yapamazsınız" 100'dan büyükse "100'den büyük bir not girişi yapamazsınız" mesajını göstersin...
                girilenNot = Convert.ToDouble(txtGirisAlani.Text);
                //string girilenDeger = txtGirisAlani.Text; => Sayısal bir karşılaştırma yapacağımız için girilen değeri mutlak suretle sayısal bir veri tipine çevirmeliyiz...

                if (girilenNot < 0)
                {
                    MessageBox.Show("O'dan küçük bir not girişi yapamazsınız!");
                }
                else if (girilenNot > 100)
                {
                    MessageBox.Show("100'den büyük bir not girişi yapamazsınız!");
                }
                else
                {
                    MessageBox.Show("Hatasız not girişi yaptınız!");
                }
            }
            catch (FormatException fe)
            {
                // MessageBox.Show(fe.Message);
                MessageBox.Show("Lütfen doğru sayı değeri girişini yapınız.");

            }
            catch (OverflowException)
            {
                MessageBox.Show("Virgülden sonra fazla değer girdiniz!!");
            }
            catch (Exception)
            {

                MessageBox.Show("HATA!!!");
            }
        }

        private void btnCiftMiTekMi_Click(object sender, EventArgs e)
        {
            //txtGirisAlani'ndan girilen sayı çift ise "Sayı Çifttir" tek ise "Sayı Tektir" mesajını kullanıcıya gösteriniz...
            try
            {
                int girilenSayi = Convert.ToInt32(txtGirisAlani.Text);
                if (girilenSayi % 2 == 0)
                {
                    MessageBox.Show("Sayı  çifttir!");
                }
                else
                {
                    MessageBox.Show("Sayı  tektir!");
                }
            }
            catch (FormatException fe)
            {
                // MessageBox.Show(fe.Message);
                MessageBox.Show("Lütfen doğru sayı değeri girişini yapınız.");

            }
            catch (OverflowException)
            {
                MessageBox.Show("Virgülden sonra fazla değer girdiniz!!");
            }
            catch (Exception)
            {

                MessageBox.Show("HATA!!!");
            }

        }

        private void btnDegerKontrolu_Click(object sender, EventArgs e)
        {
            //Dışarıdan girilen kelimenin uzunluğu 8 karaktere eşit ya da büyükse kayıt onaylandı, değilse daha uzun bir şifre giriniz...
            if (txtGirisAlani.Text.Length >= 8 && txtGirisAlani.Text.Length <= 16)
            {
                MessageBox.Show("Kayıt onaylandı!");
            }
            else
            {
                // MessageBox.Show("Daha uzun bir şifre giriniz!");
                MessageBox.Show("Gireceğiniz karakter sayısı 8 ile 16 arasında olmalıdır.");
            }

        }
    }
}
