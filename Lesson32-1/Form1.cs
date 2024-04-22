namespace Lesson32_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chbMark_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMark.Checked)
            {
                chbMark.Text = "���������-.����";
                lbMark.Text = "���������";
            }
            else
            {
                chbMark.Text = "����->���������";
                lbMark.Text = "����";
            }
        }

        private void btMark_Click(object sender, EventArgs e)
        {
            const double MILLS = 1.62;
            double mark;
            double.TryParse(tbMark.Text, out mark);
            if (chbMark.Checked)
            {
                lbResult.Text = $"{mark} �� ={mark / MILLS:F2} ����";
            }
            else
            {
                lbResult.Text = $"{mark} ���� ={mark * MILLS:F2} ��";
            }
            tbMark.Focus();
        }

        private void tbMark_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (tbMark.Text.IndexOf(',') != -1)
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    btMark.Focus();
                }
                return;
            }
            e.Handled = true;
        }

        private void tbMark_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbMark.Text.Length > 0)
                {
                    if (double.Parse(tbMark.Text) > double.MaxValue)
                        throw new Exception("����� ������� �� �������");
                    else btMark_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
