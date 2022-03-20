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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //ARRAY - DİZİ
        //Birden fazla aynı tipteki veriyi bir arada tutmamızı sağlayan nesnelerimizdir...

        //EĞER;
        //Index was outside the bounds of the array.
        //hatası aliyorsanız, bilin ki dizinin boyutlarini asacak şekilde eleman ekleme çabasındasınız... Hata nerde diye bakma, eleman ekleme işlemlerine git!

        private void Form1_Load(object sender, EventArgs e)
        {// 1. TANIMLAMA 

            // VeriTipi[] diziAdi = new VeriTipi[ElemanSayisi];
            int[] sayilar;
            sayilar = new int[10];

            int[] dizi = new int[3];

            // null / 0 / 

            for (int i = 0; i < dizi.Length; i++)
            {
                MessageBox.Show(dizi[i].ToString());
            }


            foreach (int eleman in dizi)
            {
                MessageBox.Show(eleman.ToString());
            }

            //   Eleman ATAMA => int[] dizi = new int[3];

            dizi[1] = 5986;
            dizi[0] = 645;
            // dizi[2] = 'r'; => ASCII'deki karşılığı verir. 
            dizi[2] = 3248793;
            // dizi[3] = 123456;


            //MessageBox.Show(dizi[1].ToString());

            //dizi[1] = 1111;

            //MessageBox.Show(dizi[1].ToString());


            foreach (int eleman in dizi)
            {
                MessageBox.Show(eleman.ToString());
            }



            // ----------------------------------------------------- // 

            // 2. TANIMLAMA 

            // VeriTipi[] diziAdi = new VeriTipi[ElemanSayisi] { DizininElemanlari}

            string[] isimler = new string[4] { "Emre", "Sercan", "Yavuzeren", "Ekin" };

            // 3. TANIMLAMA 

            // VeriTipi[] degiskenAdi = { diziElemanlari }; 
            char[] kar;
            char[] karakterler = { 's', 'e', 'l', 'i', 'n' };

            // HATALI - sonradan çağırmaya çalışırsak... / RAM'de ayırmadığı bir yer için atama yapmasını beklememize kızıyor :) 
            // karakterler = { 's', 'e', 'l', 'i', 'n' };

        }
       

    }
}
