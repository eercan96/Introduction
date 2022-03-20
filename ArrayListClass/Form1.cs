using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
          * ARRAYLIST
          * 
          * Su zamana dek gordugumuz ilkel dizilerin (veriTipi[] olarak tanimlanan) en buyuk iki ozelliği;
          * TİP BAĞIMLILIĞI ve ELEMAN SAYISI ZORUNLULUĞU idi...
          * 
          * Ancak, ArrayList nesnesiyle birlikte bu bagimliliklar ortadan kalktı. Bir ArrayList'i meydana getirirken ne eleman sayisi vermek zorundasiniz ne de bir veri tipi belirtmek zorundasiniz..
          * 
          * Dezavantajı nedir?
          * ArrayList icerisindeki elemanlari otomatik olarak object veri tipine dondurme ozelligine sahiptir. Dolayisiyla bu verileri geri almak istediginiz mecburen bir "cast" ya da "convert" işlemine gerek duymaktasiniz... Bu da ekstra iki kat is demektir... (object => bilinene : unboxing islemi)
          * 
          * ArrayList'i kullanima acabilmek icin namespace'lere using System.Collections; ibaresini eklemelisiniz...
      */

        //Dizinizi asagidaki gibi olustursaniz, eleman sayisi belirtmis olarak olusturmus olursunuz...
        //ArrayList yeniDizi = new ArrayList(20); 

        ArrayList yeniDizi = new ArrayList();

        private void Form1_Load(object sender, EventArgs e)
        {
            yeniDizi.Add("İstanbul");
            yeniDizi.Add("Ankara");
            yeniDizi.Add("İzmir");
            yeniDizi.Add("Bursa");
            yeniDizi.Add("Eskişehir");
            yeniDizi.Add("Edirne");
            yeniDizi.Add("Ardahan");
            yeniDizi.Add("Antalya");
            yeniDizi.Add("Gaziantep");
            yeniDizi.Add(1);
            yeniDizi.Add(true);
            yeniDizi.Add("Eskişehir");


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            foreach (object sehir in yeniDizi)
            {
                MessageBox.Show(sehir.ToString());
            }

        }

        private void btnMetotlar_Click(object sender, EventArgs e)
        {
            // Bir elemanı yakalama.. 
            this.Text = (string)yeniDizi[0];

            // Dizinin eleman sayısını yakalama.. 
            this.Text = yeniDizi.Count.ToString();
            int diziElemanSayisi = yeniDizi.Count;

            // Eleman dizide var mı yok mu ? ..
            this.Text = yeniDizi.Contains("Eskişehir") ? "Bu şehir elimizde mevcuttur:)" : "Taze bitti :)) ";

            // Dizideki elemanın indexini yakalama.. 
            this.Text = yeniDizi.IndexOf("Eskişehir").ToString();
            this.Text = yeniDizi.LastIndexOf("Eskişehir").ToString();

            // Araya eleman ekleme.. 
            yeniDizi.Insert(3, "Malatya");

            // Elemanı çağırma.. 
            this.Text = yeniDizi[3].ToString();

        }
    }
}
