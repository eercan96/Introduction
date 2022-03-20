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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //DONGULER - LOOPS
        //Bir baslangic degeri olan, belirli bir kosul gerceklesene dek suren ve bu surec icerisinde bir takim islemleri tekrarli olarak gerceklestiren nesnelere "dongu" adini vermekteyiz.
        //FOR - FOREACH - WHILE - DOWHILE

        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //Donguye ilk giris aninda derleyici baslangic degerine bakar ve bir daha asla bu bloga ugramaz. 
            //Bundan sonraki islemler once arttir, daha sonra kosula bak, kosul uygunsa dongunun kod blogunu harekete gecir, uygun degilse donguden cik...

            //for(BaslangicDegeri; BitisKosulu; Artis-AzalisMiktari)
            for (int deger = 1; deger <= 1000; deger++)
            {
                listBox1.Items.Add(deger);
            }

        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int deger = 1000; deger >= 1; deger--)
            {
                listBox1.Items.Add(deger);
            }

        }

        private void btnOrnekUc_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            for (int i = 2; i <= 1000; i += 2)
            {
                listBox1.Items.Add(i);
            }

        }

        private void btnOrnekDort_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //Char'lar arkaplanda ASCII degerler barindirirlar... Char'ları Int32'ye cevirirseniz size ASCII degerlerini teslim ederler...
            for (char c = 'A'; c <= 'Z'; c++)
            {
                listBox1.Items.Add(c + " - " + Convert.ToInt32(c));
                //  listBox1.Items.Add($"{c} - {Convert.ToInt32(c)}");
            }

        }

        private void btnOrnekBes_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            //1-100 arasındaki sayilarin toplamini ekrana yazdiriniz..
            int toplam = 0;
            for (int i = 0; i <= 100; i++)
            {
                toplam += i;
            }
            MessageBox.Show("Toplam => " + toplam);

            //   MessageBox.Show($"Toplam => {toplam}");

        }

        private void btnOrnekAlti_Click(object sender, EventArgs e)
        {
            //1-100 arasindaki cift sayilarin toplami ile, tek sayilarin toplaminin farklari karesi kactir?
            int CiftlerinToplami = 0;
            int TeklerinToplami = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    CiftlerinToplami += i;
                }
                else
                {
                    TeklerinToplami += i;
                }
            }

            int sonuc = (CiftlerinToplami - TeklerinToplami) * (CiftlerinToplami - TeklerinToplami);
            MessageBox.Show(sonuc.ToString());

        }

        private void btnOrnekYedi_Click(object sender, EventArgs e)
        {
            //1945 - günümüz yılı arasındaki yıllar Listbox'a eklensin ancak 1990 ve 1992 yılları eklenmeyecek...
            for (int i = 1945; i <= DateTime.Now.Year; i++)
            {
                if (i >= 1950 && i <= 1970)
                {
                    // Farklı bir şeyler de istersek(yukarıda karar yapısı içinde tanımlandığı ve benzeri şekillerde) ayrı karar yapıları ile kontrol ettirebiliriz....
                }
                if (i != 1990 && i != 1992)
                {
                    listBox1.Items.Add(i);
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
