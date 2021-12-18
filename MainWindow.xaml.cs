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

    //public partial class MainWindow : Window
    //{

    //    int d = 0;
    //    int s = 0;
    //    Переменная действия
    //    string s1;
    //    До действия
    //    string s3;
    //    string r;
    //    int one = 1;
    //    int zero = 0;
    //    bool EqCount = false;
    //    bool ZeroWT = false;
    //    int CountDot = 0;

    //    private void WriteText_TextChanged(object sender, TextChangedEventArgs e)
    //    {
    //        string str = WriteText.Text;
    //        string tmp = WriteText.Text.Trim();
    //        string outS = string.Empty;
    //        bool zapyataya = true;
    //        foreach (char ch in tmp)

    //            if (Char.IsDigit(ch) | Char.IsLetter(ch) || (ch == ',' && zapyataya) || ch == '-' )
    //            {
    //                outS += ch;
    //                if (ch == ',')
    //                    zapyataya = false;
    //            }

    //        WriteText.Text = outS;
    //        WriteText.SelectionStart = outS.Length;
    //    }
    //    Замена . на , и ограничение на ,

    //    public MainWindow()
    //    {
    //        InitializeComponent();
    //        this.WriteText.KeyDown += new KeyEventHandler(WriteText_KeyDown);
    //    }




    //    private void Close_Click(object sender, RoutedEventArgs e)
    //    {
    //        this.Close();
    //    }
    //    Закрытие

    //    private void Minimized_Click(object sender, RoutedEventArgs e)
    //    {
    //    	this.WindowState = WindowState.Minimized;
    //    }
    //    Скрытие




    //    private void Button0_Click(object sender, RoutedEventArgs e)
    //    {
    //        if (WriteText.Text == "0")
    //        {
    //            WriteText.Text += "";
    //        }
    //        else
    //        { 
    //            WriteText.Text += "0";
    //        }
    //    }

    //    private void Button1_Click(object sender, RoutedEventArgs e)
    //    {

    //        if (WriteText.Text == "0")
    //        {
    //            ZeroWT = true;
    //        }

    //        if (ZeroWT == true || EqCount == true)
    //        {
    //            WriteText.Clear();
    //            WriteText.Text += "1";
    //            ZeroWT = false;
    //            EqCount = false;
    //        }
    //        else
    //        {
    //            WriteText.Text += "1";
    //        }

    //    }

    //    private void Button2_Click(object sender, RoutedEventArgs e)
    //    {
    //        if (WriteText.Text == "0")
    //        {
    //            ZeroWT = true;
    //        }

    //        if (ZeroWT == true || EqCount == true)
    //        {
    //            WriteText.Clear();
    //            WriteText.Text += "2";
    //            ZeroWT = false;
    //            EqCount = false;
    //        }
    //        else
    //        {
    //            WriteText.Text += "2";
    //        }
    //    }

    //    private void Button3_Click(object sender, RoutedEventArgs e)
    //    {
    //        if (WriteText.Text == "0")
    //        {
    //            ZeroWT = true;
    //        }

    //        if (ZeroWT == true || EqCount == true)
    //        {
    //            WriteText.Clear();
    //            WriteText.Text += "3";
    //            ZeroWT = false;
    //            EqCount = false;
    //        }
    //        else
    //        {
    //            WriteText.Text += "3";
    //        }
    //    }

    //    private void Button4_Click(object sender, RoutedEventArgs e)
    //    {
    //        if (WriteText.Text == "0")
    //        {
    //            ZeroWT = true;
    //        }

    //        if (ZeroWT == true || EqCount == true)
    //        {
    //            WriteText.Clear();
    //            WriteText.Text += "4";
    //            ZeroWT = false;
    //            EqCount = false;
    //        }
    //        else
    //        {
    //            WriteText.Text += "4";
    //        }
    //    }

    //    private void Button5_Click(object sender, RoutedEventArgs e)
    //    {
    //        if (WriteText.Text == "0")
    //        {
    //            ZeroWT = true;
    //        }

    //        if (ZeroWT == true || EqCount == true)
    //        {
    //            WriteText.Clear();
    //            WriteText.Text += "5";
    //            ZeroWT = false;
    //            EqCount = false;
    //        }
    //        else
    //        {
    //            WriteText.Text += "5";
    //        }
    //    }
    //    private void Button6_Click(object sender, RoutedEventArgs e)
    //    {
    //        if (WriteText.Text == "0")
    //        {
    //            ZeroWT = true;
    //        }

    //        if (ZeroWT == true || EqCount == true)
    //        {
    //            WriteText.Clear();
    //            WriteText.Text += "6";
    //            ZeroWT = false;
    //            EqCount = false;
    //        }
    //        else
    //        {
    //            WriteText.Text += "6";
    //        }
    //    }

    //    private void Button7_Click(object sender, RoutedEventArgs e)
    //    {
    //        if (WriteText.Text == "0")
    //        {
    //            ZeroWT = true;
    //        }

    //        if (ZeroWT == true || EqCount == true)
    //        {
    //            WriteText.Clear();
    //            WriteText.Text += "7";
    //            ZeroWT = false;
    //            EqCount = false;
    //        }
    //        else
    //        {
    //            WriteText.Text += "7";
    //        }
    //    }

    //    private void Button8_Click(object sender, RoutedEventArgs e)
    //    {
    //        if (WriteText.Text == "0")
    //        {
    //            ZeroWT = true;
    //        }

    //        if (ZeroWT == true || EqCount == true)
    //        {
    //            WriteText.Clear();
    //            WriteText.Text += "8";
    //            ZeroWT = false;
    //            EqCount = false;
    //        }
    //        else
    //        {
    //            WriteText.Text += "8";
    //        }
    //    }

    //    private void Button9_Click(object sender, RoutedEventArgs e)
    //    {
    //        if (WriteText.Text == "0")
    //        {
    //            ZeroWT = true;
    //        }

    //        if (ZeroWT == true || EqCount == true)
    //        {
    //            WriteText.Clear();
    //            WriteText.Text += "9";
    //            ZeroWT = false;
    //            EqCount = false;
    //        }
    //        else
    //        {
    //            WriteText.Text += "9";
    //        }
    //    }

    //    private void Dot_Click(object sender, RoutedEventArgs e)
    //    {
    //        if (WriteText.Text == "")
    //        {
    //            string Error = null;
    //            WriteText.Text = (Error);
    //        }

    //        else
    //        {
    //            WriteText.Text += ",";
    //        }
    //    }
    //    Основыне кнопки





    //    private void Plus_Click(object sender, RoutedEventArgs e)
    //    {
    //        d = 1;
    //        s1 = WriteText.Text;
    //        WriteText.Clear();
    //        WriteD.Text = s1 + " + ";     
    //    }

    //    private void Minus_Click(object sender, RoutedEventArgs e)
    //    {
    //        d = 2;
    //        s1 = WriteText.Text;
    //        WriteText.Clear();
    //        WriteD.Text = s1 + " - ";
    //    }

    //    private void Multiplication_Click(object sender, RoutedEventArgs e)
    //    {
    //        d = 3;
    //        s1 = WriteText.Text;
    //        WriteText.Clear();
    //        WriteD.Text = s1 + " * ";
    //    }

    //    private void Separation_Click(object sender, RoutedEventArgs e)
    //    {
    //        d = 4;
    //        s1 = WriteText.Text;
    //        WriteText.Clear();
    //        WriteD.Text = s1 + " / ";
    //    }

    //    private void Roots_Click(object sender, RoutedEventArgs e)
    //    {
    //        d = 7;
    //        s = 7;
    //        r = WriteText.Text;
    //        string s4;
 

    //        if (WriteText.Text == "")
    //        {
    //            string Error = null;
    //            WriteText.Text = (Error);
    //        }

    //        else
    //        {

    //            if (d == 1)
    //            {
    //                s4 = WriteText.Text;
    //                WriteText.Clear();
    //                WriteText.Text = Convert.ToString(Math.Sqrt (Convert.ToDouble(s4)));
    //                WriteD.Text = s1 + " + " + "√" + Convert.ToString(Math.Sqrt(Convert.ToDouble(s4)));
    //            }
    //            else if (d == 2)
    //            {
    //                s4 = WriteText.Text;
    //                WriteText.Clear();
    //                WriteText.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(s4)));
    //                WriteD.Text = s1 + " - " + "√" + Convert.ToString(Math.Sqrt(Convert.ToDouble(s4)));
    //            }
    //            else if (d == 3)
    //            {
    //                s4 = WriteText.Text;
    //                WriteText.Clear();
    //                WriteText.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(s4)));
    //                WriteD.Text = s1 + " * " + "√" + Convert.ToString(Math.Sqrt(Convert.ToDouble(s4)));
    //            }
    //            else if (d == 4)
    //            {
    //                s4 = WriteText.Text;
    //                WriteText.Clear();
    //                WriteText.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(s4)));
    //                WriteD.Text = s1 + " / " + "√" + Convert.ToString(Math.Sqrt(Convert.ToDouble(s4)));
    //            }
    //            else
    //            {
    //            WriteD.Text = " √ " + r;
    //            double a = Convert.ToDouble(r);
    //            a = Math.Sqrt(a);
    //            WriteText.Text = Convert.ToDouble(a).ToString();
    //            }
                
    //        }
    //    }

    //    private void _1_x_Click(object sender, RoutedEventArgs e)
    //    {
    //         d = 6;
    //        s = 6;
    //        string s4;
    //        double one = 1;

    //        if (WriteText.Text == "") 
    //        {
    //            string Error = null;
    //            WriteText.Text = (Error);
    //        }

    //        else
    //        {
    //            if (d == 1)
    //            {
    //                s4 = WriteText.Text;
    //                WriteText.Clear();
    //                WriteText.Text = Convert.ToString(one / Convert.ToDouble(s4));
    //                WriteD.Text = s1 + " + " + "reciproc" + " (" + s4 + ")" ;
    //            }
    //            else if (d == 2)
    //            {
    //                s4 = WriteText.Text;
    //                WriteText.Clear();
    //                WriteText.Text = Convert.ToString(one / Convert.ToDouble(s4));
    //                WriteD.Text = s1 + " - " + "reciproc" + " (" + s4 + ")";
    //            }
    //            else if (d == 3)
    //            {
    //                s4 = WriteText.Text;
    //                WriteText.Clear();
    //                WriteText.Text = Convert.ToString(one / Convert.ToDouble(s4));
    //                WriteD.Text = s1 + " * " + "reciproc" + " (" + s4 + ")";
    //            }
    //            else if (d == 4)
    //            {
    //                s4 = WriteText.Text;
    //                WriteText.Clear();
    //                WriteText.Text = Convert.ToString(one / Convert.ToDouble(s4));
    //                WriteD.Text = s1 + " / " + "reciproc" + " (" + s4 + ")";
    //            }
    //            else
    //            {
    //                s1 = WriteText.Text;
    //                WriteD.Text = " reciproc" + " (" + s1 + ")";
    //                s3 = Convert.ToString(Convert.ToUInt32(one));
    //                WriteText.Text = Convert.ToString(Convert.ToDouble(s3) / Convert.ToDouble(s1));
    //            }
                
    //        }
    //    }

    //    private void CE_Click(object sender, RoutedEventArgs e)
    //    {
    //        s1 = Convert.ToString(zero);
    //        WriteText.Text = Convert.ToString(Convert.ToDouble(zero));
    //        WriteD.Clear();
    //    }

    //    private void Backspace_Click(object sender, RoutedEventArgs e)
    //    {
    //        if (EqCount == true && WriteText.Text.Length > 0 )
    //        {
    //            WriteText.Text = Convert.ToString(Convert.ToDouble(zero));
    //            WriteD.Clear();
    //            EqCount = false;
    //        }

    //        else if (WriteText.Text.Length > 0)
    //        {
    //            WriteText.Text = WriteText.Text.Substring(0, WriteText.Text.Length - 1);
    //        }
    //        else
    //        {
    //            WriteText.Text = WriteText.Text.Substring(0, WriteText.Text.Length - 0);
    //        }
    //    }

    //    private void Per_Cent_Click(object sender, RoutedEventArgs e)
    //    {
    //        string s4;
    //        double hangred = 100; 

    //        if (WriteText.Text == "")
    //        {
    //            string Error = null;
    //            WriteText.Text = (Error);
    //        }
            
    //        else
    //        {
    //            if (d == 1)
    //            {
    //                s4 = WriteText.Text;
    //                WriteText.Clear();
    //                WriteText.Text = Convert.ToString(Convert.ToDouble (s1) * Convert.ToDouble (s4) / hangred);
    //                WriteD.Text = s1 + " + " + Convert.ToString(Convert.ToDouble(s1) * Convert.ToDouble(s4) / hangred);
    //            }
    //            else if (d == 2)
    //            {
    //                s4 = WriteText.Text;
    //                WriteText.Clear();
    //                WriteText.Text = Convert.ToString(Convert.ToDouble(s1) * Convert.ToDouble(s4) / hangred);
    //                WriteD.Text = s1 + " - " + Convert.ToString(Convert.ToDouble(s1) * Convert.ToDouble(s4) / hangred);
    //            }
    //            else if (d == 3)
    //            {
    //                s4 = WriteText.Text;
    //                WriteText.Clear();
    //                WriteText.Text = Convert.ToString(Convert.ToDouble(s1) * Convert.ToDouble(s4) / hangred);
    //                WriteD.Text = s1 + " * " + Convert.ToString(Convert.ToDouble(s1) * Convert.ToDouble(s4) / hangred);
    //            }
    //            else if (d == 4)
    //            {
    //                s4 = WriteText.Text;
    //                WriteText.Clear();
    //                WriteText.Text = Convert.ToString(Convert.ToDouble(s1) * Convert.ToDouble(s4) / hangred);
    //                WriteD.Text = s1 + " / " + Convert.ToString(Convert.ToDouble(s1) * Convert.ToDouble(s4) / hangred);
    //            }
    //        }

    //    }

    //    private void Equally_Click(object sender, RoutedEventArgs e)
    //    {

    //        if (d == 1)
    //        {
    //            if (WriteText.Text == "")
    //            {
    //                MessageBox.Show("Необходимо ввести число");
    //            }
    //            else
    //            {
    //                WriteText.Text = Convert.ToString(Convert.ToDouble(s1) + Convert.ToDouble(WriteText.Text));
    //                WriteD.Clear();
    //            }
    //        }
    //        else if (d == 2)
    //        {
    //            if (WriteText.Text == "")
    //            {
    //                MessageBox.Show("Необходимо ввести число");
    //            }
    //            else
    //            {
    //                var s5 = Convert.ToString(Convert.ToInt32(s1));
    //                var s6 = Convert.ToInt32(WriteText.Text);


    //                string min = "-";


    //                if (s5.Contains(s5) < s6)
    //                {
    //                    WriteText.Text = min + Convert.ToString(Convert.ToInt32(s1) - Convert.ToInt32(WriteText.Text));
    //                }
    //                else
    //                {
    //                    WriteText.Text = Convert.ToString(Convert.ToInt32(s1) - Convert.ToInt32(WriteText.Text));
    //                }



    //                WriteText.Text = Convert.ToString(Convert.ToInt64(s1) - Convert.ToInt64(WriteText.Text));
                        
    //                string s9;
    //                string s10;
    //                int min12 = 0;
    //                int s5;
    //                int s6;
    //                s9 = Convert.ToString(Convert.ToInt32(s1));
    //                s10 = Convert.ToString(Convert.ToInt32(WriteText.Text));
    //                s5 = Convert.ToInt32(s1);
    //                s6 = Convert.ToInt32(WriteText.Text);

    //                if (s5 == s6)
    //                {
    //                    WriteText.Text = "-" + (Convert.ToString(Convert.ToInt32(s1) - Convert.ToInt32(WriteText.Text)));
    //                }
    //                else
    //                {
    //                    WriteText.Text = Convert.ToString(Convert.ToInt32(s1) - Convert.ToInt32(WriteText.Text));
    //                }

    //                WriteD.Clear();
    //            }
    //        }
    //        else if (d == 3)
    //        {
    //            if (WriteText.Text == "")
    //            {
    //                MessageBox.Show("Необходимо ввести число");
    //            }
    //            else
    //            {
    //                WriteText.Text = Convert.ToString(Convert.ToDouble(s1) * Convert.ToDouble(WriteText.Text));
    //                WriteD.Clear();
    //            }
    //        }
    //        else if (d == 4)
    //        {
    //            if (WriteText.Text == "")
    //            {
    //                MessageBox.Show("Необходимо ввести число");
    //            }
    //            else
    //            {
    //                if (WriteText.Text == "")
    //                {
    //                    MessageBox.Show("Необходимо ввести число");
    //                }
    //                else
    //                {
    //                    WriteText.Text = Convert.ToString(Convert.ToDouble(s1) / Convert.ToDouble(WriteText.Text));
    //                    WriteD.Clear();
    //                }
    //            }
    //        }
    //        else if ((d == 6) | (s == 7))
    //        {
    //            WriteText.Text = Convert.ToString(Convert.ToDouble(s3) / Convert.ToDouble(s1));
    //            WriteD.Clear();
    //            WriteText.Text = Convert.ToString(Convert.ToDouble(s1) / Convert.ToDouble(WriteText.Text));
    //        }
    //        else if ((d == 7) | (s==7))
    //        {
    //            WriteD.Clear();
    //        }

    //        else
    //        {
    //            MessageBox.Show("Необходимо использовать арифметические действия");
    //        }

    //       EqCount = true;
    //    }
    //    Служебные кнопки


    //    private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    //    {
    //        this.DragMove();
    //    }
    //    Перемещение формы
    //}


    public partial class MainWindow : Window
    {
        //GLOBALVar's
        private float A, B, C = 0;
        float cB;
        bool Equal_m = false;

        public MainWindow()
        {
            InitializeComponent();
            //this.WriteText.KeyDown += new KeyEventHandler(WriteText_KeyDown);
        }

        private void Close_Click(object sender, RoutedEventArgs e) //Закрытие
        {
            this.Close();
        }

        private void Minimized_Click(object sender, RoutedEventArgs e) //Скрытие
        {
            this.WindowState = WindowState.Minimized;
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) //Перемещение формы
        {
            this.DragMove();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }



        private void One_Click(object sender, RoutedEventArgs e)
        {
            bt_number("1");
        }
        private void Two_Click(object sender, RoutedEventArgs e)
        {
            bt_number("2");
        }
        private void Thre_Click(object sender, RoutedEventArgs e)
        {
            bt_number("3");
        }
        private void Four_Click(object sender, RoutedEventArgs e)
        {
            bt_number("4");
        }
        private void Five_Click(object sender, RoutedEventArgs e)
        {
            bt_number("5");
        }
        private void Six_Click(object sender, RoutedEventArgs e)
        {
            bt_number("6");
        }
        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            bt_number("7");
        }
        private void Aight_Click(object sender, RoutedEventArgs e)
        {
            bt_number("8");
        }
        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            bt_number("9");
        }
        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (WriteText.Text == "0") WriteText.Text += ""; else WriteText.Text += "0";
        }

        /// ---------------------------------------------------------> <FUNCTIONS> <------------------------------------------------------------- ///

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            calculate();
            Equal_m = true;
        }
        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            bt_action("+");
            C = 1;
        }
        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            bt_action("-");
            C = 2;
        }
        private void Mult_Click(object sender, RoutedEventArgs e)
        {
            bt_action("*");
            C = 3;
        }
        private void Div_Click(object sender, RoutedEventArgs e)
        {
            bt_action("/");
            C = 4;
        }
        private void Per_Cent_Click(object sender, RoutedEventArgs e) ///DONT WORK///
        {
            bt_action("%");
            C = 5;
        }
        private void Roots_Click(object sender, RoutedEventArgs e) ///DONT WORK///
        {
            bt_action("√");
            C = 6;
        }
        private void _1_x_Click(object sender, RoutedEventArgs e) ///DONT WORK///
        {
            bt_action("1/x");
            C = 7;
        }
        private void pl_and_mi_Click(object sender, RoutedEventArgs e)
        {
            if (WriteText.Text == "" || (Equal_m == true && WriteText.Text == ""))
            {
                MessageBox.Show("Необходимо ввести число");
            }
            else if (Equal_m == true)
            {
                WriteD.Text = "";
                A = float.Parse(WriteText.Text) * (-1);
                WriteText.Text = A.ToString();
                Equal_m = false;
            }
            else                                        //Для например : -10 --20 = 10
            {
                float cA = float.Parse(WriteText.Text) * (-1);
                WriteText.Text = cA.ToString();
            }
        }

        /// --------------------------------------------------------------> <SERVICES> <-------------------------------------------------------- ///

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            int lenaght = WriteText.Text.Length - 1;
            String sText = WriteText.Text;
            WriteText.Clear();
            for (int i = 0; i < lenaght; i++)
            {
                WriteText.Text = WriteText.Text + sText[i];
            }
            if (WriteD.Text != "") WriteD.Text = ""; //отчиска текста если после вывода результата юзер решил отчистить одну цифру
        }
        private void CE_Click(object sender, RoutedEventArgs e)
        {
            WriteText.Text = "0"; //мне лишний геморой с WriteText.Clear() не нужен
            WriteD.Text = "";
            Equal_m = false;
            B = 0;
            cB = 0;
            A = 0;
            C = 0;
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
        private void WriteText_TextChanged(object sender, TextChangedEventArgs e) //Замена . на , и ограничение на , и возможность вывода минуса
        {
            //string str = WriteText.Text;
            string tmp = WriteText.Text.Trim();
            string outS = string.Empty;
            bool zapyataya = true;
            foreach (char ch in tmp)

                if (Char.IsDigit(ch) | Char.IsLetter(ch) || (ch == ',' && zapyataya || ch == '-'))
                {
                    outS += ch;
                    if (ch == ',')
                        zapyataya = false;
                }

            WriteText.Text = outS;
            WriteText.SelectionStart = outS.Length;
        }

        /// -----------------------------------------------------------> <METHOOOOOOOOOOOOODS> <----------------------------------------------------------- ///

        private void bt_action(string a)
        {
            if (WriteText.Text == "" && WriteD.Text == "")
            {
                string Error = null;
                WriteText.Text = (Error);
            }
            else if (WriteText.Text == "" && WriteD.Text != "") //исключение если юзер Например: после + нажимает * и т.п
            {
                WriteD.Text = A + a;
            }
            else
            {
                A = float.Parse(WriteText.Text);
                WriteD.Text = A.ToString() + a;  //WriteD.Text = WriteText.Text + a; <---- на всякий случай
                Equal_m = false;     // что бы текст из
                cB = 0;              // WriteD не пропадал + обнуление 2-ой перем "B"(её копии)
                WriteText.Clear();
            }
        }
        private void bt_number(string a)
        {
            if (Equal_m == true)
            {
                cB = 0;                             //Убрать зацикливание для B если пользователь перестал клацать ровно по несколько раз
                WriteText.Text = "0";                //и начал вводить новое число.
                WriteD.Text = "";                   //обнулены B и все поля
                if (WriteText.Text == "0") WriteText.Text = a; else WriteText.Text += a;
                Equal_m = false;                    //сброс кнопки ровно.
                C = 0;                              //сброс выбраного действия
            }
            else
            {
                if (WriteText.Text == "0") WriteText.Text = a; else WriteText.Text += a;
            }
        }
        private void calculate()
        {
            Equal_m = true;
            switch (C)
            {
                case 0:
                    {
                        cod_calculate(false);
                        break;
                    }
                case 1:
                    {
                        cod_calculate("+");
                        break;
                    }
                case 2:
                    {
                        cod_calculate("-");
                        break;
                    }
                case 3:
                    {
                        cod_calculate("*");
                        break;
                    }
                case 4:
                    {
                        cod_calculate("/");
                        break;
                    }
                case 5: ///DONT WORK///
                    {
                        cod_calculate("%");
                        break;
                    }
                case 6: ///DONT WORK///
                    {
                        cod_calculate("√"); 
                        break;
                    }
                case 7: ///DONT WORK///
                    {
                        cod_calculate("1/X");
                        break;
                    }
            }
        }

        private void cod_calculate(bool a)
        {
            if (a == false) { WriteD.Text = WriteText.Text + "="; }
        }
        private void cod_calculate(string s)
        {
            if (WriteText.Text == "")
            {
                WriteD.Text += 0;
                WriteText.Text = "0";
            }
            else
            {
                if (cB != 0)
                {
                    A = B;
                    WriteD.Text = A + s + cB;

                    if (C == 1) B = A + cB;
                    if (C == 2) B = A - cB;
                    if (C == 3) B = A * cB;
                    if (C == 4) B = A / cB;
                    if (C == 5) B = A / cB; ///DONT WORK///
                    if (C == 6) B = A / cB; ///DONT WORK///
                    if (C == 7) B = A / cB; ///DONT WORK///

                    WriteText.Text = Convert.ToString(B);
                }
                else
                {
                    if (WriteText.Text == "")
                    {
                        cB = 0;
                    }
                    else if (WriteText.Text == "нечисло")
                    {
                        WriteText.Text = "0";
                        cB = float.Parse(WriteText.Text);
                    }
                    else
                    {
                        cB = float.Parse(WriteText.Text);
                    }

                    WriteD.Text = A + s + float.Parse(WriteText.Text); //убрать запятую в конце

                    if (C == 1) B = A + float.Parse(WriteText.Text);
                    if (C == 2) B = A - float.Parse(WriteText.Text);
                    if (C == 3) B = A * float.Parse(WriteText.Text);
                    if (C == 4) B = A / float.Parse(WriteText.Text);
                    if (C == 5) B = A / float.Parse(WriteText.Text); ///DONT WORK///
                    if (C == 6) B = A / float.Parse(WriteText.Text); ///DONT WORK///
                    if (C == 7) B = A / float.Parse(WriteText.Text); ///DONT WORK///

                    WriteText.Text = Convert.ToString(B);
                }
            }
        }
        //<!--------------------=================================================================================--------------------------------!>//
    }
}
