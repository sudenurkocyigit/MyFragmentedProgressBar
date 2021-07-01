using System; // EventArgs için System ad alanını ekledik.

/// <summary>
/// MyFragmentedProgressBar kısaltması olarak ad alanı yani proje adı tanımladık.
/// </summary>
namespace MFPB
{
    /// <summary>
    /// Form sınıfından kalıtım yaptığımız Form parçalı sınıfımız.
    /// </summary>
    public partial class Form:System.Windows.Forms.Form
    {
        /// <summary>
        /// Yapıcı metodumuz.
        /// </summary>
        public Form() => InitializeComponent();

        /// <summary>
        /// Butona tıklama olayımız.
        /// </summary>
        /// <param name="sender">Gönderici parametremiz.</param>
        /// <param name="e">Olay argümanları parametremiz.</param>
        private void button_Click(object sender,EventArgs e) => timer.Enabled=true;

        /// <summary>
        /// Bileşene atadığımız zamanlayıcı tiki olayımız.
        /// Value değerimiz 100'den büyükse yükseltip 100'den küçükse ekleme yapacağımız yer burasıdır.
        /// </summary>
        /// <param name="sender">Gönderici parametremiz.</param>
        /// <param name="e">Olay argümanları parametremiz.</param>
        private void timer1_Tick(object sender,EventArgs e)
        {
            //Sol Üst Parçalanmış İlerleme Çubuğu
            if(myFragmentedProgressBar0.Yuzde<myFragmentedProgressBar0.EnFazlaDeger)
                myFragmentedProgressBar0.Yuzde+=64;
            else
                myFragmentedProgressBar0.Yuzde=0;

            //Sol Orta Parçalanmış İlerleme Çubuğu
            if(myFragmentedProgressBar1.Yuzde<myFragmentedProgressBar1.EnFazlaDeger)
                myFragmentedProgressBar1.Yuzde+=32;
            else
                myFragmentedProgressBar1.Yuzde=0;

            //Sol Alt Parçalanmış İlerleme Çubuğu
            if(myFragmentedProgressBar2.Yuzde<myFragmentedProgressBar2.EnFazlaDeger)
                myFragmentedProgressBar2.Yuzde+=16;
            else
                myFragmentedProgressBar2.Yuzde=0;

            //Sağ Üst Parçalanmış İlerleme Çubuğu
            if(myFragmentedProgressBar3.Yuzde<myFragmentedProgressBar3.EnFazlaDeger)
                myFragmentedProgressBar3.Yuzde+=8;
            else
                myFragmentedProgressBar3.Yuzde=0;

            //Sağ Orta Parçalanmış İlerleme Çubuğu
            if(myFragmentedProgressBar4.Yuzde<myFragmentedProgressBar4.EnFazlaDeger)
                myFragmentedProgressBar4.Yuzde+=4;
            else
                myFragmentedProgressBar4.Yuzde=0;

            //Sağ Alt Parçalanmış İlerleme Çubuğu
            if(myFragmentedProgressBar5.Yuzde<myFragmentedProgressBar5.EnFazlaDeger)
                myFragmentedProgressBar5.Yuzde+=2;
            else
                myFragmentedProgressBar5.Yuzde=0;
        }
    }
}
