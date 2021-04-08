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
using System.Collections.ObjectModel;

namespace Lab_3_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> results;
        public Values values;
        public MainWindow()
        {
            InitializeComponent();
            values = new Values();
            DataContext = values;

            results = new ObservableCollection<string>();
            LBResult.DataContext = results;
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            results.Clear();
            for (double x=values.xstart; x <= values.xstop; x+=values.step)
            {
                double y = x / 2;
                double ee = -1;
                double s = 0;
                for (int k = 1; k <=values.n; k++)
                {
                    ee = -ee;
                    s += ee * Math.Sin(k * x) / k;
                }
                string str = "S(" + x + ")=" + s + " y(" + x + ")=" + y;
                
                results.Add(str);
            }
        }
    }
}
