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
using System.Windows.Media.Animation;

namespace Dot
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

        private void Button_Click_UP(object sender, RoutedEventArgs e)
        {
            double a = Canvas.GetTop(Dot);
            a -= 10;
            Canvas.SetTop(Dot, a);
        }

        private void Button_Click_DOWN(object sender, RoutedEventArgs e)
        {
            double a = Canvas.GetTop(Dot);
            a += 10;
            Canvas.SetTop(Dot, a);
        }

        private void Button_Click_LEFT(object sender, RoutedEventArgs e)
        {
            double a = Canvas.GetLeft(Dot);
            a -= 10;
            Canvas.SetLeft(Dot, a);
        }

        private void Button_Click_RIGHT(object sender, RoutedEventArgs e)
        {
            double a = Canvas.GetLeft(Dot);
            a += 10;
            Canvas.SetLeft(Dot, a);
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            //if (Check.IsChecked == true)
            //{
            //    double x = e.GetPosition(Dot).X;
            //    double y = e.GetPosition(Dot).Y;
            //    Duration duration = new Duration(TimeSpan.FromMilliseconds(1000));
            //    double x0 = Canvas.GetLeft(Dot);
            //    double y0 = Canvas.GetTop(Dot);
            //    DoubleAnimation doubleAnimation = new DoubleAnimation(x0, x, duration, FillBehavior.HoldEnd);
            //    DoubleAnimation doubleAnimation2 = new DoubleAnimation(y0, y, duration, FillBehavior.HoldEnd);
            //    Dot.BeginAnimation(Canvas.LeftProperty, doubleAnimation);
            //    Dot.BeginAnimation(Canvas.TopProperty, doubleAnimation2);
            //}
        }
    }
}
