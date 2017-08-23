using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PolishNotationCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {


                if (Regex.IsMatch(tbExpression.Text, @"^[a-zA-Z]+$|^[а-яА-Я]+$"))
                    throw new Exception();
                else
                {
                    lblResult.Text = "Результат: " + PN.Calculate(tbExpression.Text);
                }
            }
            catch
            {
                MessageBox.Show("Введено некорректное выражение.", "Внимание");
                tbExpression.Clear();
            }
        }

        private void tbExpression_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Oemplus)
                btnResult.PerformClick();
        }
    }
}
