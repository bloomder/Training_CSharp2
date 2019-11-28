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
using System.Windows.Navigation;
using System.Windows.Shapes;

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
