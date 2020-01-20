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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SwitchAnimation_WPF
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

		private void Ellipse_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			double circleTransformTime = 0.1;
			double circleMovingTime = 0.5;
			Color coolColor = Color.FromRgb(87, 219, 131);
			Color coolGreyColor = Colors.WhiteSmoke;

			//Changing ellipse size
			DoubleAnimationUsingKeyFrames ellipseRadius = new DoubleAnimationUsingKeyFrames();
			ellipseRadius.KeyFrames = new DoubleKeyFrameCollection()
			{
				new LinearDoubleKeyFrame(42, TimeSpan.FromSeconds(0)),
				new LinearDoubleKeyFrame(35, TimeSpan.FromSeconds(circleTransformTime)),
				new LinearDoubleKeyFrame(35, TimeSpan.FromSeconds(circleTransformTime + circleMovingTime)),
				new LinearDoubleKeyFrame(40, TimeSpan.FromSeconds(circleTransformTime + circleMovingTime + circleTransformTime))
			};
			InnElem.BeginAnimation(Ellipse.HeightProperty, ellipseRadius);
			InnElem.BeginAnimation(Ellipse.WidthProperty, ellipseRadius);

			//Changing Ellipse position
			ThicknessAnimation ellipsePos = new ThicknessAnimation();
			ellipsePos.AccelerationRatio = 0.95;
			ellipsePos.From = InnElem.Margin;
			ellipsePos.BeginTime = TimeSpan.FromSeconds(circleTransformTime);
			ellipsePos.Duration = TimeSpan.FromSeconds(circleMovingTime);

			//Animation for set backGround of Border
			ColorAnimation bordColor = new ColorAnimation();
			bordColor.BeginTime = TimeSpan.FromSeconds(circleTransformTime);
			bordColor.Duration = TimeSpan.FromSeconds(circleMovingTime);

			//chech is ellipse on start position
			if (InnElem.Margin.Left == 0)
			{
				ellipsePos.To = new Thickness(55, 0, 0, 0);

				ExtElem.Background = new SolidColorBrush(coolGreyColor);
				bordColor.From = coolGreyColor;
				bordColor.To = coolColor;
			}
			else
			{
				ellipsePos.To = new Thickness(0, 0, 55, 0);

				ExtElem.Background = new SolidColorBrush(coolColor);
				bordColor.From = coolColor;
				bordColor.To = coolGreyColor;
			}
			InnElem.BeginAnimation(Ellipse.MarginProperty, ellipsePos);
			ExtElem.Background.BeginAnimation(SolidColorBrush.ColorProperty, bordColor);
		}
	}
}
