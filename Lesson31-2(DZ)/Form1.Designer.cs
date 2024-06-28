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
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(404, 12);
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
            listBox1.Size = new Size(365, 404);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
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
            dateTimePicker1.Location = new Point(404, 231);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(199, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(404, 84);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 49);
            textBox2.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 566);
            Controls.Add(textBox2);
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
    }
}
