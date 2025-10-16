using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button0.Click += ButtonNumberClick;
            button1.Click += ButtonNumberClick;
            button2.Click += ButtonNumberClick;
            button3.Click += ButtonNumberClick;
            button4.Click += ButtonNumberClick;
            button5.Click += ButtonNumberClick;
            button6.Click += ButtonNumberClick;
            button7.Click += ButtonNumberClick;
            button8.Click += ButtonNumberClick;
            button9.Click += ButtonNumberClick;
        }

        bool newInputAllowed = true;

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
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            HandleOperatorButton(Example.Plus, "+", buttonPlus.PutAwayFocus);
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            
            HandleOperatorButton(Example.Minus, "-", buttonMinus.PutAwayFocus);
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            HandleOperatorButton(Example.Multiply, "*", buttonMultiply.PutAwayFocus);
        }
        private void buttonDivision_Click(object sender, EventArgs e)
        {
            
            HandleOperatorButton(Example.Division, "/", buttonDivision.PutAwayFocus);
        }
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            buttonPlus.PutAwayFocus();
            newInputAllowed = true;
            if (textBoxEnter.Text == "Превышен лимит")
            {
                buttonDelete.PerformClick();
                return;
            }
            if(string.IsNullOrWhiteSpace(textBoxEnter.Text))
                return;
            Example.PreLastResult = Example.Result;
            Example.Calculate(labelOutputResult.Text, Convert.ToDouble(textBoxEnter.Text));
            labelOutputResult.Text = Example.TextViewExmpl;
            textBoxEnter.Text = Example.Result.ToString();
            textBoxEnter.Text = Example.CheckBigValue(textBoxEnter);

        }
        //Функция для стирания одного числа при нажатии на кнопку
        private void buttonCorrect_Click(object sender, EventArgs e)
        {
            buttonCorrect.PutAwayFocus();
            if (textBoxEnter.Text.Length > 0)
                textBoxEnter.Text = textBoxEnter.Text.Remove(textBoxEnter.Text.Length - 1);
            if(textBoxEnter.Text.Length < 1)
            {
                newInputAllowed = true;
                textBoxEnter.Text = "0";
            }
        }
        //Функция для удаления данных примера и очистка поля вывода - ввода
        private void buttonDeleteEnter_Click(object sender, EventArgs e)
        {
            buttonDeleteEnter.PutAwayFocus();
            newInputAllowed = true;
            textBoxEnter.Text = "0";
        }
        //Функция очищает строку ввода
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            buttonDelete.PutAwayFocus();
            newInputAllowed = true;
            textBoxEnter.Text = "0";
            labelOutputResult.Text = string.Empty;
            Example.Clear();
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
            if (labelOutputResult.Text.Contains("="))
                labelOutputResult.Text = "";
            textBoxEnter.Text = (Convert.ToDouble(textBoxEnter.Text) * -1).ToString();
            Example.Result = Convert.ToDouble(textBoxEnter.Text);
            Example.TextViewExmpl = "  " + Example.Result + " = ";
        }

        private void textBoxEnter_Click(object sender, EventArgs e)
        {
            textBoxEnter.TabStop = false;
            ActiveControl = null;
        }
        
        private void HandleOperatorButton(Func<double, double> operationFunc, string operatorSymbol, Action focusAction)
        {
            focusAction?.Invoke();

            textBoxEnter.Text = textBoxEnter.Text == "Превышен лимит" ? "0" : textBoxEnter.Text;

            if (TryAppendOperator(operatorSymbol)
                || InitializeOperationIfZero(operatorSymbol)
                || TryPrepareForNewOperation(operatorSymbol))
                return;

            buttonEquals.PerformClick();
            Example.PreLastResult = Example.Result;
            HandleOperator(operationFunc, operatorSymbol);

            textBoxEnter.Text = Example.CheckBigValue(textBoxEnter);
            newInputAllowed = true;
        }
        private bool TryAppendOperator(string operatorSymbol)
        {
            if (!labelOutputResult.Text.Contains(operatorSymbol) && !string.IsNullOrWhiteSpace(labelOutputResult.Text))
            {
                if(!newInputAllowed)
                    buttonEquals.PerformClick();
                labelOutputResult.Text = Example.Result + operatorSymbol;
                return true;
            }
            return false;
        }
        private bool TryPrepareForNewOperation(string operatorSymbol)
        {
            if (labelOutputResult.Text.Contains("="))
            {
                labelOutputResult.Text = Example.Result + $" {operatorSymbol} ";
                textBoxEnter.Text = Example.Result.ToString();
                return true;
            }
            return false;
        }

        private void HandleOperator(Func<double, double> operationFunc, string operatorSymbol)
        {
            if (labelOutputResult.Text.Contains("="))
                labelOutputResult.Text = Example.PreLastResult + $" {operatorSymbol} ";
            else if(string.IsNullOrWhiteSpace(textBoxEnter.Text))
                labelOutputResult.Text = operationFunc.Invoke(Convert.ToDouble(textBoxEnter.Text)) + $" {operatorSymbol} ";
            textBoxEnter.Text = string.Empty;
        }
        private bool InitializeOperationIfZero(string operatorSymbol)
        {
            if (Example.PreLastResult == 0 && Example.Result == 0)
            {
                Example.Result = Convert.ToDouble(textBoxEnter.Text);
                labelOutputResult.Text = Example.Result + $"{operatorSymbol}";
                return true;
            }
            return false;
        }
        private void ButtonNumberClick(object sender, EventArgs e)
        {
            ((Button)sender).PutAwayFocus();
            ((Button)sender).ClearInputBeforNewValue(textBoxEnter, labelOutputResult,ref newInputAllowed);
            ((Button)sender).OutputText(textBoxEnter);
        }
    }
}