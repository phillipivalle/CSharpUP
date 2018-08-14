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

namespace Aula0708_WPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window 
    {

        long num1 = 0;
        long num2 = 0;
        int operacao = 0;
        


        public MainWindow()
        {
            InitializeComponent();
        }

        private void bn0_Click(object sender, RoutedEventArgs e)
        {
            // verificação. Se a variavél operação não estiver preenchida, consequentemente irá ser a variavél num1
            if (operacao != 0)
            {
                // multiplicando por 10, para o caso de 10, 100, 1000...
                num1 = (num1 * 10) + 0;
                Display.Text = num1.ToString();
            }
            else
            {
            // não sendo a variavél num1, irá cair no else e vir para a num2
                num2 = (num2 * 10) + 0;
                Display.Text = num2.ToString();
            }
        }

        private void bn1_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == 0)
            {
                num1 = (num1 * 10) + 1;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 1;
                Display.Text = num2.ToString();
            }
        }

        private void bn2_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == 0)
            {
                num1 = (num1 * 10) + 2;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 2;
                Display.Text = num2.ToString();
            }
        }

        private void bn3_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == 0)
            {
                num1 = (num1 * 10) + 3;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 3;
                Display.Text = num2.ToString();
            }
        }

        private void bn4_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == 0)
            {
                num1 = (num1 * 10) + 4;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 4;
                Display.Text = num2.ToString();
            }
        }

        private void bn5_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == 0)
            {
                num1 = (num1 * 10) + 5;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 5;
                Display.Text = num2.ToString();
            }
        }

        private void bn6_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == 0)
            {
                num1 = (num1 * 10) + 6;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 6;
                Display.Text = num2.ToString();
            }
        }

        private void bn7_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == 0)
            {
                num1 = (num1 * 10) + 7;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 7;
                Display.Text = num2.ToString();
            }
        }

        private void bn8_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == 0)
            {
                num1 = (num1 * 10) + 8;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 8;
                Display.Text = num2.ToString();
            }
        }

        private void bn9_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == 0)
            {
                num1 = (num1 * 10) + 9;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 9;
                Display.Text = num2.ToString();
            }
        }

        private void bnigual_Click(object sender, RoutedEventArgs e)
        {
            switch (operacao) 
            {
                case 1:
                    Display.Text = (num1 + num2).ToString();
                    break;

                case 2:
                    Display.Text = (num1 - num2).ToString();
                    break;

                case 3:
                    Display.Text = (num1 * num2).ToString();
                    break;

                case 4:
                    Display.Text = (num1 / num2).ToString();
                    break;

                case 5:
                    Display.Text = Math.Pow(num1, num2).ToString();
                    break;
            
        }
           
        }

        private void bnmais_Click(object sender, RoutedEventArgs e)
        {
            operacao = 1;
            Display.Text = "";
        }

        private void bnmenos_Click(object sender, RoutedEventArgs e)
        {
            operacao = 2;
            Display.Text = "";
        }

        private void bnmult_Click(object sender, RoutedEventArgs e)
        {
            operacao = 3;
            Display.Text = "";
        }

        private void bndiv_Click(object sender, RoutedEventArgs e)
        {
            operacao = 4;
            Display.Text = "";
        }

        private void btnraiz_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == 0)
            {
                
                Display.Text = Math.Sqrt(num1).ToString();
                num1 = Convert.ToInt64(Math.Sqrt(num1));
            }
            else
            {

                Display.Text = Math.Sqrt(num2).ToString();
                num2 = Convert.ToInt64(Math.Sqrt(num2));
            }
        }

        private void btnc_Click(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operacao = 0;
            Display.Text = "0";
            
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            if (operacao == 0)
            {
                num1 /= 10;
                Display.Text = num1.ToString();
            }
            else
            {
                num2 /= 10;
                Display.Text = num2.ToString();
            }
        }

        private void btnpot_Click(object sender, RoutedEventArgs e)
        {

            operacao = 5;
            Display.Text = "";
           
        }
    }
}
