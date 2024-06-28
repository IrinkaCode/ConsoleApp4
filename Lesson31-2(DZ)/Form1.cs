using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lesson31_2_DZ_
{
    public partial class Form1 : Form
    {
        public class CalendarEvent
        {
            public string Name { get; set; }
            public DateTime Date { get; set; }
            public string Description { get; set; }

            public CalendarEvent(string name, DateTime date, string description)
            {
                Name = name;
                Date = date;
                Description = description;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        private List<CalendarEvent> events;

        public Form1()
        {
            InitializeComponent();
            events = new List<CalendarEvent>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            DateTime date = dateTimePicker1.Value;
            string description = textBox2.Text;

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(description))
            {
                CalendarEvent newEvent = new CalendarEvent(name, date, description);
                events.Add(newEvent);
                UpdateEventsList();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("����������, ��������� ��� ����!");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            CalendarEvent eventToRemove = events.Find(ev => ev.Name == name)!;

            if (eventToRemove != null)
            {
                events.Remove(eventToRemove);
                UpdateEventsList();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("������� �� �������");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            List<CalendarEvent> searchResults = events.Where(ev =>
                ev.Name.Contains(searchText) ||
                ev.Date.ToString().Contains(searchText) ||
                ev.Description.Contains(searchText)).ToList();

            listBox1.DataSource = searchResults;
            listBox1.DisplayMember = "Name";
        }

        private void UpdateEventsList()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = events;
            listBox1.DisplayMember = "Name";
        }

        private void ClearInputFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                textBox1.Text = events[listBox1.SelectedIndex].Name;
                textBox2.Text = events[listBox1.SelectedIndex].Description;
                dateTimePicker1.Value = events[listBox1.SelectedIndex].Date;
            }
        }
    }
}


