//вариант 1 - можно выбрать только одну галочку

//namespace Lesson26_1_DZ_
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            if (checkBox1.Checked)
//            {
//                MessageBox.Show("Галочка 1 установлена");
//            }
//            else if (checkBox2.Checked)
//            {
//                MessageBox.Show("Галочка 2 установлена");
//            }
//            else if (checkBox3.Checked)
//            {
//                MessageBox.Show("Галочка 3 установлена");
//            }
//            else
//            {
//                MessageBox.Show("Нет установленных галочек");
//            }
//        }
//    }
//}



//вариант 2 
namespace Lesson26_1_DZ_

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int checkedCount = 0;
            string checkedBoxes = "";

            if (checkBox1.Checked)
            {
                checkedCount++;
                checkedBoxes += "галочка 1 ";
            }

            if (checkBox2.Checked)
            {
                checkedCount++;
                checkedBoxes += "галочка 2 ";
            }

            if (checkBox3.Checked)
            {
                checkedCount++;
                checkedBoxes += "галочка 3 ";
            }

            if (checkedCount == 0)
            {
                MessageBox.Show("Ни одна галочка не установлена.");
            }
            else if (checkedCount == 1)
            {
                MessageBox.Show($"Установлена {checkedBoxes}");
            }
            else if (checkedCount == 2)
            {
                MessageBox.Show($"Установлены {checkedBoxes}");
            }
            else if (checkedCount == 3)
            {
                MessageBox.Show($"Установлены все галочки.");
            }
        }
    }
}
