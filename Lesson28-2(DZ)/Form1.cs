using System.Text;

namespace Lesson28_2_DZ_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblog.Items.RemoveAt(lbpass.SelectedIndex);
            lbpass.Items.RemoveAt(lbpass.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            int length = random.Next(5, 20);

            for (int i = 0; i < length; i++)
            {
                password.Append(validChars[random.Next(validChars.Length)]);
            }
            lblog.Items.Add(tbusserlog.Text);
            lbpass.Items.Add(password.ToString());
        }
    }
}
