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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBtn_Click(object sender, RoutedEventArgs e)
        {

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

        }

        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            Textarea.Text = "";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DateTb.Text = DateTime.Today.ToLongDateString();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DateTb_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
