using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCaseStructure
{
    /*
         * SWITCH - CASE
         * IF-Else mantığıyla calisan bir kontrol mekanizmasidir. Aradaki fark, if-else yapisi büyüklük-küçüklük gibi durumları kontrol ederken,
         * switch-case yalnızca eşitlik durumlarını kontrol edebilen karar yapımızdır. Kendisine ait bir index mekanizması ile koşulları algılar, 
         * sıraya koyar ve otomatik olarak yüzlerce koşulunuz olsa bile her birine bakmadan hangisine uyduğunu bulabilir. Bu da performansı direktman etkiler.
         * Switch bloğu içerisine yazdığınız veri tipiniz ne ise, case (durum) olarak belirttiğiniz tüm veriler de aynı veri tipinde olmalıdır!
         * break => Kşul sağlandi, artık karar yapısından kendini dışarı atabilirsin mesajini sisteme verir...
         */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            //Dışarıdan mevsim girilsin, aylar dönsün...
            switch (txtGirisAlani.Text)
            {
                case "Kış":
                    MessageBox.Show("Aralık-Ocak-Şubat");
                    break;

                case "İlkbahar":
                    MessageBox.Show("Mart-Nisan-Mayıs");
                    break;

                case "Yaz":
                    MessageBox.Show("Haziran-Temmuz-Ağustos");
                    break;

                case "Sonbahar":
                    MessageBox.Show("Eylül-Ekim-Kasım");
                    break;

                //Default => Öngorülen bir durum harici değerle karşılaşırsak, varsayılan olarak karar yapısı ne gibi bir işlem uygulasın. Tamamen opsiyoneldir. Kullanmasak da olur...
                default:
                    MessageBox.Show("Böyle bir mevsim hiç duymadım!");
                    break;
            }

        }

        private void btnKullaniciKontrolu_Click(object sender, EventArgs e)
        {
            //Eğer ilk textbox'a "Admin","Moderator","Yonetici","CEO","Baskan" değerleri girilirse "Yönetim Paneline Yönlendiriliyorsunuz..."
            //"Uye" girilirse "Ana Sayfaya Yönlendiriliyorsunuz...";
            //Harici bir durumda "Bu Sayfayı Görme Yetkiniz Yok!";

            //Bir string metodu olan ToLower, ilgili metinsel ifadenin tamamını küçük harfe çevirmekle yükümlüdür.

            string girilenDeger = txtGirisAlani.Text.ToLower();
            switch (girilenDeger)
            {
                case "admin":
                case "moderator":
                case "yonetici":
                case "ceo":
                case "baskan":
                    MessageBox.Show("Yönetim Paneline Yönlendiriliyorsunuz...");
                    break;

                case "uye":
                    MessageBox.Show("Ana Sayfaya Yönlendiriliyorsunuz...");
                    break;

                default:
                    MessageBox.Show("Bu Sayfayı Görme Yetkiniz Yok!");
                    break;
            }

        }

        private void btnIcIceSwitch_Click(object sender, EventArgs e)
        {
            //İç içe switch kullanarak kullanıcı adını ve şifresini kontrol ediniz. Eğer kullanıcı kullanıcıadını ve şifresini doğru girerse "Tebrikler, hem kullanıcı adı hemde şifreniz doğru" uyarısı
            //Kullanıcı adı doğru şifre yanlışsa "Kullanıcı adınız doğru ancak şifreniz yanlış!" uyarısı
            //kullanıcı adı yanlışsa "Kullanıcı adınızı yanlış girdiniz, şifreye bakmadım bile!" uyarusını kullanıcıya veriniz.

            //KullaniciAdi = "bilgeselin";
            //Sifre = "1234";
            string KullaniciAdi = txtGirisAlani.Text;
            string Sifre = txtIkinciGirisAlani.Text;

            switch (KullaniciAdi)
            {
                case "kullanici":
                    switch (Sifre)
                    {
                        case "1234":
                            MessageBox.Show("Tebrikler, hem kullanıcı adı hem de şifreniz doğru!");
                            break;
                        default:
                            MessageBox.Show("Kullanıcı adınız doğru ancak şifreniz yanlış!");
                            break;
                    }
                    break;
                default:
                    MessageBox.Show("Kullanıcı adınızı yanlış girdiniz, şifreye bakmadım bile!");
                    break;
            }

        }
    }
}
