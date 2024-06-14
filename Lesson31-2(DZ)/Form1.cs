using System;
using System.Collections.Generic;
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
            DateTime date = DateTimePicker.MaximumDateTime;
            string description = textBox1.Text;

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(description))
            {
                CalendarEvent newEvent = new CalendarEvent(name, date, description);
                events.Add(newEvent);
                UpdateEventsList();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            CalendarEvent btnRemove = events.Find(e => e.Name == name)!;

            if (btnRemove != null)
            {
                events.Remove(btnRemove);
                UpdateEventsList();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Событие не найдено");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string searchText = textBox1.Text;
            List<CalendarEvent> searchResults = events.Where(e =>
                e.Name.Contains(searchText) ||
                e.Date.ToString().Contains(searchText) ||
                e.Description.Contains(searchText)).ToList();

            listBox1.DataSource = searchResults;
            listBox1.DisplayMember = "Name";

        }
        private void UpdateEventsList()
        {
            listBox1.DataSource = events;
            listBox1.DisplayMember = "Name";
        }

        private void ClearInputFields()
        {
            textBox1.Text = "";
            textBox1.Text = "";
        }
    }

}

