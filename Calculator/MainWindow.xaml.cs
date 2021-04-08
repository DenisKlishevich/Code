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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const double pi = 3.14;
        char operation = '0';
        string pervoe_chislo;
        string vtoroe_chislo;
        bool stirat = true;
        public MainWindow()
        {
            InitializeComponent();
        }
        void solution ()
        {
            try
            {
                string text = pervoe_chislo.Replace(".", ",");
                decimal a1 = Convert.ToDecimal(text);
                text = vtoroe_chislo.Replace(".", ",");
                decimal a2 = Convert.ToDecimal(text);
                decimal r = 0;
                switch (operation)
                {
                    case '+':
                        r = a1 + a2;
                        break;
                    case '-':
                        r = a1 - a2;
                        break;
                    case '/':
                        r = a1 / a2;
                        break;
                    case '*':
                        r = a1 * a2;
                        break;
                }
                Ecran.Text = r.ToString();
            }
            catch
            {
                MessageBox.Show("Неправильно введенно число", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        void Clean()
        {
            String S = Ecran.Text;
            S = S.Substring(0, S.Length - 1);
            if (S == "")
            {
                S = "0";
            }
            Ecran.Text = S;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string icon = (string)button.Content;

            if (icon == "+" || icon == "-" || icon == "*" || icon == "/")
            {
                pervoe_chislo = Ecran.Text;
                operation = icon[0];
                stirat = true;
            }

            if (icon == "C")
            {
                Ecran.Text = "0";
            }

            if (icon == "←")
            {
                Clean();
            }

            if (icon == "=")
            {
                vtoroe_chislo = Ecran.Text;
                solution();
            }
            if (icon == "1/x")
            {
                try
                {
                    string text = Ecran.Text.Replace(".", ",");
                    decimal x = Convert.ToDecimal(text);
                    if (x == 0)
                    {
                        MessageBox.Show("Деление на ноль", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        decimal rez = 1 / x;
                        Ecran.Text = rez.ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Неправильно введенно число", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                return;
            }
            if (icon == "√x")
            {
                try
                {
                    string text = Ecran.Text.Replace(".", ",");
                    double x = Convert.ToDouble(text);
                    
                    if (x == 0)
                    {
                        MessageBox.Show("Корень из отрицательного числа", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        double rez = Math.Sqrt(x);
                        Ecran.Text = rez.ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Неправильно введенно число", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                return;
            }
            if (icon == "Sin")
            {
                try
                {
                    string text = Ecran.Text.Replace(".", ",");
                    double x = Convert.ToDouble(text);
                    if (deg.IsChecked==true)
                    {
                        x = x * pi / 180;//перевод из градусов(deg) в радианы(rad)
                    }
                    double rez = Math.Sin(x);
                    Ecran.Text = rez.ToString();
                    
                }
                catch
                {
                    MessageBox.Show("Неправильно введенно число", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                return;
            }
            if (icon == "Cos")
            {
                try
                {
                    string text = Ecran.Text.Replace(".", ",");
                    double x = Convert.ToDouble(text);
                    if (deg.IsChecked == true)
                    {
                        x = x * pi / 180;//перевод из градусов(deg) в радианы(rad)
                    }
                    double rez = Math.Cos(x);
                    Ecran.Text = rez.ToString();

                }
                catch
                {
                    MessageBox.Show("Неправильно введенно число", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                return;
            }
            if (icon == "Tg")
            {
                try
                {
                    string text = Ecran.Text.Replace(".", ",");
                    double x = Convert.ToDouble(text);
                    if (deg.IsChecked == true)
                    {
                        x = x * pi / 180;//перевод из градусов(deg) в радианы(rad)
                    }
                    double rez = Math.Tan(x);
                    Ecran.Text = rez.ToString();

                }
                catch
                {
                    MessageBox.Show("Неправильно введенно число", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                return;
            }
            if (icon[0] >= '0' && icon [0]<='9')
            {
                if (stirat == true)
                {
                    Ecran.Text = "";
                    stirat = false;
                }
                if (Ecran.Text == "0")
                {
                    Ecran.Text = "";
                }
                Ecran.Text += icon;
            }
            if (icon == ",")
            {
                if (! Ecran.Text.Contains (","))
                Ecran.Text += ",";
            }

            if (icon == "+/-")
            {
                try
                {
                    if (Ecran.Text [0] == '-')
                    {
                        String S = Ecran.Text;
                        S = S.Substring(1, S.Length - 1);
                        if (S == "")
                        {
                            S = "0";
                        }
                        Ecran.Text = S;
                    }
                    else
                    {
                        if (Ecran.Text != "0")
                        {
                            Ecran.Text = "-" + Ecran.Text;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Неправильно введенно число", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                return;
            }
        }

        private void Grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                Clean();
            }
            if ((e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || (e.Key >= Key.D0 && e.Key <= Key.D9))
            {
                if (stirat == true)
                {
                    Ecran.Text = "";
                    stirat = false;
                }
                if (Ecran.Text == "0")
                {
                    Ecran.Text = "";
                }
            }
            if (e.Key == Key.NumPad0 || e.Key == Key.D0)
            {
                Ecran.Text += "0";
            }
            if (e.Key == Key.NumPad1 || e.Key == Key.D1)
            {
                Ecran.Text += "1";
            }
            if (e.Key == Key.NumPad2 || e.Key == Key.D2)
            {
                Ecran.Text += "2";
            }
            if (e.Key == Key.NumPad3 || e.Key == Key.D3)
            {
                Ecran.Text += "3";
            }
            if (e.Key == Key.NumPad4 || e.Key == Key.D4)
            {
                Ecran.Text += "4";
            }
            if (e.Key == Key.NumPad5 || e.Key == Key.D5)
            {
                Ecran.Text += "5";
            }
            if (e.Key == Key.NumPad6 || e.Key == Key.D6)
            {
                Ecran.Text += "6";
            }
            if (e.Key == Key.NumPad7 || e.Key == Key.D7)
            {
                Ecran.Text += "7";
            }
            if (e.Key == Key.NumPad8 || e.Key == Key.D8)
            {
                Ecran.Text += "8";
            }
            if (e.Key == Key.NumPad9 || e.Key == Key.D9)
            {
                Ecran.Text += "9";
            }
            if (e.Key == Key.Add || e.Key == Key.OemPlus)
            {
                pervoe_chislo = Ecran.Text;
                operation = '+';
                stirat = true;
            }
            if (e.Key == Key.Subtract || e.Key == Key.OemMinus)
            {
                pervoe_chislo = Ecran.Text;
                operation = '-';
                stirat = true;
            }
            if (e.Key == Key.Divide)
            {
                pervoe_chislo = Ecran.Text;
                operation = '/';
                stirat = true;
            }
            if (e.Key == Key.Multiply)
            {
                pervoe_chislo = Ecran.Text;
                operation = '*';
                stirat = true;
            }
            if (e.Key == Key.Enter)
            {
                vtoroe_chislo = Ecran.Text;
                solution();
            }
        }
    }
}
