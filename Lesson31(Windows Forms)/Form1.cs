namespace Lesson31_Windows_Forms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(tbFirst.Text);
                double y = double.Parse(tbSecond.Text);
                double s = x + y;
                lbResult.Text = $"{x}+{y}={s}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSub_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(tbFirst.Text);
                double y = double.Parse(tbSecond.Text);
                double s = x - y;
                lbResult.Text = $"{x}-{y}={s}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btMult_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(tbFirst.Text);
                double y = double.Parse(tbSecond.Text);
                double s = x * y;
                lbResult.Text = $"{x}*{y}={s}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDif_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(tbFirst.Text);
                double y = double.Parse(tbSecond.Text);
                if (y == 0) throw new DivideByZeroException();
                double s = x / y;
                lbResult.Text = $"{x}/{y}={s}";
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("На ноль делить нельзя");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


