using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;


namespace ClickGame
{
    public partial class Arena : Window
    {
        private int saglık = 100;
        private int düsmansaglık = 100;

        Random random = new Random();

        public Arena()
        {
            InitializeComponent();
            tllabel.Content = GameData.Sayac.ToString();

        }

      





        private void saldirbutton_Click(object sender, RoutedEventArgs e)
        {
            
               



            int oyuncuhasar = random.Next(5, 15);
                int düsmanhasar = random.Next(5, 15);


                saglık -= düsmanhasar;
                düsmansaglık -= oyuncuhasar;


                canlabel.Text = saglık.ToString();
                düsmancanlabel.Text = düsmansaglık.ToString();


                bildiritextblock.Text = $"Oyuncu hasarı: {oyuncuhasar}, Düşman hasarı: {düsmanhasar}";


                if (saglık <= 0)
                {
                    bildiritextblock.Text = "Kaybettiniz!";
                    saldirbutton.IsEnabled = false;
                    marketbutton.Width = 150;

                }


                if (düsmansaglık <= 0)
                {
                    bildiritextblock.Text = "Tebrikler 200 TL Kazandınız!";
                    GameData.Sayac = GameData.Sayac + 200;
                    saldirbutton.IsEnabled = false;
                    marketbutton.Width = 150;
                    bosspng.Width = 0;
                }
            
        }

        private void marketbutton_Click(object sender, RoutedEventArgs e)
        {
            Market market = new Market();
            this.Close();
            market.Show();
        }
    }
}
