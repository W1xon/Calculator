using System.Windows.Forms;

namespace Calculator
{
    class Example
    {
        public static double Result { get; set; }
        public static double PreLastResult { get; set; }
        public static string TextViewExmpl { get; set; }
        //Деление
        public static double Division(double number)
        {
            TextViewExmpl = PreLastResult + " / " + number + " = ";
            Result = Result / number;
            return Result;
        }
        //Умножение
        public static double Multiply(double number)
        {
            TextViewExmpl = PreLastResult + " * " + number + " = ";
            Result = Result * number;
            return Result;
        }
        //Сложение
        public static double Plus(double number)
        {
            TextViewExmpl = PreLastResult + " + " + number + " = ";
            Result = Result + number;
            return Result;
        }
        //Вычитаниеk
        public static double Minus(double number)
        {
            TextViewExmpl = PreLastResult + " - " + number + " = ";
            Result = Result - number;
            return Result;
        }

        public static void Clear()
        {
            PreLastResult = 0;
            Result = 0;
            TextViewExmpl = "";
        }

        public static void Calculate(string labelResult, double number)
        {
            if (labelResult.Contains("/")) { Division(number); }
            else if (labelResult.Contains("*")) { Multiply(number); }
            else if (labelResult.Contains("+")) { Plus(number); }
            else if (labelResult.Contains("-")) { Minus(number); }

        }
        public static string CheckBigValue(TextBox textBox)
        {
            if (Result.ToString().Length > 20)
            {
                Result = 0;
                PreLastResult = 0;
                TextViewExmpl = "";
                return "Превышен лимит";
            }
            return textBox.Text;
        }
    }
}
