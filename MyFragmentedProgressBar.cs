using System; // EventArgs için System ad alanımızı tanımladık.
using System.Drawing; // Çizim işlemlerini kullanabilmemiz için Drawing kütüphanemiz.
using System.Windows.Forms; // Form işlevselliğini kullanabilmek için kütüphanemiz.

/// <summary>
/// MyFragmentedProgressBar kısaltması olarak ad alanı yani proje adı tanımladık.
/// </summary>
namespace MFPB
{
    /// <summary>
    /// UserControl sınıfından kalıtım yaptığımız MyFragmentedProgressBar parçalı sınıfımız.
    /// </summary>
    public partial class MyFragmentedProgressBar:UserControl
    {
        /// <summary>
        /// Değişkenlerimizi burada tanımladık.
        /// </summary>
        private int ReferansDeger = 0;

        /// <summary>
        /// Özelliklerimizi de burada tanımladık.
        /// </summary>
        public int Yuzde { get; set; } = 0; // O anki değer.
        public Color Renk { get; set; } = Color.Green;
        public int EnFazlaDeger { get; set; } = 100;
        public int DikdortgenBoyutu { get; set; } = 10; // Dikdörtgen Boyutu

        /// <summary>
        /// Oluşturucu metodumuzu burada tanımladık.
        /// </summary>
        public MyFragmentedProgressBar() => InitializeComponent();

        /// <summary>
        /// Çizim işlemlerimizi bir for döngüsüyle çeşitli kontrollere sokarak yapan Paint olayımız burada yer almaktadır.
        /// Formüle kadar birer artarak giderken her adımda grafik oluşturup dolduran kodumuz burada yer almaktadır.
        /// </summary>
        /// <param name="sender">Gönderici parametremiz.</param>
        /// <param name="e">Çizim olay argümanları parametremiz.</param>
        private void MyFragmentedProgressBar_Paint(object sender,PaintEventArgs e)
        {
            SolidBrush firca = new SolidBrush(Renk);
            int x = 0;
            for(int i = 0;i<Yuzde*Width/EnFazlaDeger/DikdortgenBoyutu;i++)
            {
                CreateGraphics().FillRectangle(firca,new RectangleF(x,1,DikdortgenBoyutu-1,Height-2));
                x+=DikdortgenBoyutu;
            }
        }

        /// <summary>
        /// Özelleştirilmiş parçalı ilerleme çubuğumuzda yer alan zamanlayıcımızın tick olayları burada yer almaktadır.
        /// İlerleme kontrolü burada sağlanmaktadır.
        /// </summary>
        /// <param name="sender">Gönderici parametremiz.</param>
        /// <param name="e">Çizim olay argümanları parametremiz.</param>
        private void timer1_Tick(object sender,EventArgs e)
        {
            if(ReferansDeger!=Yuzde)
            {
                ReferansDeger=Yuzde;
                Refresh(); // Yenileme fonksiyonumuz.
            }
        }

        /// <summary>
        /// İlerleme çubuğumuzun yüklenmesinde zamanlayıcıyı aktif etmek için olan fonksiyonumuz.
        /// </summary>
        /// <param name="sender">Gönderici parametremiz.</param>
        /// <param name="e">Çizim olay argümanları parametremiz.</param>
        private void MyFragmentedProgressBar_Load(object sender,EventArgs e)
        {
            timer1.Enabled=true;
        }
    }
}

// Sude Nur Koçyiğit
// 201913709088