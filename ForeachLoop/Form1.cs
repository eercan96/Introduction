using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForeachLoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         FOREACH
         1) Kesinlikle index mantığı yoktur!
         2) Tip bağımlı dongülerdir...
         3) Çoğu zaman elimizdeki bir koleksiyonun her bir elemanını tek tek ele almak için kullanılır...
         */

        string[] sehirler = { "Ankara", "İzmir", "İstanbul", "Bursa", "Eskişehir", "Trabzon", "Sivas", "Malatya" };

        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            //İlgili dizi içerisindeki her bir elemana geçici olarak "str" takma adı verilir ve döngünün her bir adımında size dizinin her bir elemanı teslim edilir...
            foreach (string str in sehirler)
            {
                //str diye adlandırdığımız değisken, döngünün devam edebilmesi için yardımcı bir araçtır. Herhangi bir değeri yoktur! (Foreach iterator)
                //str = "Tanımsız";
                listBox1.Items.Add(str);
            }

        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            //İkiye bölunenleri listbox1'e bölünemeyenleri listbox2 ye atın... Hem ikiye hem üçe bölünenlerin kaç tane olduğunu da messagebox'la gösterin...
            int[] dizi = { 123, 54, 76, 876, 4532, 23, 77, 734, 83, 45, 190 };

            int tamBolunenHavuzu = 0;
            foreach (int sayi in dizi)
            {
                if (sayi % 2 == 0 && sayi % 3 == 0)
                {
                    tamBolunenHavuzu++;
                }

                if (sayi % 2 == 0)
                {
                    listBox1.Items.Add(sayi);
                }
                else
                {
                    listBox2.Items.Add(sayi);
                }
            }
            // MessageBox.Show("Bu dizide hem 2ye hem de 3 tam bölünen toplam " + tamBolunenHavuzu + " sayı vardır...");
            MessageBox.Show($"Bu dizide hem 2 ye hem de 3 tam bölünen toplam {tamBolunenHavuzu} sayı vardır");

        }

        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            //Listbox1'deki seçili tüm elemanları (birden fazla seçim şansı olmalı!) listbox2'ye ekleyelim...
            foreach (string eleman in listBox1.SelectedItems)
            {
                if (!listBox2.Items.Contains(eleman))
                {
                    listBox2.Items.Add(eleman);
                }
            }

        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            //Form uzerindeki tum butonlarin arkaplanlari ve yazi renklerini degistiriniz...
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    //if (ctrl.Name == "btnOrnekIki" || ctrl.Name == "btnOrnekDort")
                    //{
                    ctrl.BackColor = Color.Maroon;
                    ctrl.ForeColor = Color.Orange;
                    //}
                }
            }

        }
    }
}
