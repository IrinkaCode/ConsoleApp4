namespace Lesson39_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listBox1Title = new ListBox();
            listBox2Author = new ListBox();
            listBox3Year = new ListBox();
            label1 = new Label();
            textBoxTitle = new TextBox();
            label2 = new Label();
            textBoxAuthor = new TextBox();
            textBoxYear = new TextBox();
            label3 = new Label();
            buttonAdd = new Button();
            buttonList = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelCountBook = new ToolStripStatusLabel();
            textBoxFilter = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1Title
            // 
            listBox1Title.ContextMenuStrip = contextMenuStrip1;
            listBox1Title.FormattingEnabled = true;
            listBox1Title.Location = new Point(12, 59);
            listBox1Title.Name = "listBox1Title";
            listBox1Title.Size = new Size(242, 424);
            listBox1Title.TabIndex = 0;
            // 
            // listBox2Author
            // 
            listBox2Author.FormattingEnabled = true;
            listBox2Author.Location = new Point(260, 59);
            listBox2Author.Name = "listBox2Author";
            listBox2Author.Size = new Size(234, 424);
            listBox2Author.TabIndex = 1;
            // 
            // listBox3Year
            // 
            listBox3Year.FormattingEnabled = true;
            listBox3Year.Location = new Point(500, 59);
            listBox3Year.Name = "listBox3Year";
            listBox3Year.Size = new Size(183, 424);
            listBox3Year.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(689, 12);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 3;
            label1.Text = "Название";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(689, 35);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(266, 27);
            textBoxTitle.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(701, 75);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 5;
            label2.Text = "Автор";
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(689, 107);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(266, 27);
            textBoxAuthor.TabIndex = 6;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(689, 171);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(266, 27);
            textBoxYear.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(705, 148);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 8;
            label3.Text = "Год издания";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(779, 229);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(176, 67);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Добавить книгу";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonList
            // 
            buttonList.Location = new Point(779, 327);
            buttonList.Name = "buttonList";
            buttonList.Size = new Size(176, 63);
            buttonList.TabIndex = 10;
            buttonList.Text = "Выгрузить список";
            buttonList.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelCountBook });
            statusStrip1.Location = new Point(0, 527);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(967, 26);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCountBook
            // 
            toolStripStatusLabelCountBook.Name = "toolStripStatusLabelCountBook";
            toolStripStatusLabelCountBook.Size = new Size(128, 20);
            toolStripStatusLabelCountBook.Text = "Количество книг:";
            // 
            // textBoxFilter
            // 
            textBoxFilter.Location = new Point(12, 18);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(671, 27);
            textBoxFilter.TabIndex = 12;
            textBoxFilter.TextChanged += textBoxFilter_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { удалитьToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 56);
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(210, 24);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 553);
            Controls.Add(textBoxFilter);
            Controls.Add(statusStrip1);
            Controls.Add(buttonList);
            Controls.Add(buttonAdd);
            Controls.Add(label3);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxAuthor);
            Controls.Add(label2);
            Controls.Add(textBoxTitle);
            Controls.Add(label1);
            Controls.Add(listBox3Year);
            Controls.Add(listBox2Author);
            Controls.Add(listBox1Title);
            Name = "Form1";
            Text = "Учет библиотечных книг";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1Title;
        private ListBox listBox2Author;
        private ListBox listBox3Year;
        private Label label1;
        private TextBox textBoxTitle;
        private Label label2;
        private TextBox textBoxAuthor;
        private TextBox textBoxYear;
        private Label label3;
        private Button buttonAdd;
        private Button buttonList;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelCountBook;
        private TextBox textBoxFilter;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem удалитьToolStripMenuItem;
    }
}
