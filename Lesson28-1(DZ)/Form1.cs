namespace Lesson28_1_DZ_
{
    using Lesson28_1_DZ_.RandomQuoteApp;
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    namespace RandomQuoteApp
    {
        public partial class QuoteManager
        {
            public static List<string> quotes = new List<string>
        {
            "����� - ��� ����������� ���� �� ����� ������� � ������, �� ������� ����������. - ������� ��������",
            "���� ����������, ������� �� ������ ������ � ����. - ������� �����",
            "������ ������ ����������� ������� - ������� ���. - ����� ������",
            "��������� - ��� �����������, ������� � ���������� �������. - ������� ��������",
            "�� �����, ������� ��� �� ������� - �����, ������� ��� �� ������������. - ������� �����"
        };
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int index = random.Next(QuoteManager.quotes.Count);
            label1.Text = QuoteManager.quotes[index];
        }
    }

}
