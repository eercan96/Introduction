using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayStructure
{
    public partial class ArrayExample : Form
    {
        public ArrayExample()
        {
            InitializeComponent();
        }
        string[] arabalar = { "Mercedes", "Ferrari", "Bugatti", "Lamborghini", "Audi", "Seat", "Honda", "Alfa Romeo" };

        int[] sayilar = { 10, 20, 30, 40, 50 };
        int index = 0;
        int havuz = 0;

        private void btnSonElemaniGoster_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // Dizi eleman sayısını bilmiyorsak; ...
            string sonEleman = arabalar[arabalar.Length - 1];
            MessageBox.Show("Son Eleman => " + sonEleman);
            listBox1.Items.Add(sonEleman);

        }

        private void btnRastgeleEleman_Click(object sender, EventArgs e)
        {
            // Dizinin bir elemanını rastgele olarak yazdırın.. 

            listBox1.Items.Clear();

            Random rnd = new Random();
            int rastgeleIndex = rnd.Next(0, arabalar.Length);
            this.Text = arabalar[rastgeleIndex];
            listBox1.Items.Add(arabalar[rastgeleIndex]);

        }

        private void btnElemanlariListboxaEkle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (string araba in arabalar)
            {
                listBox1.Items.Add(araba);
            }

        }
        // int[] sayilar = { 10, 20, 30, 40, 50 };
        // int index = 0;
        // int havuz = 0;

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            // Her butona basılışında, dizinin tüm elemanlarını sırası ile listbox'a ekleyin. 
            // Eklenen elemanları da anlık olarak bir havuzda toplayarak hesaplayıp formun textine yazdırın... 

            if (index < sayilar.Length)
            {
                listBox1.Items.Add(sayilar[index]);
                havuz += sayilar[index];
                this.Text = "Şu ana dek toplamınız => " + havuz;
                index++;
            }

            else
            {
                MessageBox.Show(" Dizinin son elemanına ulaştın ! .. ");
            }

        }
    }
}
