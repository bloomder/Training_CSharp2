using System.Windows;
using System.Windows.Controls;

namespace SwithAnimation_WPF.Controls
{
    /// <summary>
    /// Логика взаимодействия для UserSwitch.xaml
    /// </summary>
    public partial class UserSwitch : ContentControl
    {
        public UserSwitch()
        {
            InitializeComponent();
        }


        public int GridHeigth
        {
            get { return (int)GetValue(GridHeigthProperty); }
            set { SetValue(GridHeigthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for GridHeigth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GridHeigthProperty =
            DependencyProperty.Register("GridHeigth", typeof(int), typeof(UserSwitch), new PropertyMetadata(0));



        public int GridWidth
        {
            get { return (int)GetValue(GridWidthProperty); }
            set { SetValue(GridWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for GridWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GridWidthProperty =
            DependencyProperty.Register("GridWidth", typeof(int), typeof(UserSwitch), new PropertyMetadata(0));



        public string RectColor
        {
            get { return (string)GetValue(RectColorProperty); }
            set { SetValue(RectColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RectColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RectColorProperty =
            DependencyProperty.Register("RectColor", typeof(string), typeof(UserSwitch), new PropertyMetadata(""));



        public string RectFill
        {
            get { return (string)GetValue(RectFillProperty); }
            set { SetValue(RectFillProperty, value); }
        }

        // Using a DependencyProperty as the backing store for RectFill.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty RectFillProperty =
            DependencyProperty.Register("RectFill", typeof(string), typeof(UserSwitch), new PropertyMetadata(""));


    }
}
