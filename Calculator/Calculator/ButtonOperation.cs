using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    static class ButtonOperation
    {

        //Функция убирает фокус с кнопки
        public static void PutAwayFocus(this Button button)
        {
            button.TabStop = false;
            Form.ActiveForm.ActiveControl = null;
        }
        // Выводим в поле имя кнопки
        public static void OutputText(this Button button, TextBox textBox)
        {
            textBox.Text += button.Text;
            if (textBox.Text.Length > 20)
            {
                textBox.Text = textBox.Text.Remove(20);
            }
        }
        public static void ClearInputBeforNewValue(this Button button, TextBox textBox, Label label,ref bool inputAllowed)
        {
            if (inputAllowed) textBox.Text = "";
            inputAllowed = false;
            if (label.Text.Contains("="))
            {
                textBox.Text = "";
                label.Text = "";
                Example.PreLastResult = 0;
                Example.Result = 0;
                Example.TextViewExmpl = "";
            }
        }
    }
}
