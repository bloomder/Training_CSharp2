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


        public int UserWidth
        {
            get { return (int)GetValue(UserWidthProperty); }
            set { SetValue(UserWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UserWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UserWidthProperty =
            DependencyProperty.Register("UserWidth", typeof(int), typeof(UserSwitch), new PropertyMetadata(50));



        public int UserHeigth
        {
            get { return (int)GetValue(UserHeigthProperty); }
            set { SetValue(UserHeigthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for UserHeigth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UserHeigthProperty =
            DependencyProperty.Register("UserHeigth", typeof(int), typeof(UserSwitch), new PropertyMetadata(100));


    }
}
