namespace Lesson28_2_DZ_
{
    partial class TextBox
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
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            listBox1 = new ListBox();
            ComboBox = new ListBox();
            ListBox = new ListBox();
            Button = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(12, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 34);
            textBox1.TabIndex = 0;
            textBox1.Text = "Имя пользователя";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(227, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 34);
            textBox2.TabIndex = 1;
            textBox2.Text = "Логин:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(383, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(207, 34);
            textBox3.TabIndex = 2;
            textBox3.Text = "Пароль:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(209, 104);
            listBox1.TabIndex = 3;
            // 
            // ComboBox
            // 
            ComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ComboBox.FormattingEnabled = true;
            ComboBox.ItemHeight = 28;
            ComboBox.Items.AddRange(new object[] { "FirstUser", "SecondUser", "ThirdUser" });
            ComboBox.Location = new Point(227, 43);
            ComboBox.Name = "ComboBox";
            ComboBox.Size = new Size(150, 256);
            ComboBox.TabIndex = 4;
            // 
            // ListBox
            // 
            ListBox.FormattingEnabled = true;
            ListBox.Location = new Point(383, 43);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(207, 264);
            ListBox.TabIndex = 5;
            // 
            // Button
            // 
            Button.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Button.Location = new Point(12, 153);
            Button.Name = "Button";
            Button.Size = new Size(209, 79);
            Button.TabIndex = 6;
            Button.Text = "Сгенерировать\r\nпароль\r\n";
            Button.UseVisualStyleBackColor = true;
            Button.Click += Button_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(12, 238);
            button2.Name = "button2";
            button2.Size = new Size(209, 69);
            button2.TabIndex = 7;
            button2.Text = "Удалить запись";
            button2.UseVisualStyleBackColor = true;
            // 
            // TextBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 317);
            Controls.Add(button2);
            Controls.Add(Button);
            Controls.Add(ListBox);
            Controls.Add(ComboBox);
            Controls.Add(listBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "TextBox";
            Text = "Менеджер паролей";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private ListBox listBox1;
        private ListBox ComboBox;
        private ListBox ListBox;
        private Button Button;
        private Button button2;
    }
}
