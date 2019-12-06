using Microsoft.Win32;
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
        }

        private void ME_MediaEnded(object sender, RoutedEventArgs e)
        {
            MediaElement me = (MediaElement)sender;
            me.Stop();
            me.Play();
        }
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == true)
            {
                ME.Source = new Uri(dialog.FileName, UriKind.RelativeOrAbsolute);
                ME.Play();
            }
        }
    }
}
