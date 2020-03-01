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
        String operation = "";
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                Results.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                Results.Text = number2.ToString();
            }
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                Results.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                Results.Text = number2.ToString();
            }
        }
        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                Results.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                Results.Text = number2.ToString();
            }
        }
        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                Results.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                Results.Text = number2.ToString();
            }
        }
        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                Results.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                Results.Text = number2.ToString();
            }
        }
        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                Results.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                Results.Text = number2.ToString();
            }
        }
        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) +7;
                Results.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                Results.Text = number2.ToString();
            }
        }
        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                Results.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                Results.Text = number2.ToString();
            }
        }
        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                Results.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                Results.Text = number2.ToString();
            }
        }
        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                Results.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                Results.Text = number2.ToString();
            }
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            Results.Text = "0";
        }

        private void Mutiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            Results.Text = "0";
        }

        private void Sub_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            Results.Text = "0";
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            Results.Text = "0";
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            switch(operation)
            {
                case "+":
                    Results.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    Results.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    Results.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    Results.Text = (number1 / number2).ToString();
                    break;
            }
        }
    }
}
