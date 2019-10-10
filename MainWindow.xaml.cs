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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {

        int d = 0;
        int s = 0;
        //Переменная действия
        string s1;
        //До действия
        string s3;
        string r;
        int one = 1;
        int zero = 0;
        bool EqCount = false;
        bool ZeroWT = false;
        int CountDot = 0;

        private void WriteText_TextChanged(object sender, TextChangedEventArgs e)
        {
            string str = WriteText.Text;
            string tmp = WriteText.Text.Trim();
            string outS = string.Empty;
            bool zapyataya = true;
            foreach (char ch in tmp)

                if (Char.IsDigit(ch) | Char.IsLetter(ch) || (ch == ',' && zapyataya))
                {
                    outS += ch;
                    if (ch == ',')
                        zapyataya = false;
                }

            WriteText.Text = outS;
            WriteText.SelectionStart = outS.Length;
        }
        //Замена . на , и ограничение на ,

        public MainWindow()
        {
            InitializeComponent();
            //this.WriteText.KeyDown += new KeyEventHandler(WriteText_KeyDown);
        }




        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        //Закрытие

        private void Minimized_Click(object sender, RoutedEventArgs e)
        {
        	this.WindowState = WindowState.Minimized;
        }
        //Скрытие




        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            if (WriteText.Text == "0")
            {
                WriteText.Text += "";
            }
            else
            { 
                WriteText.Text += "0";
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

            if (WriteText.Text == "0")
            {
                ZeroWT = true;
            }

            if (ZeroWT == true || EqCount == true)
            {
                WriteText.Clear();
                WriteText.Text += "1";
                ZeroWT = false;
                EqCount = false;
            }
            else
            {
                WriteText.Text += "1";
            }

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (WriteText.Text == "0")
            {
                ZeroWT = true;
            }

            if (ZeroWT == true || EqCount == true)
            {
                WriteText.Clear();
                WriteText.Text += "2";
                ZeroWT = false;
                EqCount = false;
            }
            else
            {
                WriteText.Text += "2";
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (WriteText.Text == "0")
            {
                ZeroWT = true;
            }

            if (ZeroWT == true || EqCount == true)
            {
                WriteText.Clear();
                WriteText.Text += "3";
                ZeroWT = false;
                EqCount = false;
            }
            else
            {
                WriteText.Text += "3";
            }
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            if (WriteText.Text == "0")
            {
                ZeroWT = true;
            }

            if (ZeroWT == true || EqCount == true)
            {
                WriteText.Clear();
                WriteText.Text += "4";
                ZeroWT = false;
                EqCount = false;
            }
            else
            {
                WriteText.Text += "4";
            }
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            if (WriteText.Text == "0")
            {
                ZeroWT = true;
            }

            if (ZeroWT == true || EqCount == true)
            {
                WriteText.Clear();
                WriteText.Text += "5";
                ZeroWT = false;
                EqCount = false;
            }
            else
            {
                WriteText.Text += "5";
            }
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            if (WriteText.Text == "0")
            {
                ZeroWT = true;
            }

            if (ZeroWT == true || EqCount == true)
            {
                WriteText.Clear();
                WriteText.Text += "6";
                ZeroWT = false;
                EqCount = false;
            }
            else
            {
                WriteText.Text += "6";
            }
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            if (WriteText.Text == "0")
            {
                ZeroWT = true;
            }

            if (ZeroWT == true || EqCount == true)
            {
                WriteText.Clear();
                WriteText.Text += "7";
                ZeroWT = false;
                EqCount = false;
            }
            else
            {
                WriteText.Text += "7";
            }
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            if (WriteText.Text == "0")
            {
                ZeroWT = true;
            }

            if (ZeroWT == true || EqCount == true)
            {
                WriteText.Clear();
                WriteText.Text += "8";
                ZeroWT = false;
                EqCount = false;
            }
            else
            {
                WriteText.Text += "8";
            }
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            if (WriteText.Text == "0")
            {
                ZeroWT = true;
            }

            if (ZeroWT == true || EqCount == true)
            {
                WriteText.Clear();
                WriteText.Text += "9";
                ZeroWT = false;
                EqCount = false;
            }
            else
            {
                WriteText.Text += "9";
            }
        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            if (WriteText.Text == "")
            {
                string Error = null;
                WriteText.Text = (Error);
            }

            else
            {
                WriteText.Text += ",";
            }
        }
        //Основыне кнопки





        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            d = 1;
            s1 = WriteText.Text;
            WriteText.Clear();
            WriteD.Text = s1 + " + ";     
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            d = 2;
            s1 = WriteText.Text;
            WriteText.Clear();
            WriteD.Text = s1 + " - ";
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            d = 3;
            s1 = WriteText.Text;
            WriteText.Clear();
            WriteD.Text = s1 + " * ";
        }

        private void Separation_Click(object sender, RoutedEventArgs e)
        {
            d = 4;
            s1 = WriteText.Text;
            WriteText.Clear();
            WriteD.Text = s1 + " / ";
        }

        private void Roots_Click(object sender, RoutedEventArgs e)
        {
            //d = 7;
            s = 7;
            r = WriteText.Text;
            string s4;
 

            if (WriteText.Text == "")
            {
                string Error = null;
                WriteText.Text = (Error);
            }

            else
            {

                if (d == 1)
                {
                    s4 = WriteText.Text;
                    WriteText.Clear();
                    WriteText.Text = Convert.ToString(Math.Sqrt (Convert.ToDouble(s4)));
                    WriteD.Text = s1 + " + " + "√" + Convert.ToString(Math.Sqrt(Convert.ToDouble(s4)));
                }
                else if (d == 2)
                {
                    s4 = WriteText.Text;
                    WriteText.Clear();
                    WriteText.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(s4)));
                    WriteD.Text = s1 + " - " + "√" + Convert.ToString(Math.Sqrt(Convert.ToDouble(s4)));
                }
                else if (d == 3)
                {
                    s4 = WriteText.Text;
                    WriteText.Clear();
                    WriteText.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(s4)));
                    WriteD.Text = s1 + " * " + "√" + Convert.ToString(Math.Sqrt(Convert.ToDouble(s4)));
                }
                else if (d == 4)
                {
                    s4 = WriteText.Text;
                    WriteText.Clear();
                    WriteText.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(s4)));
                    WriteD.Text = s1 + " / " + "√" + Convert.ToString(Math.Sqrt(Convert.ToDouble(s4)));
                }
                else
                {
                WriteD.Text = " √ " + r;
                double a = Convert.ToDouble(r);
                a = Math.Sqrt(a);
                WriteText.Text = Convert.ToDouble(a).ToString();
                }
                
            }
        }

        private void _1_x_Click(object sender, RoutedEventArgs e)
        {
            // d = 6;
            s = 6;
            string s4;
            double one = 1;

            if (WriteText.Text == "") 
            {
                string Error = null;
                WriteText.Text = (Error);
            }

            else
            {
                if (d == 1)
                {
                    s4 = WriteText.Text;
                    WriteText.Clear();
                    WriteText.Text = Convert.ToString(one / Convert.ToDouble(s4));
                    WriteD.Text = s1 + " + " + "reciproc" + " (" + s4 + ")" ;
                }
                else if (d == 2)
                {
                    s4 = WriteText.Text;
                    WriteText.Clear();
                    WriteText.Text = Convert.ToString(one / Convert.ToDouble(s4));
                    WriteD.Text = s1 + " - " + "reciproc" + " (" + s4 + ")";
                }
                else if (d == 3)
                {
                    s4 = WriteText.Text;
                    WriteText.Clear();
                    WriteText.Text = Convert.ToString(one / Convert.ToDouble(s4));
                    WriteD.Text = s1 + " * " + "reciproc" + " (" + s4 + ")";
                }
                else if (d == 4)
                {
                    s4 = WriteText.Text;
                    WriteText.Clear();
                    WriteText.Text = Convert.ToString(one / Convert.ToDouble(s4));
                    WriteD.Text = s1 + " / " + "reciproc" + " (" + s4 + ")";
                }
                else
                {
                    s1 = WriteText.Text;
                    WriteD.Text = " reciproc" + " (" + s1 + ")";
                    s3 = Convert.ToString(Convert.ToUInt32(one));
                    WriteText.Text = Convert.ToString(Convert.ToDouble(s3) / Convert.ToDouble(s1));
                }
                
            }
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            s1 = Convert.ToString(zero);
            WriteText.Text = Convert.ToString(Convert.ToDouble(zero));
            WriteD.Clear();
        }

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (EqCount == true && WriteText.Text.Length > 0 )
            {
                WriteText.Text = Convert.ToString(Convert.ToDouble(zero));
                WriteD.Clear();
                EqCount = false;
            }

            else if (WriteText.Text.Length > 0)
            {
                WriteText.Text = WriteText.Text.Substring(0, WriteText.Text.Length - 1);
            }
            else
            {
                WriteText.Text = WriteText.Text.Substring(0, WriteText.Text.Length - 0);
            }
        }

        private void Per_Cent_Click(object sender, RoutedEventArgs e)
        {
            string s4;
            double hangred = 100; 

            if (WriteText.Text == "")
            {
                string Error = null;
                WriteText.Text = (Error);
            }
            
            else
            {
                if (d == 1)
                {
                    s4 = WriteText.Text;
                    WriteText.Clear();
                    WriteText.Text = Convert.ToString(Convert.ToDouble (s1) * Convert.ToDouble (s4) / hangred);
                    WriteD.Text = s1 + " + " + Convert.ToString(Convert.ToDouble(s1) * Convert.ToDouble(s4) / hangred);
                }
                else if (d == 2)
                {
                    s4 = WriteText.Text;
                    WriteText.Clear();
                    WriteText.Text = Convert.ToString(Convert.ToDouble(s1) * Convert.ToDouble(s4) / hangred);
                    WriteD.Text = s1 + " - " + Convert.ToString(Convert.ToDouble(s1) * Convert.ToDouble(s4) / hangred);
                }
                else if (d == 3)
                {
                    s4 = WriteText.Text;
                    WriteText.Clear();
                    WriteText.Text = Convert.ToString(Convert.ToDouble(s1) * Convert.ToDouble(s4) / hangred);
                    WriteD.Text = s1 + " * " + Convert.ToString(Convert.ToDouble(s1) * Convert.ToDouble(s4) / hangred);
                }
                else if (d == 4)
                {
                    s4 = WriteText.Text;
                    WriteText.Clear();
                    WriteText.Text = Convert.ToString(Convert.ToDouble(s1) * Convert.ToDouble(s4) / hangred);
                    WriteD.Text = s1 + " / " + Convert.ToString(Convert.ToDouble(s1) * Convert.ToDouble(s4) / hangred);
                }
            }

        }

        private void Equally_Click(object sender, RoutedEventArgs e)
        {

            if (d == 1)
            {
                if (WriteText.Text == "")
                {
                    MessageBox.Show("Необходимо ввести число");
                }
                else
                {
                    WriteText.Text = Convert.ToString(Convert.ToDouble(s1) + Convert.ToDouble(WriteText.Text));
                    WriteD.Clear();
                }
            }
            else if (d == 2)
            {
                if (WriteText.Text == "")
                {
                    MessageBox.Show("Необходимо ввести число");
                }
                else
                {
                    //var s5 = Convert.ToString(Convert.ToInt32(s1));
                    //var s6 = Convert.ToInt32(WriteText.Text);


                    //string min = "-";


                    //if (s5.Contains(s5) < s6)
                    //{
                    //    WriteText.Text = min + Convert.ToString(Convert.ToInt32(s1) - Convert.ToInt32(WriteText.Text));
                    //}
                    //else
                    //{
                    //    WriteText.Text = Convert.ToString(Convert.ToInt32(s1) - Convert.ToInt32(WriteText.Text));
                    //}



                    WriteText.Text = Convert.ToString(Convert.ToInt64(s1) - Convert.ToInt64(WriteText.Text));
                        
                    //string s9;
                    //string s10;
                    //int min12 = 0;
                    //int s5;
                    //int s6;
                    //s9 = Convert.ToString(Convert.ToInt32(s1));
                    //s10 = Convert.ToString(Convert.ToInt32(WriteText.Text));
                    //s5 = Convert.ToInt32(s1);
                    //s6 = Convert.ToInt32(WriteText.Text);

                    //if (s5 == s6)
                    //{
                    //    WriteText.Text = "-" + (Convert.ToString(Convert.ToInt32(s1) - Convert.ToInt32(WriteText.Text)));
                    //}
                    //else
                    //{
                    //    WriteText.Text = Convert.ToString(Convert.ToInt32(s1) - Convert.ToInt32(WriteText.Text));
                    //}

                    WriteD.Clear();
                }
            }
            else if (d == 3)
            {
                if (WriteText.Text == "")
                {
                    MessageBox.Show("Необходимо ввести число");
                }
                else
                {
                    WriteText.Text = Convert.ToString(Convert.ToDouble(s1) * Convert.ToDouble(WriteText.Text));
                    WriteD.Clear();
                }
            }
            else if (d == 4)
            {
                if (WriteText.Text == "")
                {
                    MessageBox.Show("Необходимо ввести число");
                }
                else
                {
                    if (WriteText.Text == "")
                    {
                        MessageBox.Show("Необходимо ввести число");
                    }
                    else
                    {
                        WriteText.Text = Convert.ToString(Convert.ToDouble(s1) / Convert.ToDouble(WriteText.Text));
                        WriteD.Clear();
                    }
                }
            }
            else if ((d == 6) | (s == 7))
            {
                //WriteText.Text = Convert.ToString(Convert.ToDouble(s3) / Convert.ToDouble(s1));
                WriteD.Clear();
                //WriteText.Text = Convert.ToString(Convert.ToDouble(s1) / Convert.ToDouble(WriteText.Text));
            }
            else if ((d == 7) | (s==7))
            {
                WriteD.Clear();
            }

            else
            {
                MessageBox.Show("Необходимо использовать арифметические действия");
            }

           EqCount = true;
        }
        //Служебные кнопки


        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        //Перемещение формы
    }
}
