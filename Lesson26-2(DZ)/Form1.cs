namespace Lesson26_2_DZ_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int firstOperand = Convert.ToInt32(firstOperandTB.Text);
            int secondOperand = Convert.ToInt32(secondOperandTB.Text);
            int total = 0;

            if (summCheckBox1.Checked && !substractCheckBox.Checked && !MultCheckBox.Checked && !DivCheckBox.Checked)
            {
                total = firstOperand + secondOperand;
                resultTB.Text = "Результат: " + total.ToString();
            }
            else if (substractCheckBox.Checked && !summCheckBox1.Checked && !MultCheckBox.Checked && !DivCheckBox.Checked)
            {
                total = firstOperand - secondOperand;
                resultTB.Text = "Результат: " + total.ToString();
            }
            else if (MultCheckBox.Checked && !summCheckBox1.Checked && !substractCheckBox.Checked && !DivCheckBox.Checked)
            {
                total = firstOperand * secondOperand;
                resultTB.Text = "Результат: " + total.ToString();
            }
            else if (DivCheckBox.Checked && !summCheckBox1.Checked && !substractCheckBox.Checked && !MultCheckBox.Checked)
            {
                if (secondOperand != 0)
                {
                    total = firstOperand / secondOperand;
                    resultTB.Text = "Результат: " + total.ToString();
                }
                else
                {
                    MessageBox.Show("Деление на ноль невозможно");
                    resultTB.Text = "Ошибка: деление на ноль";
                }
            }
            else
            {
                MessageBox.Show("Выбрано более одной операции");
                resultTB.Text = "Проверьте флажки";
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            firstOperandTB.Text = "";
            secondOperandTB.Text = "";
            resultTB.Text = "";
        }
    }
}
