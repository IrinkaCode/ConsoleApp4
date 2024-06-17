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
           
            string[] text = File.ReadAllLines(filePath);
            
            for(int i = 0; i < text.Length; i++ )
            {
                listBox1.Items.Add(text[i]);
            }
        }
    }
}
    

