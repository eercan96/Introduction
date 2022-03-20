using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathLibraryMethods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // PI SAYISI ; Bir dairenin çevresinin çapına bölümü. 
            //Math kütüphanesi içindedir.

            this.Text = Math.PI.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // MUTLAK DEĞER ; | | sembolü ile ifade edilir, sayı negatifliğini pozitife çevirir.

            this.Text = Math.Abs(-45).ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // FLOOR ; verilen ondalıklı değeri bir alt değere tamamlar(aslında düzler:) ).

            this.Text = Math.Floor(12.98).ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // CEILING ; Verilen ondalıklı değeri , bir üst değere tamamlar.

            this.Text = Math.Ceiling(12.18).ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // ROUND ; Sayının yarısından fazlasını bir üste, yarısından azını bir alt tam sayıya yuvarlar.

            this.Text = Math.Round(12.49).ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // TRUNCATE ; Sayının ondalıklı kısmını atar. Tam sayı haline getirir.

            this.Text = Math.Truncate(12.98).ToString();
            // int sss = Math.Truncate(12.98);
            double ssssss = Math.Truncate(12.98);
            decimal sssssssss = (decimal)Math.Truncate(12.98);


            // int.TryParse
            // Convert.

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // MAX ; Girilen iki sayıdan büyük olanı bulur.

            this.Text = Math.Max(45, 65).ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            // MIN ; Girilen iki sayıdan küçük olanı bulur.

            this.Text = Math.Min(45, 65).ToString();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            // POW ; Kuvvet alma işlemini gerçekleştirir. İlk parametrede hangi sayının kuvveti alınacak, ikinci parametrede ise o sayının kaçıncı kuvveti alınacak diye sorar.

            this.Text = Math.Pow(2, 3).ToString();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // SQRT ; Bir sayının karekökünü hesaplar.

            this.Text = Math.Sqrt(9).ToString();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            // SIGN ; Bir sayının negatif, pozitif ya da 0'a eşit olup olmadığı bilgisini verir.
            //Sayı negatifse -1, 0'a eşitse 0, pozitifse +1 döner.

            this.Text = Math.Sign(-42).ToString();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Text = Convert.ToInt32(textBox1.Text) < Convert.ToInt32((Convert.ToInt32(textBox2.Text) < (Convert.ToInt32(textBox3.Text)) ? textBox3.Text : textBox2.Text)) ? textBox1.Text : textBox2.Text;

            // double sonuc = Min(Min(txt1,txt2), txt3)

        }
    }
}
