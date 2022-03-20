using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatch
{
    public partial class Form1 : Form
    {
        /*
      * İSTİSNA TİPLERİ
      * 
      * Çalışma Zamanı Hataları (Runtime Exception) => Çoğunlukla kullanıcı kaynaklı hatalardır. (Verinin yanlış, eksik ya da boş girilmesi). Çözum Yolu, try-catch ile hataları ele alabilirsiniz...
      * 
      * Derleme Zamani Hataları (Compile Exception) => Tamamen yazılımcı kaynaklı hatalardır. Yazım hataları meydana geldiğinde devreye girer. En kolay çözulen hata tipidir. Visual Studio sizi uyarır (aşağıdaki Error List penceresi ile). İlgili hataya çift tiklayıp detaya gidebilir ve hatayı anında düzeltebilirsiniz...
      * 
      * Mantıksal Hatalar => Tamamen programcı kaynaklı hatalardır. Uygulamanın algoritmasında meydana gelir. Örneğin bolme yapilacak yerde işlem unutulması, değerin yanlış bir değerle değiştirilmesi... Çözulmesi en zor hatalardır. Anlık olarak derleme aşamasını takip etmeli ve değerlerinizi gözlemlemelisiniz. Bu konuda Visual Studio size sağladıgı tool'larla yardımcı olur. (Immediate Window, Watch, Breakpoint)
      */

        /*
         * BREAKPOINT => Derleme aşamasına adım adım dahil olmak için kullandığımız yardımcı tool'dur. Yapmanız gereken tek şey, hangi satırdan derleme anına dahil olmak istiyorsanız, ilgili satırın en sol kismina gelip (gri alan) mouse'un sol tuşuyla bir kırmızı top yerleştirmek. Artık derleyici bu satıra geldigi zaman sizi olaya dahil edecektir...
         * F11 ile adım adım ilerleyebilirsiniz. Değişkenlerin, nesnelerin üzerine gelip o anki değerlerini öğrenebilirsiniz, işlemin bittiğine inanıyorsanız F5'e basıp breakpoint'ten çıkabilir ve işlemin kendisini devam ettirmesini sağlayabilirsiniz.
         * Sol blokta çikan sari ok, derlenen satırın işaretçisidir. Mouse yardımıyla ileri ya da geri oynatabilir yani adımlari atlayabilir ya da tekrarlatabilirsiniz...
         */

        /*
         * WATCH
         * Yalnızca run-time'da - çalışma zamanı - kullanabileceğimiz bir tool'dur. Dolayısıyla pencereyi sadece çalışma zamanında görürsünüz...
         * İlk ayarlarınızda Watch penceresi kapali olabilir. Uygulamanızı çalışturıp "CTRL+ALT+W" ardından 1'e basarsanız Watch penceresini getirirsiniz...
         * Run-time'de elinizde olan değerleri (kontrol değerler, değişken değerleri) değiştirmenize, izlemenize olanak sağlayan yardımcı tool'dur. Açılan penceredeki "Name" alanına ilgili değişkenin adını yazıp Enter'a basarsanız, "Value" alanında o anki değerini gözlemleyebilirsiniz. Hatta değiştirebilirsiniz...
         * "Name" alanına değeri ilk yazmaya başladığınızda intellisense size destek vermez. Ancak "CTRL+Space" kombinasyonu ile intellisense'i aktif hale getirebilirsiniz. Hatta coğu zaman kendisi otomatik olarak tamamlar. 
         * Noktalar, virgüller, noktali virgüller - yani tüm yazim kuralları - watch penceresi için de geçerlidir...
         */

        //Eger disaridan bir veri aliyorsaniz, verinin tutarligindan emin de degilseniz, orada mutlaka hata riski vardır!
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            int gelenDeger = Convert.ToInt32(txtGirisAlani.Text);
            MessageBox.Show("Tebrikler! Doğru telefon formatı girdiniz!");
        }

        private void btnHataYonetimliOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                //Bu alana hata riski olan kodlar yazilir...
                int gelen = Convert.ToInt32(txtGirisAlani.Text);
                MessageBox.Show("Tebrikler! Doğru telefon formatı girdiniz!");
            }
            catch
            {
                //Try blogu icerisine yazmis oldugunuz kodlarda herhangi bir hata meydana gelirse, catch blogu devreye girer...
                MessageBox.Show("Telefon numarası yazmayı bile beceremedin!");
            }

        }

        private void btnDetayliOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                int gelen = Convert.ToInt32(txtGirisAlani.Text);
                MessageBox.Show("Tebrikler! Doğru formatı girdiniz!");
            }
            catch (Exception hata)
            {
                //catch ifadesinin yanindaki "Exception"ın kelime anlami => Istisna..
                //Uygulamanizin kararligini bozan istisnai durumla ilgili size detaylari teslim eden nesnedir...
                MessageBox.Show(hata.Message);  //Hata'nın sistem tarafindan atanan mesajini size teslim eder...
                MessageBox.Show(hata.Source);
            }

        }

        private void btnFinallyOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                int gelen = Convert.ToInt32(txtGirisAlani.Text);
                MessageBox.Show("Tebrikler!");
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                //Hata olsa da olmasa da calismasini istediginiz kodlari yazdiginiz alandir... Try-Catch-Finally uclusunde en son calisir...
                MessageBox.Show("Hata var mı yok mu bilmiyorum ama çalıştım!");
            }

        }
    }
}
