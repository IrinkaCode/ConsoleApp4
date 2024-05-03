namespace Lesson35_2
{
    public partial class Form1 : Form
    {
        private bool fd=true; //ждем первого числа
        private double ac;
        private string op;
        public Form1()
        {
            InitializeComponent();
            ac = 0;
            op = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "Del")
            {
                lbresult.Text = lbresult.Text.Remove(lbresult.Text.Length - 1, 1);
                if (lbresult.Text.Length == 0)
                {
                    lbresult.Text = "0";
                    fd = true;
                }
                return;
            }
            if (char.Parse(btn.Text) >= '1' && char.Parse(btn.Text) <= '9')
            {
                if (op != "") lbresult.Text = "";
                if (fd)
                {
                    lbresult.Text = btn.Text;
                    fd = false;
                }
                else lbresult.Text += btn.Text;
                return;
            }
            if (char.Parse(btn.Text) == '0')
            {
                if (op != "") lbresult.Text = "";
                if (fd) lbresult.Text = btn.Text;
                if (lbresult.Text != "0") lbresult.Text += btn.Text;
                return;
            }
            if (btn.Text == ",")
            {
                if (op != "") lbresult.Text = "";
                if (fd)
                {
                    lbresult.Text = "0,";
                    fd = false;
                }
                else
                {
                    if (lbresult.Text.IndexOf(",") == -1)
                        lbresult.Text += btn.Text;
                }
                return;
            }
            if (char.Parse(btn.Text) == 'C')
            {
                ac = 0;
                fd = true;
                lbresult.Text = "0";
                return;
            }
            if (char.Parse(btn.Text) == '+'||
                char.Parse(btn.Text) == '-'||
                char.Parse(btn.Text) == '*'||
                char.Parse(btn.Text) == '/'||
                char.Parse(btn.Text) == '=')
            {
                double n=0;
                if (fd==false) n=double.Parse(lbresult.Text);
                if(ac==0)
                {
                    ac = n;

                }
                else
                {
                    switch (char.Parse(btn.Text))
                    {
                        case '+': { ac += n; op = "+"; } break;
                        case '-': { ac -= n; op = "-"; } break;
                        case '=':
                            {
                                switch (op)
                                {
                                    case "+": { ac += n; } break;
                                    case "-": { ac -= n; } break;
                                }
                                op = "";
                            }
                            break;
                    }
                    lbresult.Text = ac.ToString("N");
                }
                fd = true;
            }
        }
    }
}
