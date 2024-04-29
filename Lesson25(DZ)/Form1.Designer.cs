namespace Lesson25_DZ_
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
            bt1 = new Button();
            bt2 = new Button();
            gb1 = new GroupBox();
            rb2 = new RadioButton();
            rb3 = new RadioButton();
            rb4 = new RadioButton();
            rb5 = new RadioButton();
            rb1 = new RadioButton();
            gb1.SuspendLayout();
            SuspendLayout();
            // 
            // bt1
            // 
            bt1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bt1.Location = new Point(34, 510);
            bt1.Margin = new Padding(4, 3, 4, 3);
            bt1.Name = "bt1";
            bt1.Size = new Size(270, 42);
            bt1.TabIndex = 0;
            bt1.Text = "Удалить задачу";
            bt1.UseVisualStyleBackColor = true;
            // 
            // bt2
            // 
            bt2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            bt2.Location = new Point(34, 445);
            bt2.Margin = new Padding(4, 3, 4, 3);
            bt2.Name = "bt2";
            bt2.Size = new Size(270, 42);
            bt2.TabIndex = 1;
            bt2.Text = "Добавить задачу";
            bt2.UseVisualStyleBackColor = true;
            // 
            // gb1
            // 
            gb1.BackColor = Color.Cyan;
            gb1.Controls.Add(rb1);
            gb1.Controls.Add(rb5);
            gb1.Controls.Add(rb4);
            gb1.Controls.Add(rb3);
            gb1.Controls.Add(rb2);
            gb1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            gb1.Location = new Point(34, 12);
            gb1.Name = "gb1";
            gb1.Size = new Size(270, 427);
            gb1.TabIndex = 2;
            gb1.TabStop = false;
            gb1.Text = "Задачи";
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rb2.Location = new Point(0, 94);
            rb2.Name = "rb2";
            rb2.Size = new Size(173, 26);
            rb2.TabIndex = 1;
            rb2.TabStop = true;
            rb2.Text = "Поменять резину";
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rb3.Location = new Point(1, 140);
            rb3.Name = "rb3";
            rb3.Size = new Size(204, 26);
            rb3.TabIndex = 2;
            rb3.TabStop = true;
            rb3.Text = "Купить новый айфон";
            rb3.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            rb4.AutoSize = true;
            rb4.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rb4.Location = new Point(1, 187);
            rb4.Name = "rb4";
            rb4.Size = new Size(126, 26);
            rb4.TabIndex = 3;
            rb4.TabStop = true;
            rb4.Text = "Купить дом";
            rb4.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            rb5.AutoSize = true;
            rb5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rb5.Location = new Point(0, 236);
            rb5.Name = "rb5";
            rb5.Size = new Size(266, 26);
            rb5.TabIndex = 4;
            rb5.TabStop = true;
            rb5.Text = "Купить BMW M8 Competition";
            rb5.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rb1.Location = new Point(1, 43);
            rb1.Name = "rb1";
            rb1.Size = new Size(242, 26);
            rb1.TabIndex = 5;
            rb1.TabStop = true;
            rb1.Text = "Купить туалетную бумагу";
            rb1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(357, 580);
            Controls.Add(gb1);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Планировщик задач";
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button bt1;
        private Button bt2;
        private GroupBox gb1;
        private RadioButton rb5;
        private RadioButton rb4;
        private RadioButton rb3;
        private RadioButton rb2;
        private RadioButton rb1;
    }
}
