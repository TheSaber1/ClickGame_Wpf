using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static ClickGame.MainWindow;

namespace ClickGame
{
    
    public partial class Market : Window
    {
        public Market()
        {
            InitializeComponent();
            tllabel.Content = GameData.Sayac.ToString();
        }
        private void oyunbutton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
     
        }
        private void kazmabutton_Click(Object sender, RoutedEventArgs e)
        {
            if (GameData.Sayac < 50)
            {
                popup popup = new popup();
                popup.Owner = this;
                popup.ShowDialog();
            }

           else
            {
                if (kazmavarmi.Kazmavarmi == true)
                {
                    popupmarket popupmarket = new popupmarket();
                    popupmarket.Owner = this;
                    popupmarket.ShowDialog();
                }
                else
                {

                    GameData.Sayac = GameData.Sayac - 50;
                    tllabel.Content = GameData.Sayac.ToString();
                    kazmavarmi.Kazmavarmi = true;
                }
            }
        }

        private void arenabutton_Click(object sender, RoutedEventArgs e)
        {
            if (GameData.Sayac < 0)
            {
                popup popup = new popup();
                popup.Owner = this;
                popup.ShowDialog();
            }
            else
            {
                GameData.Sayac = GameData.Sayac - 100;
                tllabel.Content = GameData.Sayac.ToString();

                Arena arena = new Arena();
                arena.Show();
                this.Hide();
            }
        }

       
    }
}
     


