using System;
using System.Windows;
using System.Windows.Controls;

namespace Caculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String number1 = string.Empty;
        String number2 = string.Empty;
        String operation = string.Empty;
        Button b;
        private void btn_Click(object sender, RoutedEventArgs e)
        {
            b = (Button)sender;
            if (operation == "")
            {
                if (Convert.ToString(b.Content) == ".")
                {
                    if (!Results.Text.Contains("."))
                    {
                        number1 = number1 + Convert.ToString(b.Content);
                        Results.Text = number1.ToString();
                    }
                }
                else
                {
                    number1 = number1 + Convert.ToString(b.Content);
                    Results.Text = number1.ToString();
                }
            }
            else
            {
                if (Convert.ToString(b.Content) == ".")
                {
                    if (!Results.Text.Contains("."))
                    {
                        number2 = number2 + Convert.ToString(b.Content);
                        Results.Text = number2.ToString();
                    }
                }
                else
                {
                    number2 = number2 + Convert.ToString(b.Content);
                    Results.Text = number2.ToString();
                }
            }
        }
        private void Operation_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "=" || operation == "")
            {
                b = (Button)sender;
                operation = Convert.ToString(b.Content);
                Results.Text = "0";
            }
        }
        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            b = (Button)sender;
            if (operation != "")
            {
                switch (operation)
                {
                    case "+":
                        number1 = Convert.ToString(Math.Round((double.Parse(number1) + double.Parse(number2)), 2));
                        number2 = string.Empty;
                        operation = Convert.ToString(b.Content);
                        Results.Text = number1;
                        break;
                    case "-":
                        number1 = Convert.ToString(Math.Round((double.Parse(number1) - double.Parse(number2)), 2));
                        number2 = string.Empty;
                        operation = Convert.ToString(b.Content);
                        Results.Text = number1;
                        break;
                    case "*":
                        number1 = Convert.ToString(Math.Round((double.Parse(number1) * double.Parse(number2)), 2));
                        number2 = string.Empty;
                        operation = Convert.ToString(b.Content);
                        Results.Text = number1;
                        break;
                    case "/":
                        number1 = Convert.ToString(Math.Round((double.Parse(number1) / double.Parse(number2)), 2));
                        number2 = string.Empty;
                        operation = Convert.ToString(b.Content);
                        Results.Text = number1;
                        break;
                }
            }
        }
        private void CE_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "=")
            {
                number2 = string.Empty;
                Results.Text = "0";
            }
            else if (operation == "")
            {
                number1 = string.Empty;
                Results.Text = "0";
            }
            else
            {
                number2 = string.Empty;
                Results.Text = "0";
            }
        }
        private void C_Click(object sender, RoutedEventArgs e)
        {
            number1 = string.Empty;
            number2 = string.Empty;
            operation = "";
            Results.Text = "0";
        }

        private void BackSpace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "=")
            {
                Results.Text = number1.ToString();
            }
            else if(operation == "")
            {
                number1 = number1.Remove(number1.Length - 1, 1);
                Results.Text = number1.ToString();
            }
            
            else
            {
                number2 = number2 = number1.Remove(number2.Length - 1, 1);
                Results.Text = number2.ToString(); ;
            }

        }
        private void PosNeg_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1=Convert.ToString(double.Parse(number1) * -1);
                Results.Text = number1.ToString();
            }
            else
            {
                number2 = Convert.ToString(double.Parse(number1) * -1);
                Results.Text = number2.ToString();
            }
        }
    }
}
