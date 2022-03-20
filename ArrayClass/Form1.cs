using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] ornekDizi = { "İstanbul", "Ankara", "İzmir", "Bursa", "Eskişehir", "Konya", "Trabzon", "Sivas", "Eskişehir" };

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Array.Clear() => Diziden eleman silmek için kullandığımız metottur... 

            Array.Clear(ornekDizi, 2, 3);

            // Dizinin tamamını temizlemek için; 

            Array.Clear(ornekDizi, 0, ornekDizi.Length);


            foreach (var diziElemani in ornekDizi)
            {
                MessageBox.Show(diziElemani);

                if (diziElemani != null)
                {
                    lst_ArrayBas.Items.Add(diziElemani);
                }

            }

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            lst_ArrayBas.Items.Clear();

            // Array.Copy() => Bir diziden başka bir diziye eleman kopyalamak için kullanılır. 
            string[] geciciDizi = new string[4];

            // 1. KULLANIM; 
            // Array.Copy(ornekDizi, geciciDizi, 3); 

            //  Array.Copy(ornekDizi, geciciDizi, 3);

            //foreach (var diziElemani in geciciDizi)
            //{
            //    MessageBox.Show(diziElemani);

            //    if (diziElemani != null)
            //    {
            //        lst_ArrayBas.Items.Add(diziElemani);
            //    }

            //}

            // 2. KULLANIM 


            //string[] ornekDizi = { "İstanbul", "Ankara", "İzmir", "Bursa", "Eskişehir", "Konya", "Trabzon", "Sivas", "Eskişehir" };

            Array.Copy(ornekDizi, 7, geciciDizi, 0, geciciDizi.Length);


            foreach (var diziElemani in geciciDizi)
            {
                // MessageBox.Show(diziElemani);

                if (diziElemani != null)
                {
                    lst_ArrayBas.Items.Add(diziElemani);
                }

            }

        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            // Array.IndexOf => Dizide aradığımız elemanın INDEX numarasını döndüren metottur.. 
            // Eğer aradığınız değer dizi içerisinde mevcut değilse size -1 döndürür ! ... 
            // Eğer eleman dizide birden fazla defa geçiyor ise, size ilk elemanın INDEX'i dönecektir.. 

            int aranilanIndex = Array.IndexOf(ornekDizi, "Eskişehir");
            MessageBox.Show("Aradığınız şehrin indexi: " + aranilanIndex);

        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            // Array.LastIndexOf() => Dizide aradığınız birden fazla defa geçiyorsa, size son geçtiği yerin INDEX'ini teslim eder. 
            // Eğer aradığınız değer dizi içerisinde mevcut değilse size -1 döndürür ! ... 

            int aranilanSonIndex = Array.LastIndexOf(ornekDizi, "Eskişehir");

            MessageBox.Show("Aradığınız elemanın son indexi: " + aranilanSonIndex);

            // Bir dizideki aradığınız elemanın birden fazla olup olmadığını kontrol ediniz. 

        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            // Array.Resize() => dizi elemanının sayısını arttırmak - azaltmak için kullanılan metottur... 

            Array.Resize<string>(ref ornekDizi, 32);

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // Array.Sort() => Diziyi sıralamak için kullanacağımız metot.. 

            Array.Sort(ornekDizi);

            foreach (var diziElemani in ornekDizi)
            {
                // MessageBox.Show(diziElemani);

                if (diziElemani != null)
                {
                    lst_ArrayBas.Items.Add(diziElemani);
                }

            }

        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            // Array.Reverse() => Dizinin elemanlarını tersine çevirmeye yarayan metottur. 

            Array.Reverse(ornekDizi);

            foreach (var diziElemani in ornekDizi)
            {
                // MessageBox.Show(diziElemani);

                if (diziElemani != null)
                {
                    lst_ArrayBas.Items.Add(diziElemani);
                }

            }

        }
    }
}
