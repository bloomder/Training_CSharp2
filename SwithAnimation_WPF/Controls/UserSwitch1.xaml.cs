using System.Windows;
using System.Windows.Controls;

namespace SwithAnimation_WPF.Controls
{
    /// <summary>
    /// Логика взаимодействия для UserSwitch1.xaml
    /// </summary>
    public partial class UserSwitch1 : ContentControl
    {
        public UserSwitch1()
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
            DependencyProperty.Register("UserWidth", typeof(int), typeof(UserSwitch1), new PropertyMetadata(0));

        public int UserHeigth
        {
            get { return (int)GetValue(UserHeigthProperty); }
            set { SetValue(UserHeigthProperty, value); }
        }
        // Using a DependencyProperty as the backing store for UserHeigth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UserHeigthProperty =
            DependencyProperty.Register("UserHeigth", typeof(int), typeof(UserSwitch1), new PropertyMetadata(0));

        public bool UserValue
        {
            get { return (bool)GetValue(UserValueProperty); }
            set { SetValue(UserValueProperty, value); }
        }
        // Using a DependencyProperty as the backing store for UserValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty UserValueProperty =
            DependencyProperty.Register("UserValue", typeof(bool), typeof(UserSwitch1), new PropertyMetadata(false));



        public int EllipseHeigth
        {
            get { return (int)GetValue(EllipseHeigthProperty); }
            set { SetValue(EllipseHeigthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for EllipseHeigth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty EllipseHeigthProperty =
            DependencyProperty.Register("EllipseHeigth", typeof(int), typeof(UserSwitch1), new PropertyMetadata(0));


    }
}
