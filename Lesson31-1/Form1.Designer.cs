namespace Lesson31_1
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
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(482, 51);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.MenuText;
            comboBox1.ForeColor = SystemColors.InactiveBorder;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Обычный", "Программист", "Инженер" });
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(169, 12);
            button1.Name = "button1";
            button1.Size = new Size(25, 25);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.Location = new Point(457, 0);
            button2.Name = "button2";
            button2.Size = new Size(25, 51);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InfoText;
            textBox1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(-3, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(482, 87);
            textBox1.TabIndex = 1;
            textBox1.Text = "0\r\n\r\n";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Location = new Point(-3, 133);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(482, 62);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 46);
            label1.TabIndex = 0;
            label1.Text = "MC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(81, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 46);
            label2.TabIndex = 1;
            label2.Text = "MR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(158, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 46);
            label3.TabIndex = 2;
            label3.Text = "M+";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(238, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 46);
            label4.TabIndex = 3;
            label4.Text = "M-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.White;
            label5.Location = new Point(309, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 46);
            label5.TabIndex = 4;
            label5.Text = "MS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.White;
            label6.Location = new Point(384, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 46);
            label6.TabIndex = 5;
            label6.Text = "M";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(button3);
            flowLayoutPanel2.Controls.Add(button4);
            flowLayoutPanel2.Controls.Add(button5);
            flowLayoutPanel2.Controls.Add(button6);
            flowLayoutPanel2.Controls.Add(button7);
            flowLayoutPanel2.Controls.Add(button8);
            flowLayoutPanel2.Controls.Add(button9);
            flowLayoutPanel2.Controls.Add(button10);
            flowLayoutPanel2.Controls.Add(button11);
            flowLayoutPanel2.Controls.Add(button12);
            flowLayoutPanel2.Controls.Add(button13);
            flowLayoutPanel2.Controls.Add(button14);
            flowLayoutPanel2.Controls.Add(button15);
            flowLayoutPanel2.Controls.Add(button16);
            flowLayoutPanel2.Controls.Add(button17);
            flowLayoutPanel2.Controls.Add(button18);
            flowLayoutPanel2.Controls.Add(button19);
            flowLayoutPanel2.Controls.Add(button20);
            flowLayoutPanel2.Controls.Add(button21);
            flowLayoutPanel2.Controls.Add(button22);
            flowLayoutPanel2.Location = new Point(0, 201);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(479, 529);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(10, 10);
            button3.Margin = new Padding(10);
            button3.Name = "button3";
            button3.Size = new Size(100, 100);
            button3.TabIndex = 0;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(130, 10);
            button4.Margin = new Padding(10);
            button4.Name = "button4";
            button4.Size = new Size(100, 100);
            button4.TabIndex = 1;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(250, 10);
            button5.Margin = new Padding(10);
            button5.Name = "button5";
            button5.Size = new Size(100, 100);
            button5.TabIndex = 2;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(367, 7);
            button6.Margin = new Padding(7);
            button6.Name = "button6";
            button6.Size = new Size(100, 100);
            button6.TabIndex = 3;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(3, 123);
            button7.Name = "button7";
            button7.Size = new Size(100, 100);
            button7.TabIndex = 4;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(109, 123);
            button8.Name = "button8";
            button8.Size = new Size(100, 100);
            button8.TabIndex = 5;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(215, 123);
            button9.Name = "button9";
            button9.Size = new Size(100, 100);
            button9.TabIndex = 6;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(321, 123);
            button10.Name = "button10";
            button10.Size = new Size(100, 100);
            button10.TabIndex = 7;
            button10.Text = "button10";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(3, 229);
            button11.Name = "button11";
            button11.Size = new Size(100, 100);
            button11.TabIndex = 8;
            button11.Text = "button11";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(109, 229);
            button12.Name = "button12";
            button12.Size = new Size(100, 100);
            button12.TabIndex = 9;
            button12.Text = "button12";
            button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            button13.Location = new Point(215, 229);
            button13.Name = "button13";
            button13.Size = new Size(100, 100);
            button13.TabIndex = 10;
            button13.Text = "button13";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(321, 229);
            button14.Name = "button14";
            button14.Size = new Size(100, 100);
            button14.TabIndex = 11;
            button14.Text = "button14";
            button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            button15.Location = new Point(3, 335);
            button15.Name = "button15";
            button15.Size = new Size(100, 100);
            button15.TabIndex = 12;
            button15.Text = "button15";
            button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            button16.Location = new Point(109, 335);
            button16.Name = "button16";
            button16.Size = new Size(100, 100);
            button16.TabIndex = 13;
            button16.Text = "button16";
            button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            button17.Location = new Point(215, 335);
            button17.Name = "button17";
            button17.Size = new Size(100, 100);
            button17.TabIndex = 14;
            button17.Text = "button17";
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Location = new Point(321, 335);
            button18.Name = "button18";
            button18.Size = new Size(100, 100);
            button18.TabIndex = 15;
            button18.Text = "button18";
            button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            button19.Location = new Point(3, 441);
            button19.Name = "button19";
            button19.Size = new Size(100, 100);
            button19.TabIndex = 16;
            button19.Text = "button19";
            button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            button20.Location = new Point(109, 441);
            button20.Name = "button20";
            button20.Size = new Size(100, 100);
            button20.TabIndex = 17;
            button20.Text = "button20";
            button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            button21.Location = new Point(215, 441);
            button21.Name = "button21";
            button21.Size = new Size(100, 100);
            button21.TabIndex = 18;
            button21.Text = "button21";
            button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            button22.Location = new Point(321, 441);
            button22.Name = "button22";
            button22.Size = new Size(100, 100);
            button22.TabIndex = 19;
            button22.Text = "button22";
            button22.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(482, 726);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Калькулятор";
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
    }
}
