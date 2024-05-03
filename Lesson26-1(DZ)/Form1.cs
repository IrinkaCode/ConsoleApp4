//������� 1 - ����� ������� ������ ���� �������

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
//                MessageBox.Show("������� 1 �����������");
//            }
//            else if (checkBox2.Checked)
//            {
//                MessageBox.Show("������� 2 �����������");
//            }
//            else if (checkBox3.Checked)
//            {
//                MessageBox.Show("������� 3 �����������");
//            }
//            else
//            {
//                MessageBox.Show("��� ������������� �������");
//            }
//        }
//    }
//}



//������� 2 
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
                checkedBoxes += "������� 1 ";
            }

            if (checkBox2.Checked)
            {
                checkedCount++;
                checkedBoxes += "������� 2 ";
            }

            if (checkBox3.Checked)
            {
                checkedCount++;
                checkedBoxes += "������� 3 ";
            }

            if (checkedCount == 0)
            {
                MessageBox.Show("�� ���� ������� �� �����������.");
            }
            else if (checkedCount == 1)
            {
                MessageBox.Show($"����������� {checkedBoxes}");
            }
            else if (checkedCount == 2)
            {
                MessageBox.Show($"����������� {checkedBoxes}");
            }
            else if (checkedCount == 3)
            {
                MessageBox.Show($"����������� ��� �������.");
            }
        }
    }
}
