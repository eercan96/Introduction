using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileLoop
{
    public partial class Form1 : Form
    {
        /*
           WHILE
           1) For'un parcalanmis halidir...
           2) For ile yapabildiginiz herseyi rahatlikla yapabilirsiniz...
           3) For'dan farki, metotlardan gelen cevaplara gore islem yapabilme yetenegine sahip olmasidir... (ORNEK => ADO.NET konusunda deginecegimiz, "okuyabildigin kadar oku..." metodu gibi... 
         */
        public Form1()
        {
            InitializeComponent();
        }
        //Aşağıdaki örnek bir sonsuz döngü orneğidir. Anlatmaya calisilan sey ise, metotlarin dondurecegi bool degerlere gore while'ın karar verebilme yetenegidir...
        //bool sonuc = false;
        //while (!sonuc)
        //{
        //    listBox1.Items.Add('a');
        //}
        private void btnOrnekBir_Click(object sender, EventArgs e)
        {
            int i = 1;

            while (i <= 100)
            {
                listBox1.Items.Add(i);
                i++;
            }

        }

        private void btnOrnekIki_Click(object sender, EventArgs e)
        {
            int index = 0;

            while (index < this.Controls.Count)
            {
                if (this.Controls[index] is Button)
                {
                    this.Controls[index].Width += 100;
                    this.Controls[index].Top += 20;
                }

                index++;
            }

        }
    }
}
