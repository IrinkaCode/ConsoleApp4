namespace Lesson33_1
{
    public partial class Form1 : Form
    {
        public double Price;
        public Form1()
        {
            InitializeComponent();
        }

        private void lbxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        { 
            try
            {
                switch (lbxMaterial.SelectedIndex)
                {
                    case 0:
                        {
                            Calculate("allum.jpeg", 300);
                        }
                        break;
                    case 1:
                        {
                            Calculate("plastic.jpeg", 150);
                        }
                        break;
                    case 2:
                        {
                            Calculate("wood.jpeg", 120);
                        }
                        break;
                    case 3:
                        {
                            Calculate("bambuk.gpeg.jpg", 180);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button_Click()
        {
            lbResult.Text = (double.Parse(tbxWidth.Text) * double.Parse(tbxHeight.Text) * Price).ToString("c");
        }
        private void Calculate(string path,double price)
        {
            pbxMaterial.Image=Image.FromFile(path);
            Price=price;
            button_Click();
        }
    }
}
