using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SwitchAnimation_WPF.Controls
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


        public bool BoolValue
        {
            get { return (bool)GetValue(BoolValueProperty); }
            set { SetValue(BoolValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BoolValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BoolValueProperty =
            DependencyProperty.Register("BoolValue", typeof(bool), typeof(UserSwitch), new PropertyMetadata(false));



        public int UserWidth
        {
            get { return (int)GetValue(UserWidthProperty); }
            set { SetValue(UserWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UserWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UserWidthProperty =
            DependencyProperty.Register("UserWidth", typeof(int), typeof(UserSwitch), new PropertyMetadata(0));



        public int UserHeigth
        {
            get { return (int)GetValue(UserHeigthProperty); }
            set { SetValue(UserHeigthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UserHeigth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UserHeigthProperty =
            DependencyProperty.Register("UserHeigth", typeof(int), typeof(UserSwitch), new PropertyMetadata(0));




        public Color UserColor
        {
            get { return (Color)GetValue(UserColorProperty); }
            set { SetValue(UserColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UserColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UserColorProperty =
            DependencyProperty.Register("UserColor", typeof(Color), typeof(UserSwitch), new PropertyMetadata(Color.FromRgb(0,0,0)));


    }
}
