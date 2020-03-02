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

namespace Caculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float number1 = 0;
        float number2 = 0;
        String operation = string.Empty;
        Button b;
        String Num = string.Empty;
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            b = (Button)sender;
            if (operation == "")
            {
                number1 = (number1 * 10) + Convert.ToInt32(b.Content);
                Results.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + Convert.ToInt32(b.Content);
                Results.Text = number2.ToString();
            }
        }
        private void Operation_Click(object sender, RoutedEventArgs e)
        {
            b = (Button)sender;
            operation = Convert.ToString(b.Content);
            Results.Text = "0";
        }
        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            switch(operation)
            {
                case "+":
                    number1 = (number1 + number2);
                    number2 = 0;
                    Results.Text = number1.ToString();
                    break;
                case "-":
                    number1 = (number1 - number2);
                    number2 = 0;
                    Results.Text = number1.ToString();
                    break;
                case "*":
                    number1 = (number1 * number2);
                    number2 = 0;
                    Results.Text = number1.ToString();
                    break;
                case "/":
                    number1 = (number1 / number2);
                    number2 = 0;
                    Results.Text = number1.ToString();
                    break;
            }
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "=")
            {
                number2 = 0;
                Results.Text = "0";
            }
            else if (operation == "")
            {
                number1 = 0;
                Results.Text = "0";
            }
            else
            {
                number2 = 0;
                Results.Text = "0";
            }
        }
        private void C_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            Results.Text = "0";
        }

        private void BackSpace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                Num = Convert.ToString(number1);
                number1 = int.Parse(Num.Remove(Num.Length - 1, 1));
                Results.Text = number1.ToString();
            }
            else
            {
                Num = Convert.ToString(number2);
                number2 = int.Parse(Num.Remove(Num.Length - 1, 1));
                Results.Text = number2.ToString(); ;
            }

        }

        private void PosNeg_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 *= -1;
                Results.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                Results.Text = number2.ToString();
            }
        }
    }
}
