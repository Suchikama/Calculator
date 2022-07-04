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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string num1 = string.Empty;
        int countD = 0;
        string num2 = string.Empty;
        double FirstNumber = 0;
        double Result = 0;
        double SecondNumber = 0;
        string operand = string.Empty;
        string oldoperand = string.Empty;
        int S = 0;
        string numt = string.Empty;
        int R;

        public void ClearAll()
        {
            TxtResult.Text = "0";
            num1 = string.Empty;
            num2 = string.Empty;
            FirstNumber = 0;
            Result = 0;
            SecondNumber = 0;
            operand = string.Empty;
            oldoperand = string.Empty;
            countD = 0;
            S = 0;
            R = 0;

        }




        public void ClearCE2()
        {
            TxtResult.Text = "0";
            num2 = "0";
            countD = 0;
            S = 0;
        }


        public MainWindow()
        {
            InitializeComponent();

        }

        private void inputdot()
        {
            if (operand == string.Empty)
            {
                if (TxtResult.Text == "0")
                {

                    TxtResult.Text = "0,";
                    countD += 1;
                    num1 = "0,";
                }
                else if ((TxtResult.Text != "0") &  (countD == 0))
                {
                    TxtResult.Text += ",";
                    countD += 1;
                    num1 += ",";
                }
            }
            else
            {
                if (TxtResult.Text == "0")
                {

                    TxtResult.Text = "0,";
                    countD += 1;
                    num2 += "0,";
                }
                else if ((TxtResult.Text != "0") &  (countD == 0))
                {
                    TxtResult.Text += ",";
                    countD += 1;
                    num2 += ",";
                }
            }

        }


        private void input(string a)
        {
            if ((TxtResult.Text == "0") & (num1.Length < 13))
            {

                TxtResult.Text = a;
                num1 = a;
            }
            else if ((TxtResult.Text != "0") & (num1.Length < 13))
            {
                TxtResult.Text += a;
                num1 += a;
            }
        }

        private void input2(string a)
        {
            if ((TxtResult.Text == oldoperand) & (num2.Length < 13))
            
            {
                TxtResult.Text = a;
                oldoperand = string.Empty;
                num2 = a;

            }


            else if ((TxtResult.Text == "0") & (num2.Length < 13))
            {
                TxtResult.Text = a;
                num2 = a;
            }

            else if ((TxtResult.Text != "0") & (num2.Length < 13))
            {
                TxtResult.Text += a;
                num2 += a;
            }


        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (operand == string.Empty)
            {

                input("1");
                if (S == 1)
                {
                    ClearAll();
                    input("1");
                }
            }

            else
            {
                input2("1");

                if (Result != 0)
                {
                    ClearAll();
                    input("1");
                }
                if (S == 2)
                    ClearCE2();
            }

        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (operand == string.Empty)
            {

                input("2");
                if (S == 1)
                {
                    ClearAll();
                    input("2");
                }
            }

            else
            {
                input2("2");

                if (Result != 0)
                {
                    ClearAll();
                    input("2");
                }
                if (S == 2)
                    ClearCE2();
            }
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {

            if (operand == string.Empty)
            {

                input("3");
                if (S == 1)
                {
                    ClearAll();
                    input("3");
                }
            }
            else
            {
                input2("3");

                if (Result != 0)
                {
                    ClearAll();
                    input("3");
                }
                if (S == 2)
                    ClearCE2();
            }
        }

        private void Button_Click0(object sender, RoutedEventArgs e)
        {
            if (operand == string.Empty)
            {

                input("0");
                if (S == 1)
                {
                    ClearAll();
                    input("0");
                }
            }
            else
            {
                input2("0");

                if (Result != 0)
                {
                    ClearAll();
                    input("0");
                }
                if (S == 2)
                    ClearCE2();
            }
        }
        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            if (operand == string.Empty)
            {

                input("8");
                if (S == 1)
                {
                    ClearAll();
                    input("8");
                }
            }

            else
            {
                input2("8");

                if (Result != 0)
                {
                    ClearAll();
                    input("8");
                }
                if (S == 2)
                    ClearCE2();
            }
        }       
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            if (operand == string.Empty)
            {

                input("7");
                if (S == 1)
                {
                    ClearAll();
                    input("7");
                }
            }

            else
            {
                input2("7");

                if (Result != 0)
                {
                    ClearAll();
                    input("7");
                }
                if (S == 2)
                    ClearCE2();
            }
        }

        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            if (operand == string.Empty)
            {

                input("9");
                if (S == 1)
                {
                    ClearAll();
                    input("9");
                }
            }
            else
            {
                input2("9");

                if (Result != 0)
                {
                    ClearAll();
                    input("9");
                }
                if (S == 2)
                    ClearCE2();
            }
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            if (operand == string.Empty)
            {

                input("6");
                if (S == 1)
                {
                    ClearAll();
                    input("6");
                }
            }
            else
            {
                input2("6");

                if (Result != 0)
                {
                    ClearAll();
                    input("6");
                }
                if (S == 2)
                    ClearCE2();
            }
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            if (operand == string.Empty)
            {

                input("5");
                if (S == 1)
                {
                    ClearAll();
                    input("5");
                }
            }

            else
            {
                input2("5");

                if (Result != 0)
                {
                    ClearAll();
                    input("5");
                }
                if (S == 2)
                    ClearCE2();
            }
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            if (operand == string.Empty)
            {

                input("4");
                if (S == 1)
                {
                    ClearAll();
                    input("4");
                }
            }
            else
            {
                if (S == 2)
                    ClearCE2();

                input2("4");

                if (Result != 0)
                {
                    ClearAll();
                    input("4");
                }

            }
        }

        private void Button_Click_Dot(object sender, RoutedEventArgs e)
        {
            inputdot();

        }

        private void Button_Click_Plus(object sender, RoutedEventArgs e)
        {

            TxtResult.Text = "+";
            operand = "+";
            oldoperand = operand ;
            countD = 0;

            if (num2 != string.Empty & num1 != string.Empty & R == 0)
            {
                FirstNumber = Convert.ToDouble(num1);
                SecondNumber = Convert.ToDouble(num2);

                calcul();
                numt = Result.ToString();

                ClearAll();
                num1 = numt;
                TxtResult.Text = "+";
                operand = "+";
                oldoperand = operand;
                countD = 0;
            }

            if (R == 1)
            {
                num2 = string.Empty;
                Result = 0;
                TxtResult.Text = "+";
                operand = "+";
                oldoperand = operand;
                countD = 0;
            }

            if (num2 != string.Empty & num1 == string.Empty)
            {
                
                SecondNumber = Convert.ToDouble(num2);

                calcul();
                numt = Result.ToString();

                ClearAll();
                num1 = numt;
                TxtResult.Text = "+";
                operand = "+";
                oldoperand = operand;
                countD = 0;
            }

        }

        private void Button_Click_Back(object sender, RoutedEventArgs e) //fsdasaf
        {
            /*YourString = YourString.Remove(YourString.Length - 1);*/
            if ((num2 == string.Empty) & (operand == string.Empty) & (num1.Length >= 1))
            {
                num1 = num1.Remove(num1.Length - 1);

                if (num1.Length == 0)
                    num1 = "0";
                TxtResult.Text = num1;
            }

            else if ((num2 != string.Empty) & (operand != string.Empty) & (Result == 0))
            {
                num2 = num2.Remove(num2.Length - 1);

                if (num2.Length == 0)
                    num2 = "0";
                TxtResult.Text = num2;
            }
            
        }

        private void Button_Click_ClearE(object sender, RoutedEventArgs e)
        {
            if ((num2 == string.Empty) & (operand == string.Empty))
            {
                ClearAll();
            }

            else if ((num2 != string.Empty) & (operand != string.Empty))
            {
                ClearCE2();
            }

            if (Result != 0)
                ClearAll();

        }


        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            
            ClearAll();

        }



        private void Button_Click_plusminus(object sender, RoutedEventArgs e) //fdsafdsafsa
        {
            if ((num2 == string.Empty) & (operand == string.Empty))
            {
                FirstNumber = Convert.ToDouble(num1);
       
                FirstNumber = -1 * FirstNumber;
                num1 = Convert.ToString(FirstNumber);
                TxtResult.Text = FirstNumber.ToString();
                FirstNumber = 0;
                
            }

            else if ((num2 != string.Empty) & (operand != string.Empty))
            {
                SecondNumber = Convert.ToDouble(num2);

                SecondNumber = -1 * SecondNumber;
                num2 = Convert.ToString(SecondNumber);
                TxtResult.Text = SecondNumber.ToString();

                SecondNumber = 0;
                
            }
        }


        private void Button_Click_umn(object sender, RoutedEventArgs e)
        {

            TxtResult.Text = "*";
            operand = "*";
            oldoperand = operand ;
            countD = 0;
            if (num2 != string.Empty & num1 != string.Empty & R == 0)
            {
                FirstNumber = Convert.ToDouble(num1);
                SecondNumber = Convert.ToDouble(num2);

                calcul();
                numt = Result.ToString();

                ClearAll();
                num1 = numt;
                TxtResult.Text = "*";
                operand = "*";
                oldoperand = operand;
                countD = 0;
            }

            if (R == 1)
            {
                num2 = string.Empty;
                Result = 0;
                TxtResult.Text = "*";
                operand = "*";
                oldoperand = operand;
                countD = 0;
            }


            if (num2 != string.Empty & num1 == string.Empty)
            {
                FirstNumber = 0;
                SecondNumber = Convert.ToDouble(num2);

                calcul();
                numt = Result.ToString();

                ClearAll();
                num1 = numt;
                TxtResult.Text = "*";
                operand = "*";
                oldoperand = operand;
                countD = 0;
            }


        }

        private void Button_Click_minus(object sender, RoutedEventArgs e)
        { 

            TxtResult.Text = "-";
            operand = "-";
            oldoperand = operand ;
            countD = 0;
            if (num2 != string.Empty & num1 != string.Empty & R == 0)
            {   


                FirstNumber = Convert.ToDouble(num1);
                SecondNumber = Convert.ToDouble(num2);

                calcul();

                numt = Result.ToString();

                ClearAll();
                num1 = numt;
                TxtResult.Text = "-";
                operand = "-";
                oldoperand = operand;
                countD = 0;
            }

            if (R == 1)
            {
                num2 = string.Empty;
                Result = 0;
                TxtResult.Text = "-";
                operand = "-";
                oldoperand = operand;
                countD = 0;
            }


            if (num2 != string.Empty & num1 == string.Empty)
            {
                FirstNumber = 0;
                SecondNumber = Convert.ToDouble(num2);

                calcul();
                numt = Result.ToString();

                ClearAll();
                num1 = numt;
                TxtResult.Text = "-";
                operand = "-";
                oldoperand = operand;
                countD = 0;
            }
        }

        private void Button_Click_rovno(object sender, RoutedEventArgs e)
        {
            if (num1 != string.Empty & num2 != string.Empty)
            {
                FirstNumber = Convert.ToDouble(num1);
                SecondNumber = Convert.ToDouble(num2);
            }

            if (num1 != string.Empty & num2 == string.Empty & operand != string.Empty)
            {
                FirstNumber = Convert.ToDouble(num1);
                SecondNumber = FirstNumber;
                num2 = num1;
            }
            calcul();
            TxtResult.Text =/* num2 + "f" + " " +*/ Result.ToString();

            num1 = Convert.ToString(Result);
            R = 1;
            FirstNumber = 0;
            SecondNumber = 0;
        }

        private void Button_Click_sqrt(object sender, RoutedEventArgs e)
        {
            if ((num2 == string.Empty) & (operand == string.Empty) & (num1 != string.Empty) )
            {
                FirstNumber = Convert.ToDouble(num1);
                if (FirstNumber >= 0)
                {
                    FirstNumber = Math.Sqrt(FirstNumber);
                    num1 = Convert.ToString(FirstNumber);
                    TxtResult.Text = num1;
                    S = 1;

                }
            }

            else if ((num2 != string.Empty) & (operand != string.Empty))
            {
                SecondNumber = Convert.ToDouble(num2);
                if (SecondNumber >= 0) {
                    SecondNumber = Math.Sqrt(SecondNumber);
                    num2 = Convert.ToString(SecondNumber);
                    TxtResult.Text = num2;
                    S = 2;

                }
            }


        }

        private void Button_Click_procent(object sender, RoutedEventArgs e) //421341
        {
            if ((num2 == string.Empty) & (operand == string.Empty))
            {

                FirstNumber = 0;
                num1 = Convert.ToString(FirstNumber);
                TxtResult.Text = num1;

            }

            else if ((num2 != string.Empty) & (operand != string.Empty))
            {
                SecondNumber = Convert.ToDouble(num2);
                FirstNumber = Convert.ToDouble(num1);

                SecondNumber = FirstNumber/ 100 * SecondNumber ;
                num2 = Convert.ToString(SecondNumber);
                TxtResult.Text = SecondNumber.ToString();

                FirstNumber = 0;
                SecondNumber = 0;

            }
        }

        private void Button_Click_odindel(object sender, RoutedEventArgs e)
        {
            if ((num2 == string.Empty) & (operand == string.Empty) & (num1 != string.Empty))
            {
                FirstNumber = Convert.ToDouble(num1);
                if (FirstNumber == 0)
                {
                    TxtResult.Text = "Деление на 0 невозможно";
                    S = 1;
                }
                else
                {
                    FirstNumber = 1 / FirstNumber;
                    num1 = Convert.ToString(FirstNumber);
                    TxtResult.Text = FirstNumber.ToString();
                    S = 1;
                    FirstNumber = 0;
                }


            }

            else if ((num2 != string.Empty) & (operand != string.Empty))
            {   
                SecondNumber = Convert.ToDouble(num2);
                if (SecondNumber == 0)
                {
                    TxtResult.Text = "Деление на 0 невозможно";
                    S = 2;
                }
                else
                {
                    SecondNumber = 1 / SecondNumber;
                    num2 = Convert.ToString(SecondNumber);
                    TxtResult.Text = SecondNumber.ToString();
                    S = 2;
                    SecondNumber = 0;
                }

            }

        }

        private void Button_Click_del(object sender, RoutedEventArgs e)
        {

            TxtResult.Text = "/";
            operand = "/";
            oldoperand = operand ;
            countD = 0;
            if (num2 != string.Empty & num1 != string.Empty & R == 0)
            {
                FirstNumber = Convert.ToDouble(num1);
                SecondNumber = Convert.ToDouble(num2);

                calcul();
                numt = Result.ToString();

                ClearAll();
                num1 = numt;
                TxtResult.Text = "/";
                operand = "/";
                oldoperand = operand;
                countD = 0;
            }

            if (R == 1)
            {
                num2 = string.Empty;
                Result = 0;
                TxtResult.Text = "/";
                operand = "/";
                oldoperand = operand;
                countD = 0;
            }


            if (num2 != string.Empty & num1 == string.Empty)
            {
                FirstNumber = Convert.ToDouble(num1);
                SecondNumber = Convert.ToDouble(num2);

                calcul();
                numt = Result.ToString();

                ClearAll();
                num1 = numt;
                TxtResult.Text = "/";
                operand = "/";
                oldoperand = operand;
                countD = 0;
            }
        }

        void calcul()
        {



            if (operand == "+")
            {
               

                Result = FirstNumber + SecondNumber;
                TxtResult.Text = Result.ToString();
            }
            else if (operand == "-") {


                Result = FirstNumber - SecondNumber;
                TxtResult.Text = Result.ToString();
            }
            else if (operand == "*") {


                Result = FirstNumber * SecondNumber;
                
                TxtResult.Text = Result.ToString();

            }

            else if ((operand == "/") & (num2 == string.Empty))
            {


                Result = FirstNumber / FirstNumber;
                TxtResult.Text = Result.ToString();
            }

            else if ((operand == "/") & (SecondNumber == 0))
            {

                TxtResult.Text = "Деление на 0 невозможно";
            }
            else if ((operand == "/") & (SecondNumber != 0))
            {


                Result = FirstNumber / SecondNumber;
                TxtResult.Text = Result.ToString();
            }

        }


        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key == Key.D1) || (e.Key == Key.NumPad1))
            {
                Button_Click1(one, null);
            }

            if ((e.Key == Key.D2) || (e.Key == Key.NumPad2))
            {
                Button_Click2(two, null);
            }
            if ((e.Key == Key.D3) || (e.Key == Key.NumPad3))
            {
                Button_Click3(three, null);
            }
            if ((e.Key == Key.D4) || (e.Key == Key.NumPad4))
            {
                Button_Click4(four, null);
            }
            if ((e.Key == Key.D5) || (e.Key == Key.NumPad5))
            {
                Button_Click5(five, null);
            }
            if ((e.Key == Key.D6) || (e.Key == Key.NumPad6))
            {
                Button_Click6(six, null);
            }
            if ((e.Key == Key.D7) || (e.Key == Key.NumPad7))
            {
                Button_Click7(seven, null);
            }
            if ((e.Key == Key.D8) || (e.Key == Key.NumPad8))
            {
                Button_Click8(eight, null);
            }
            if ((e.Key == Key.D9) || (e.Key == Key.NumPad9))
            {
                Button_Click9(nine, null);
            }
            if ((e.Key == Key.D0) || (e.Key == Key.NumPad0))
            {
                Button_Click0(zero, null);
            }
            if (e.Key == Key.R)
            {
                Button_Click_odindel(odindel, null);
            }
            if (e.Key == Key.Q) 
            {
                Button_Click_rovno(rovno, null);
            }
            if (e.Key == Key.Add)
            {
                Button_Click_Plus(plus, null);
            }
            if (e.Key == Key.Subtract)
            {
                Button_Click_minus(minus, null);
            }
            if (e.Key == Key.Multiply)
            {
                Button_Click_umn(umn, null);
            }
            if (e.Key == Key.Divide)
            {
                Button_Click_del(del, null);
            }
            if (e.Key == Key.S)
            {
                Button_Click_Clear(clear, null);
            }
            if (e.Key == Key.Back)
            {
                Button_Click_Back(backspace, null);
            }


        }

        //ВВОд  с клавиш

    } 





}
