using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCalculation
{
    public partial class Form1 : Form
    {
        //1) O anda textbox üzerinde kaç karakter var ise yakalanır...
        //2) lblKalanKarakter'de yazan yazı alınır ve textbox'taki karakter sayısıyla arasındaki fark alınır...
        //3) Ortaya çıkan yeni sonuç, lblKalanKarakter'e yazdırılır..
        int counter;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtMetinAlani_TextChanged(object sender, EventArgs e)
        {
            int nowCharacter = txtMetinAlani.Text.Length;
            int diffran = counter - nowCharacter;
            lblKalanKarakter.Text = diffran.ToString();

        }

        private void lblKalanKarakter_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            counter = 450;
        }
    }
}
