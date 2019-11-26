using System;
using System.Windows;

namespace Background_Video
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mediaElement.Play();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Play();
        }
    }
}
