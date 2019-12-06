using System.Windows;
using System.Windows.Controls;

namespace UC_Bind_VM.UserControls
{
    /// <summary>
    /// Логика взаимодействия для UserPercent.xaml
    /// </summary>
    public partial class UserPercent : ContentControl
    {
        public UserPercent()
        {
            InitializeComponent();
        }       

        public int Percent
        {
            get { return (int)GetValue(PercentProperty); }
            set { SetValue(PercentProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Percent.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PercentProperty =
            DependencyProperty.Register("Percent", typeof(int), typeof(UserPercent), new PropertyMetadata(0));        
    }
}
