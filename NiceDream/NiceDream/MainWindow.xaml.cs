﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NiceDream
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        string fileName = "";
        string newFileName = "";
        public string saveText = "";
        string thisText = "";
        public string nowtime;

        public MainWindow()
        {
            InitializeComponent();
        }

        void Save()
        {
            Microsoft.Win32.SaveFileDialog dig = new Microsoft.Win32.SaveFileDialog();
            Nullable<bool> result = dig.ShowDialog();
            if (result == true)
            {
                System.IO.File.WriteAllText(dig.FileName, Textarea.Text);
                fileName = dig.FileName;
                saveText = thisText;
                TitlenameTxt.Text = dig.SafeFileName + ",txt";
            }
        }

        void Open()
        {
            Microsoft.Win32.OpenFileDialog dig = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> result = dig.ShowDialog();
            if (result == true)
            {
                Textarea.Text = System.IO.File.ReadAllText(dig.FileName);
                fileName = dig.FileName;
                saveText = Textarea.Text;
                TitlenameTxt.Text = dig.SafeFileName + ",txt";

            }
        }
        private void ListBtn_Click(object sender, RoutedEventArgs e)
        {
            ListWindow window2 = new ListWindow();
            window2.Show();
            this.Close();
        }

        private void SizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsInitialized == true)
            {
                Textarea.FontSize = SizeSlider.Value;
            }
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (fileName == newFileName)
            {
                Save();
            }
            else
            {
                System.IO.File.WriteAllText(fileName, Textarea.Text);
                saveText = thisText;
            }

        }

        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            Textarea.Text = "";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DateTb.Text = DateTime.Today.ToLongDateString();
        }

        private void DateTb_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            if (saveText != thisText)
            {
                if (MessageBox.Show("Do you want to Save?", "Save or Not", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    Save();
                    Open();
                }
                else
                {
                    Open();
                }
            
            }
            else
            {
                Open();
            }
        }
    }
}
