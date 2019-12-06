using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace UserControl_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string path;
        public MainWindow()
        {
            InitializeComponent();
            path = Environment.CurrentDirectory;
            path += "\\Theme\\1.mp4";
        }
        private void ME_MediaEnded(object sender, RoutedEventArgs e)
        {
            MediaElement me = (MediaElement)sender;
            me.Stop();
            me.Play();
        }
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {            
            MessageBox.Show(File.Exists(path).ToString());
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == true)
            {
                ME.Source = new Uri(dialog.FileName, UriKind.RelativeOrAbsolute);
                ME.Play();
            }
        }
    }
}
