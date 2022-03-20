using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatch2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            try
            {
                double sayi1 = Convert.ToInt32(txtSayi1.Text);
                double sayi2 = Convert.ToInt32(txtSayi2.Text);
                double sonuc = sayi1 / sayi2;
                lblSonuc.Text = sonuc.ToString();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Lütfen girdiğiniz veriyi doğru format ile yazınız...");
            }
            catch (OverflowException oe)
            {
                MessageBox.Show("Girdiğiniz değer sınırların dışına çıktınız!!");
            }
            catch (DivideByZeroException de)
            {
                MessageBox.Show("Sıfıra bölünme hatası ! ... Sayı sıfıra bölünemez ! .. ");
            }
            // Geri kalan tüm hatalar ... 
            catch (Exception ex)
            {

                MessageBox.Show("BİLİNMEYEN HATA !! ");
            }

        }
    }
}
