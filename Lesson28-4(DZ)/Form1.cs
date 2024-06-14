using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;


namespace Lesson28_4_DZ_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = textBox1.Text;
            FileInfo file = new FileInfo(filePath);
            string text = File.ReadAllText(filePath);
            string[] textSort = text.Split('\n');
            foreach (string s in textSort)
            {
                listBox1.Items.Add(s);
            }
        }
    }
}
    

