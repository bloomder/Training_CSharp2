using System.Windows;
using System.Windows.Controls;

namespace UC_Bind_VM.UserControls
{
    /// <summary>
    /// Логика взаимодействия для UserBlock.xaml
    /// </summary>
    public partial class UserBlock : ContentControl
    {
        public UserBlock()
        {
            InitializeComponent();
        }


        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(UserBlock), new PropertyMetadata(""));



        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(UserBlock), new PropertyMetadata(""));



    }
}
