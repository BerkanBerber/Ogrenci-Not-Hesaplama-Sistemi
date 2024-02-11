namespace Öğrenci_Not_Hesaplama_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int matematikNot, fiziNot, biyolojiNot, turkceNot; //not değişkenleri

        double ortalama; //gelen not değerlerinin ortalaması için oluşturduğumuz değişken

        string ogrenciAd, ogrenciSoyad; //öğrenci adı ve soyadı için değşkenler

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            ogrenciAd = txtOgrenciAd.Text; //Öğrenci adı ogrenciad dan gelen text'e eşit
            ogrenciSoyad = txtOgrenciSoyad.Text; //Öğrenci soyadı ogrencisoyad dan gelen text'e eşit

            if (ogrenciAd != "" && ogrenciSoyad != "") //öğrenci ad ve soyad değeri boş olmadığında 
            {
                matematikNot = Convert.ToInt32(nmrMatematik.Value); //nmrMatematik'in textini değil de sayısal değerini almak için value yazdık.
                fiziNot = Convert.ToInt32(nmrFizik.Value); //fiziKnot değerine gelen değeri atadık
                biyolojiNot = Convert.ToInt32(nmrBiyoloji.Value); //üstteki işlemin aynısını tekrar ettik
                turkceNot = Convert.ToInt32(nmrTurkce.Value); //üstteki işlemin aynısını tekrar ettik

                double ortalamaDouble = (matematikNot + fiziNot + biyolojiNot + turkceNot) / 4.0; //Ortalama hesaplaması
                ortalama = (int)(ortalamaDouble * 100) / 100.0; // İki ondalık basamaklı yuvarlama işlemi

                liste.Items.Add(ogrenciAd + " " + ogrenciSoyad + " = " + ortalama.ToString("0.00")); /* *EKRANA ÖĞRENCİ ADI VE ORTALAMAYI YAZDIRDIK 
                                                                                                       STRİNGE CEVİREREK YAZ DEDİK İÇERİSİNE DE PARAMETRE OLARAK 0.00 İFADESİNİ YAZDIK
                                                                                                       ORTALAMA SONRASINDA YAPTIĞIMIZ İFADE ONDALIKLI SAYI HESAPLANDIĞINDA DİĞER İKİ BASAMAĞIN DA GÖRÜNMESİ İÇİN */


            }
            else
            {
                MessageBox.Show("Öğrenci adı ve soyadı boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); //ad ve soyad değerinin boş bırakılamayacağının uyarısını verdik
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            ogrenciAd = ""; //form yüklenir yüklenmez içinde ki değerleri sıfırladık çünkü boş bırakma durumunda hata mesajını almalıyız.
            ogrenciSoyad = "";
        }

       
    }
}
