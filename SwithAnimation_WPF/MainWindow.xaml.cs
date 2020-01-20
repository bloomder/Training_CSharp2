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

namespace SwithAnimation_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public int MainWidth
        {
            get { return (int)GetValue(MainWidthProperty); }
            set { SetValue(MainWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MainWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MainWidthProperty =
            DependencyProperty.Register("MainWidth", typeof(int), typeof(MainWindow), new PropertyMetadata(0));



        public int MainHeigth
        {
            get { return (int)GetValue(MainHeigthProperty); }
            set { SetValue(MainHeigthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MainHeigth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MainHeigthProperty =
            DependencyProperty.Register("MainHeigth", typeof(int), typeof(MainWindow), new PropertyMetadata(0));


    }
}
