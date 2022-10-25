using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CalculatorEngine calc;
        public MainWindow()
        {
            InitializeComponent();
            calc = new CalculatorEngine();
        }



        private void equalButton_Click(object sender, RoutedEventArgs e)
        {
            calc.Operand2 = double.Parse(inputArea.Text);
            calc.Calculate();
            calc.SelectedOperation = Operations.None;
            inputArea.Text = calc.Answer.ToString();
        }



        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            if (calc.SelectedOperation == Operations.Sum)
            {
                calc.Operand2 = double.Parse(inputArea.Text);
                calc.Sum();

                inputArea.Text = calc.Answer.ToString();
            }
            else
            {
                calc.Operand1 = double.Parse(inputArea.Text);
                inputArea.Text = "0";
                calc.SelectedOperation = Operations.Sum;
            }

        }

        private void multiplicationButton_Click(object sender, RoutedEventArgs e)
        {
            if (calc.SelectedOperation == Operations.Multiplication)
            {
                calc.Operand2 = double.Parse(inputArea.Text);
                calc.Multiplication();

                inputArea.Text = calc.Answer.ToString();
            }
            else
            {
                calc.Operand1 = double.Parse(inputArea.Text);
                inputArea.Text = "0";
                calc.SelectedOperation = Operations.Multiplication;
            }
        }

        private void divisionButton_Click(object sender, RoutedEventArgs e)
        {
            if (calc.SelectedOperation == Operations.Division)
            {
                calc.Operand2 = double.Parse(inputArea.Text);
                calc.Division();

                inputArea.Text = calc.Answer.ToString();
            }
            else
            {
                calc.Operand1 = double.Parse(inputArea.Text);
                inputArea.Text = "0";
                calc.SelectedOperation = Operations.Division;
            }
        }

        private void substractButton_Click(object sender, RoutedEventArgs e)
        {
            if (calc.SelectedOperation == Operations.Substraction)
            {
                calc.Operand2 = double.Parse(inputArea.Text);
                calc.Substract();

                inputArea.Text = calc.Answer.ToString();
            }
            else
            {
                calc.Operand1 = double.Parse(inputArea.Text);
                inputArea.Text = "0";
                calc.SelectedOperation = Operations.Substraction;
            }
        }


        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            calc.Clear();
            inputArea.Text = "0";
        }

        private void backspaceButton_Click(object sender, RoutedEventArgs e)
        {
            if (inputArea.Text.Length > 0)
                inputArea.Text = inputArea.Text.Substring(0, inputArea.Text.Length - 1);
            if (inputArea.Text == "")
            {
                inputArea.Text = "0";
            }
        }

        private void sqrtButton_Click(object sender, RoutedEventArgs e)
        {
            calc.Operand1 = double.Parse(inputArea.Text);
            calc.SelectedOperation = Operations.Sqrt;
            calc.Sqrt();
            inputArea.Text = calc.Answer.ToString();

        }

        private void powerButton_Click(object sender, RoutedEventArgs e)
        {
            calc.Operand1 = double.Parse(inputArea.Text);
            calc.SelectedOperation = Operations.Power2;
            calc.Power2();
            inputArea.Text = calc.Answer.ToString();
        }

        private void oneByXButton_Click(object sender, RoutedEventArgs e)
        {

            calc.Operand1 = double.Parse(inputArea.Text);
            calc.SelectedOperation = Operations.oneDivX;
            calc.OneByX();
            inputArea.Text = calc.Answer.ToString();
        }

        private void percentButton_Click(object sender, RoutedEventArgs e)
        {
            if (calc.SelectedOperation == Operations.Multiplication)
            {
                inputArea.Text = (double.Parse(inputArea.Text) / 100).ToString();
            }
        }

        private void CEButton_Click(object sender, RoutedEventArgs e)
        {
            inputArea.Text = "0";
        }



        #region numbers
        private void printNumber(int num)
        {
            if (inputArea.Text != "0")
                inputArea.Text += num.ToString();
            else inputArea.Text = num.ToString();
        }
        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {
            printNumber(0);
        }

        private void oneButton_Click(object sender, RoutedEventArgs e)
        {
            printNumber(1);
        }

        private void twoButton_Click(object sender, RoutedEventArgs e)
        {
            printNumber(2);
        }

        private void threeButton_Click(object sender, RoutedEventArgs e)
        {
            printNumber(3);
        }

        private void fourButton_Click(object sender, RoutedEventArgs e)
        {
            printNumber(4);
        }

        private void fiveButton_Click(object sender, RoutedEventArgs e)
        {
            printNumber(5);
        }

        private void sixButton_Click(object sender, RoutedEventArgs e)
        {
            printNumber(6);
        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            printNumber(7);
        }

        private void eightButton_Click(object sender, RoutedEventArgs e)
        {
            printNumber(8);
        }
        private void nineButton_Click(object sender, RoutedEventArgs e)
        {
            printNumber(9);
        }
        private void dotButton_Click(object sender, RoutedEventArgs e)
        {
            if (!inputArea.Text.Contains(","))
            {
                inputArea.Text += ",";
            }
        }


        #endregion

        private void plusMinusButton_Click(object sender, RoutedEventArgs e)
        {
            inputArea.Text = (-double.Parse(inputArea.Text)).ToString();
        }
    }
}
