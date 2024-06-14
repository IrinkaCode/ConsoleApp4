namespace Lesson31_2_DZ_
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
            textBox1 = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            listBox1 = new ListBox();
            btnSearch = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            listBox2 = new ListBox();
            textBox3 = new TextBox();
            listBox3 = new ListBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 316);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 49);
            textBox1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 442);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(236, 67);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить событие";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(449, 442);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(224, 67);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Удалить событие";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(218, 264);
            listBox1.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(247, 442);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(206, 67);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Поиск";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(18, 535);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(199, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(236, 316);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 49);
            textBox2.TabIndex = 8;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(236, 12);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(207, 264);
            listBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(449, 316);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(221, 49);
            textBox3.TabIndex = 9;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(449, 12);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(221, 264);
            listBox3.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 566);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnSearch);
            Controls.Add(listBox1);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Календарь";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnAdd;
        private Button btnRemove;
        private ListBox listBox1;
        private Button btnSearch;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private ListBox listBox2;
        private TextBox textBox3;
        private ListBox listBox3;
    }
}
