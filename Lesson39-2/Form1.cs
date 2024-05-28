namespace Lesson39_2
{
    public partial class Form1 : Form
    {
        private Library library;
        private List<Book> books;
        public Form1()
        {
            InitializeComponent();
            library = new Library();
            books = library.getBooks();
            UpdateForm();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book(textBoxTitle.Text, textBoxAuthor.Text, int.Parse(textBoxYear.Text));
            library.Add(book);
            UpdateForm();
        }
        private void UpdateForm()
        {
            listBox1Title.Items.Clear();
            listBox3Year.Items.Clear();
            listBox2Author.Items.Clear();

            foreach (Book book in books)
            {
                listBox1Title.Items.Add(book.getTitle());
                listBox2Author.Items.Add(book.getAuthor());
                listBox3Year.Items.Add(book.getYear());
            }
            textBoxAuthor.Text = "";
            textBoxTitle.Text = "";
            textBoxYear.Text = "";
            toolStripStatusLabelCountBook.Text = "ÍÓÎË˜ÂÒÚ‚Ó ÍÌË„: " + library.GetCount().ToString();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFilter.Text.Length != 0)
            {
                books = library.getBookByCriteria(textBoxFilter.Text).ToList();
            }
            else
            {
                books = library.getBooks();
            }
            UpdateForm();
        }

        private void Û‰‡ÎËÚ¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string title = listBox1Title.SelectedItem.ToString()!;
            library.Remove(title);
            UpdateForm();
        }
    }
}
