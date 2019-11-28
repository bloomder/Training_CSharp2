using System;
using System.Windows;
using System.Windows.Controls;

namespace UserControl_WPF.UserControls
{
    /// <summary>
    /// Логика взаимодействия для MediaControl.xaml
    /// </summary>
    public partial class MediaControl : UserControl
    {
        public static string path;
        public MediaControl()
        {
            InitializeComponent();
            path = Environment.CurrentDirectory;            
            path += "/Theme/1.mp4";
            ME.Source = new Uri(path);
            MessageBox.Show(ME.Source.ToString());
            ME.Play();
        }

        private void ME_MediaEnded(object sender, RoutedEventArgs e)
        {
            MediaElement me = (MediaElement)sender;
            me.Stop();
            me.Play();
        }
    }
}
