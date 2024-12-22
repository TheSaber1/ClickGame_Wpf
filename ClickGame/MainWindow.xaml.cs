using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static ClickGame.MainWindow;

namespace ClickGame
{

    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();
            if (GameData.Sayac != 0)
            {
                tllabel.Content = GameData.Sayac.ToString();
            }
        }

        private void tlbutton_Click(object sender, RoutedEventArgs e)
        {

           

                if (kazmavarmi.Kazmavarmi == true)
                {

                    GameData.Sayac = GameData.Sayac + 2;
                    tllabel.Content = GameData.Sayac.ToString();
                }
                else
                {
                    GameData.Sayac = GameData.Sayac + 1;
                    tllabel.Content = GameData.Sayac.ToString();
                }
            

           

        }




        private void marketbutton_Click(object sender, RoutedEventArgs e)
        {
            GameData.Sayac = int.Parse(tllabel.Content.ToString());
            Market market = new Market();
            this.Hide();
            market.Show();

        }

        private void demirbutton_Click(object sender, RoutedEventArgs e)
        {
            if (GameData.Sayac > 24)
            {

                if (kazmavarmi.Kazmavarmi == true)
                {

                    GameData.Sayac = GameData.Sayac + 10;
                    tllabel.Content = GameData.Sayac.ToString();
                }
                else
                {
                    GameData.Sayac = GameData.Sayac + 5;
                    tllabel.Content = GameData.Sayac.ToString();
                }
            }

            else
            {
                popup popup = new popup();
                popup.Owner = this;
                popup.ShowDialog();


            }

        }

        private void altinbutton_Click(object sender, RoutedEventArgs e)
        {
            if (GameData.Sayac > 199)
            {

                if (kazmavarmi.Kazmavarmi == true)
                {

                    GameData.Sayac = GameData.Sayac + 20;
                    tllabel.Content = GameData.Sayac.ToString();
                }
                else
                {
                    GameData.Sayac = GameData.Sayac + 10;
                    tllabel.Content = GameData.Sayac.ToString();
                }
            }

            else
            {
                popup popup = new popup();
                popup.Owner = this;
                popup.ShowDialog();


            }

        }

        private void elmasbutton_Click(object sender, RoutedEventArgs e)
        {
            if (GameData.Sayac > 999)
            {

                if (kazmavarmi.Kazmavarmi == true)
                {

                    GameData.Sayac = GameData.Sayac + 100;
                    tllabel.Content = GameData.Sayac.ToString();
                }
                else
                {
                    GameData.Sayac = GameData.Sayac + 50;
                    tllabel.Content = GameData.Sayac.ToString();
                }
            }

            else
            {
                popup popup = new popup();
                popup.Owner = this;
                popup.ShowDialog();


            }

        }
        private void ruhbutton_Click(object sender, RoutedEventArgs e)
        {
            if (GameData.Sayac > 4999)
            {

                if (kazmavarmi.Kazmavarmi == true)
                {

                    GameData.Sayac = GameData.Sayac + 200;
                    tllabel.Content = GameData.Sayac.ToString();
                }
                else
                {
                    GameData.Sayac = GameData.Sayac + 100;
                    tllabel.Content = GameData.Sayac.ToString();
                }
            }

            else
            {
                popup popup = new popup();
                popup.Owner = this;
                popup.ShowDialog();


            }

        }
    }
    public static class GameData
    {

        public static int Sayac { get; set; }
    }

    public static class kazmavarmi
    {

        public static bool Kazmavarmi { get; set; }
    }
}
