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

namespace UserControl
{
    /// <summary>
    /// Логика взаимодействия для ControlBlock.xaml
    /// </summary>
    /// <summary>
    /// Interaction logic for ControlBlock.xaml
    /// </summary>
    public partial class ControlBlock : Border
    {
        public ControlBlock()
        {
            InitializeComponent();
        }


        #region Dependenty Text (string)

        /// <summary>
        /// Text
        /// </summary>
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }


        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(ControlBlock),
                new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        #endregion


        #region Dependenty Title (string)

        /// <summary>
        /// Title
        /// </summary>
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }


        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(ControlBlock), new PropertyMetadata(""));

        #endregion
    }
}
