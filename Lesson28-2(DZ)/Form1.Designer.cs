namespace Lesson28_2_DZ_
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            tbusserlog = new TextBox();
            lblog = new ListBox();
            lbpass = new ListBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 35);
            textBox1.TabIndex = 0;
            textBox1.Text = "Имя пользователя:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(218, 13);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 34);
            textBox2.TabIndex = 1;
            textBox2.Text = "Логин:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(394, 12);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(206, 34);
            textBox3.TabIndex = 2;
            textBox3.Text = "Пароль:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(12, 218);
            button1.Name = "button1";
            button1.Size = new Size(198, 97);
            button1.TabIndex = 3;
            button1.Text = "Сгенерировать пароль";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(12, 321);
            button2.Name = "button2";
            button2.Size = new Size(200, 111);
            button2.TabIndex = 4;
            button2.Text = "Удалить запись";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tbusserlog
            // 
            tbusserlog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tbusserlog.Location = new Point(12, 68);
            tbusserlog.Multiline = true;
            tbusserlog.Name = "tbusserlog";
            tbusserlog.Size = new Size(200, 130);
            tbusserlog.TabIndex = 5;
            // 
            // lblog
            // 
            lblog.FormattingEnabled = true;
            lblog.Location = new Point(218, 68);
            lblog.Name = "lblog";
            lblog.Size = new Size(168, 364);
            lblog.TabIndex = 6;
            // 
            // lbpass
            // 
            lbpass.FormattingEnabled = true;
            lbpass.Location = new Point(394, 68);
            lbpass.Name = "lbpass";
            lbpass.Size = new Size(206, 364);
            lbpass.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 450);
            Controls.Add(lbpass);
            Controls.Add(lblog);
            Controls.Add(tbusserlog);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private TextBox tbusserlog;
        private ListBox lblog;
        private ListBox lbpass;
    }
}
