namespace Lesson35_3
{
    public partial class Form1 : Form
    {
        private Converter converter;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                Generation generation = new Generation(int.Parse(tb1.Text), int.Parse(tb2.Text));
                tbResult.Text = generation.getNumber().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxLong_SelectedIndexChanged(object sender, EventArgs e)
        {
            converter = new Converter(double.Parse (tbxNumber.Text));
            switch(cbxLong.SelectedIndex) 
            {
            case 0:lbResult.Text=converter.toSm().ToString("F5")+" сантиметров"; break;
            case 1: lbResult.Text = converter.toDm().ToString("F5")+" дециметров"; break;
            case 2: lbResult.Text = converter.toMetr().ToString("F5")+ " метров"; break;
            case 3: lbResult.Text = converter.toKm().ToString("F5")+ " километров"; break;
            }
        }
    }
}
