using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool newInputAllowed = true;
        //Обработка нажатия по цифрам
        #region  
        //Нажатие на цифру 1
        private void button1_Click(object sender, EventArgs e)
        {
            button1.PutAwayFocus();
            button1.ClearInputBeforNewValue(textBoxEnter, labeloutputResalt,ref newInputAllowed);
            button1.OutputText(textBoxEnter);
        }
        //Нажатие на цифру 2
        private void button2_Click(object sender, EventArgs e)
        {
            button2.PutAwayFocus();
            button2.ClearInputBeforNewValue(textBoxEnter, labeloutputResalt, ref newInputAllowed);
            button2.OutputText(textBoxEnter);
        }
        //Нажатие на цифру 3
        private void button3_Click(object sender, EventArgs e)
        {
            button3.PutAwayFocus();
            button3.ClearInputBeforNewValue(textBoxEnter, labeloutputResalt, ref newInputAllowed);
            button3.OutputText(textBoxEnter);
        }
        //Нажатие на цифру 4
        private void button4_Click(object sender, EventArgs e)
        {
            button4.PutAwayFocus();
            button4.ClearInputBeforNewValue(textBoxEnter, labeloutputResalt, ref newInputAllowed);
            button4.OutputText(textBoxEnter);
        }
        //Нажатие на цифру 5
        private void button5_Click(object sender, EventArgs e)
        {
            button5.PutAwayFocus();
            button5.ClearInputBeforNewValue(textBoxEnter, labeloutputResalt, ref newInputAllowed);
            button5.OutputText(textBoxEnter);
        }
        //Нажатие на цифру 6
        private void button6_Click(object sender, EventArgs e)
        {
            button6.PutAwayFocus();
            button6.ClearInputBeforNewValue(textBoxEnter, labeloutputResalt, ref newInputAllowed);
            button6.OutputText(textBoxEnter);
        }
        //Нажатие на цифру 7
        private void button7_Click(object sender, EventArgs e)
        {
            button7.PutAwayFocus();
            button7.ClearInputBeforNewValue(textBoxEnter, labeloutputResalt, ref newInputAllowed);
            button7.OutputText(textBoxEnter);
        }
        //Нажатие на цифру 8
        private void button8_Click(object sender, EventArgs e)
        {
            button8.PutAwayFocus();
            button8.ClearInputBeforNewValue(textBoxEnter, labeloutputResalt, ref newInputAllowed);
            button8.OutputText(textBoxEnter);
        }
        //Нажатие на цифру 9
        private void button9_Click(object sender, EventArgs e)
        {
            button9.PutAwayFocus();
            button9.ClearInputBeforNewValue(textBoxEnter, labeloutputResalt, ref newInputAllowed);
            button9.OutputText(textBoxEnter);

        }
        //Нажатие на цифру 0
        private void button0_Click(object sender, EventArgs e)
        {
            button0.PutAwayFocus();
            if (!textBoxEnter.Text.Equals("0") && !newInputAllowed)
            {
                button0.OutputText(textBoxEnter);
            }
            else
            {
                button0.ClearInputBeforNewValue(textBoxEnter, labeloutputResalt, ref newInputAllowed);
                button0.OutputText(textBoxEnter);
            }
        }
        #endregion // 

        //Обработчик нажатия клавиш
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    buttonEquals.PerformClick();
                    break;
                case Keys.Multiply:
                    buttonMultiply.PerformClick();
                    break;
                case Keys.Add:
                    buttonPlus.PerformClick();
                    break;
                case Keys.Subtract:
                    buttonMinus.PerformClick();
                    break;
                case Keys.Divide:
                    buttonDivision.PerformClick();
                    break;
                case Keys.Delete:
                    buttonDelete.PerformClick();
                    break;
                case Keys.Back:
                    buttonCorrect.PerformClick();
                    break;
                case Keys.Oemcomma:
                    buttonComma.PerformClick();
                    break;

                case Keys.D1:
                    button1.PerformClick();
                    break;
                case Keys.D2:
                    button2.PerformClick();
                    break;
                case Keys.D3:
                    button3.PerformClick();
                    break;
                case Keys.D4:
                    button4.PerformClick();
                    break;
                case Keys.D5:
                    button5.PerformClick();
                    break;
                case Keys.D6:
                    button6.PerformClick();
                    break;
                case Keys.D7:
                    button7.PerformClick();
                    break;
                case Keys.D8:
                    button8.PerformClick();
                    break;
                case Keys.D9:
                    button9.PerformClick();
                    break;
                case Keys.D0:
                    button0.PerformClick();
                    break;

                case Keys.NumPad0:
                    button0.PerformClick();
                    break;
                case Keys.NumPad1:
                    button1.PerformClick();
                    break;
                case Keys.NumPad2:
                    button2.PerformClick();
                    break;
                case Keys.NumPad3:
                    button3.PerformClick();
                    break;
                case Keys.NumPad4:
                    button4.PerformClick();
                    break;
                case Keys.NumPad5:
                    button5.PerformClick();
                    break;
                case Keys.NumPad6:
                    button6.PerformClick();
                    break;
                case Keys.NumPad7:
                    button7.PerformClick();
                    break;
                case Keys.NumPad8:
                    button8.PerformClick();
                    break;
                case Keys.NumPad9:
                    button9.PerformClick();
                    break;
            }
            if (textBoxEnter.Text.Length > 20) { textBoxEnter.Text = textBoxEnter.Text.Remove(20); }
        }
        //Функция для прибавления чисел при нажатии на кнопку
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            //Код проверяет чтобы при выводе примера не было лишнего нуля в далее аналогичный код
            buttonPlus.PutAwayFocus();
            //позволяет менять  математические операторы
            textBoxEnter.Text = textBoxEnter.Text == "Превышен лимит" ? "0" : textBoxEnter.Text;
            if (!labeloutputResalt.Text.Contains("+") && labeloutputResalt.Text != "")
            {
                if (!newInputAllowed)
                    buttonEquals.PerformClick();
                labeloutputResalt.Text = Example.Result + " + ";
            }
            else
            {
                if (Example.PreLastResult == 0 && Example.Result == 0)
                {
                    Example.Result = Convert.ToDouble(textBoxEnter.Text);
                    labeloutputResalt.Text = Example.Result + " + ";
                }
                else
                {
                    if (labeloutputResalt.Text.Contains("="))
                    {
                        labeloutputResalt.Text = Example.Result.ToString() + "+";
                        textBoxEnter.Text = Example.Result.ToString();
                    }
                    else
                    {
                        //решаем пример перед писвоением результата
                        buttonEquals.PerformClick();
                        //
                        Example.PreLastResult = Example.Result;
                        if (labeloutputResalt.Text.Contains("="))
                            labeloutputResalt.Text = Example.PreLastResult.ToString() + " + ";
                        else
                            labeloutputResalt.Text = Example.Plus(Convert.ToDouble(textBoxEnter.Text)).ToString() + " + ";
                        textBoxEnter.Text = Example.PreLastResult.ToString();
                    }
                }
            }
            textBoxEnter.Text = Example.CheckBigValue(textBoxEnter);
            newInputAllowed = true;
        }
        //Функция для вычитания при нажатии на кнопку
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            buttonPlus.PutAwayFocus();
            textBoxEnter.Text = textBoxEnter.Text == "Превышен лимит" ? "0" : textBoxEnter.Text;
            if (!labeloutputResalt.Text.Contains("-") && labeloutputResalt.Text != "")
            {
                if (!newInputAllowed)
                    buttonEquals.PerformClick();
                labeloutputResalt.Text = Example.Result + " - ";
            }
            else
            {
                if (Example.PreLastResult == 0 && Example.Result == 0)
                {
                    Example.Result = Convert.ToDouble(textBoxEnter.Text);
                    labeloutputResalt.Text = Example.Result + " - ";
                }
                else
                {
                    if (labeloutputResalt.Text.Contains("="))
                    {
                        labeloutputResalt.Text = Example.Result.ToString() + " - ";
                        textBoxEnter.Text = Example.Result.ToString();
                    }
                    else
                    {
                        buttonEquals.PerformClick();
                        Example.PreLastResult = Example.Result;
                        if (labeloutputResalt.Text.Contains("="))
                            labeloutputResalt.Text = Example.PreLastResult.ToString() + " - ";
                        else
                            labeloutputResalt.Text = Example.Minus(Convert.ToDouble(textBoxEnter.Text)).ToString() + " - ";
                        textBoxEnter.Text = Example.PreLastResult.ToString();
                    }
                }
            }
            textBoxEnter.Text = Example.CheckBigValue(textBoxEnter);
            newInputAllowed = true;
        }
        //Функция для умножения при нажатии на кнопку
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            buttonPlus.PutAwayFocus();
            textBoxEnter.Text = textBoxEnter.Text == "Превышен лимит" ? "0" : textBoxEnter.Text;
            if (!labeloutputResalt.Text.Contains("*") && labeloutputResalt.Text != "") 
            {
                if (!newInputAllowed)
                    buttonEquals.PerformClick();
                labeloutputResalt.Text = Example.Result + " * ";
            }
            else
            {
                if (Example.PreLastResult == 0 && Example.Result == 0)
                {
                    Example.Result = Convert.ToDouble(textBoxEnter.Text);
                    labeloutputResalt.Text = Example.Result + " * ";
                }
                else
                {
                    if (labeloutputResalt.Text.Contains("="))
                    {
                        labeloutputResalt.Text = Example.Result.ToString() + "*";
                        textBoxEnter.Text = Example.Result.ToString();
                    }
                    else
                    {
                        buttonEquals.PerformClick();
                        Example.PreLastResult = Example.Result;
                        if (labeloutputResalt.Text.Contains("="))
                            labeloutputResalt.Text = Example.PreLastResult.ToString() + " * ";
                        else
                            labeloutputResalt.Text = Example.Multiply(Convert.ToDouble(textBoxEnter.Text)).ToString() + " * ";
                        textBoxEnter.Text = Example.PreLastResult.ToString();
                    }
                }
            }
            textBoxEnter.Text = Example.CheckBigValue(textBoxEnter);
            newInputAllowed = true;
        }
        //Функция для деления при нажатии на кнопку
        private void buttonDivision_Click(object sender, EventArgs e)
        {
            buttonPlus.PutAwayFocus();
            textBoxEnter.Text = textBoxEnter.Text == "Превышен лимит" ? "0" : textBoxEnter.Text;
            if (!labeloutputResalt.Text.Contains("/") && labeloutputResalt.Text != "")
            {
                if(!newInputAllowed)
                    buttonEquals.PerformClick();
                labeloutputResalt.Text = Example.Result + " / "; 
            }
            else
            {
                if (labeloutputResalt.Text.Contains("="))
                {
                    labeloutputResalt.Text = Example.Result.ToString() + " / ";
                    textBoxEnter.Text = Example.Result.ToString();
                }
                else
                {
                    if (Example.PreLastResult == 0 && Example.Result == 0)
                    {

                        Example.PreLastResult = Example.Result;
                        Example.Result = Convert.ToDouble(textBoxEnter.Text);
                        labeloutputResalt.Text = Example.Result + " / ";
                    }
                    else
                    {

                        buttonEquals.PerformClick();
                        Example.PreLastResult = Example.PreLastResult == 0 ? Convert.ToDouble(textBoxEnter.Text) : Example.Result;
                        if (labeloutputResalt.Text.Contains("="))
                            labeloutputResalt.Text = Example.PreLastResult.ToString() + " / ";
                        else
                            labeloutputResalt.Text = Example.Division(Convert.ToDouble(textBoxEnter.Text)).ToString() + " / ";
                        textBoxEnter.Text = Example.PreLastResult.ToString();
                    }
                }
            }
            textBoxEnter.Text = Example.CheckBigValue(textBoxEnter);
            newInputAllowed = true;
        }
       //Функция вывода результата при нажатии на кнопку
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            buttonPlus.PutAwayFocus();
            newInputAllowed = true;
            if (textBoxEnter.Text == "Превышен лимит")
                buttonDelete.PerformClick();
            Example.PreLastResult = Example.Result;
            if (labeloutputResalt.Text.Contains("/")) { Example.Division(Convert.ToDouble(textBoxEnter.Text)); }
            else if (labeloutputResalt.Text.Contains("*")) { Example.Multiply(Convert.ToDouble(textBoxEnter.Text)); }
            else if (labeloutputResalt.Text.Contains("+")) { Example.Plus(Convert.ToDouble(textBoxEnter.Text)); }
            else if (!labeloutputResalt.Text.Contains("  -") && labeloutputResalt.Text.Contains("-")) { Example.Minus(Convert.ToDouble(textBoxEnter.Text)); }
            labeloutputResalt.Text = Example.TextViewExmpl;
            textBoxEnter.Text = Example.Result.ToString();
            Example.Result = Convert.ToDouble(textBoxEnter.Text);
            textBoxEnter.Text = Example.CheckBigValue(textBoxEnter);

        }
        //Функция для стирания одного числа при нажатии на кнопку   23.1235
        private void buttonCorrect_Click(object sender, EventArgs e)
        {
            buttonCorrect.PutAwayFocus();
            if (textBoxEnter.Text.Length > 0)
                textBoxEnter.Text = textBoxEnter.Text.Remove(textBoxEnter.Text.Length - 1);
            if(textBoxEnter.Text.Length < 1)
            {
                newInputAllowed = true;
                textBoxEnter.Text = textBoxEnter.Text.Length < 1 ? "0" : textBoxEnter.Text;
            }
        }
        //Функция для удаления данных примера и очистка поля вывода - ввода
        private void buttonDeleteEnter_Click(object sender, EventArgs e)
        {
            buttonDeleteEnter.PutAwayFocus();
            newInputAllowed = true;
            textBoxEnter.Text = "0";
        }
        //Функция очишает чтроку ввода
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            buttonDelete.PutAwayFocus();
            newInputAllowed = true;
            textBoxEnter.Text = "0";
            labeloutputResalt.Text = "";
            Example.PreLastResult = 0;
            Example.Result = 0;
            Example.TextViewExmpl = "";
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            newInputAllowed = false;
            buttonDelete.PutAwayFocus();
            if (!textBoxEnter.Text.Contains(","))
                textBoxEnter.Text += ",";
        }

        private void buttonModule_Click(object sender, EventArgs e)
        {
            buttonModule.PutAwayFocus();
            if (labeloutputResalt.Text.Contains("="))
                labeloutputResalt.Text = "";
            textBoxEnter.Text = (Convert.ToDouble(textBoxEnter.Text) * -1).ToString();
            Example.Result = Convert.ToDouble(textBoxEnter.Text);
            Example.TextViewExmpl = "  " + Example.Result + " = ";
        }

        private void textBoxEnter_Click(object sender, EventArgs e)
        {
            textBoxEnter.TabStop = false;
            ActiveControl = null;
        }
    }
}
