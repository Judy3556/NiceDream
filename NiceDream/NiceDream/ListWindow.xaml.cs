using System;
using System.Collections.Generic;
using System.Linq;
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

namespace NiceDream
{
    
    /// <summary>
    /// ListWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ListWindow : Window
    {
        public int count = 0;
        public ListWindow()
        {
            InitializeComponent();
            MusicMe.MediaEnded += MusicMe_MediaEnded;
        }

        private void MusicMe_MediaEnded(object sender, RoutedEventArgs e)
        {
            MusicMe.Play();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window1 = new MainWindow();
            window1.Show();
            this.Close();
        }

        // 關閉視窗按鈕
        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }


        private void ListTitle_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindow maintxt = new MainWindow();

           

        }

        private void PlayerPause()
        {
            if (PLayBtn.Content.ToString() == "Play")
            {
                MusicMe.Play();
                PLayBtn.Content = "Pause";
                MusicMe.ToolTip = "Click to Pause";
            }
            else
            {
                MusicMe.Pause();
                PLayBtn.Content = "Play";
                MusicMe.ToolTip = "Click to Play";
            }
        }

        private void PLayBtn_Click(object sender, RoutedEventArgs e)
        {
            PlayerPause();
        }

        private void MusicMe_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

    }
}
