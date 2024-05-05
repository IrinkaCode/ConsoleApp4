namespace Lesson35_3
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
            label1 = new Label();
            tbResult = new TextBox();
            tb1 = new Label();
            tb2 = new Label();
            tbFrom = new TextBox();
            tbUntil = new TextBox();
            btGenerate = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            tbxNumber = new TextBox();
            label2 = new Label();
            cbxLong = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cbxTemp = new ComboBox();
            label5 = new Label();
            cbxPresure = new ComboBox();
            lbResult = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 44);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 0;
            label1.Text = "Случайное число";
            // 
            // tbResult
            // 
            tbResult.Location = new Point(7, 76);
            tbResult.Margin = new Padding(4);
            tbResult.Name = "tbResult";
            tbResult.ReadOnly = true;
            tbResult.Size = new Size(468, 34);
            tbResult.TabIndex = 1;
            tbResult.TextAlign = HorizontalAlignment.Center;
            // 
            // tb1
            // 
            tb1.AutoSize = true;
            tb1.Location = new Point(6, 143);
            tb1.Margin = new Padding(4, 0, 4, 0);
            tb1.Name = "tb1";
            tb1.Size = new Size(35, 28);
            tb1.TabIndex = 2;
            tb1.Text = "От";
            // 
            // tb2
            // 
            tb2.AutoSize = true;
            tb2.Location = new Point(304, 143);
            tb2.Margin = new Padding(4, 0, 4, 0);
            tb2.Name = "tb2";
            tb2.Size = new Size(38, 28);
            tb2.TabIndex = 3;
            tb2.Text = "До";
            // 
            // tbFrom
            // 
            tbFrom.Location = new Point(6, 196);
            tbFrom.Margin = new Padding(4);
            tbFrom.Name = "tbFrom";
            tbFrom.Size = new Size(170, 34);
            tbFrom.TabIndex = 4;
            tbFrom.TextAlign = HorizontalAlignment.Center;
            // 
            // tbUntil
            // 
            tbUntil.Location = new Point(304, 196);
            tbUntil.Margin = new Padding(4);
            tbUntil.Name = "tbUntil";
            tbUntil.Size = new Size(170, 34);
            tbUntil.TabIndex = 5;
            tbUntil.TextAlign = HorizontalAlignment.Center;
            // 
            // btGenerate
            // 
            btGenerate.Location = new Point(6, 265);
            btGenerate.Name = "btGenerate";
            btGenerate.Size = new Size(468, 188);
            btGenerate.TabIndex = 6;
            btGenerate.Text = "Сгенерировать";
            btGenerate.UseVisualStyleBackColor = true;
            btGenerate.Click += btGenerate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btGenerate);
            groupBox1.Controls.Add(tbUntil);
            groupBox1.Controls.Add(tbResult);
            groupBox1.Controls.Add(tbFrom);
            groupBox1.Controls.Add(tb1);
            groupBox1.Controls.Add(tb2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(502, 459);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Задача 1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbResult);
            groupBox2.Controls.Add(cbxPresure);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cbxTemp);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cbxLong);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(tbxNumber);
            groupBox2.Location = new Point(545, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(516, 445);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Задача 2";
            // 
            // tbxNumber
            // 
            tbxNumber.Location = new Point(6, 68);
            tbxNumber.Name = "tbxNumber";
            tbxNumber.Size = new Size(504, 34);
            tbxNumber.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 36);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 1;
            label2.Text = "Введите число";
            // 
            // cbxLong
            // 
            cbxLong.FormattingEnabled = true;
            cbxLong.Items.AddRange(new object[] { "Сантиметры", "Дециметры", "Метры", "Километры" });
            cbxLong.Location = new Point(6, 138);
            cbxLong.Name = "cbxLong";
            cbxLong.Size = new Size(151, 36);
            cbxLong.TabIndex = 2;
            cbxLong.SelectedIndexChanged += cbxLong_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 107);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 3;
            label3.Text = "Из мм в";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 105);
            label4.Name = "label4";
            label4.Size = new Size(157, 28);
            label4.TabIndex = 4;
            label4.Text = "Из градусов С в";
            // 
            // cbxTemp
            // 
            cbxTemp.FormattingEnabled = true;
            cbxTemp.Items.AddRange(new object[] { "Кельвины", "Фаренгейты" });
            cbxTemp.Location = new Point(179, 138);
            cbxTemp.Name = "cbxTemp";
            cbxTemp.Size = new Size(151, 36);
            cbxTemp.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(350, 105);
            label5.Name = "label5";
            label5.Size = new Size(143, 28);
            label5.TabIndex = 6;
            label5.Text = "Из Паскалей в";
            // 
            // cbxPresure
            // 
            cbxPresure.FormattingEnabled = true;
            cbxPresure.Items.AddRange(new object[] { "мм рт. ст.", "бары", "атмосферы", "кгс" });
            cbxPresure.Location = new Point(350, 138);
            cbxPresure.Name = "cbxPresure";
            cbxPresure.Size = new Size(151, 36);
            cbxPresure.TabIndex = 7;
            // 
            // lbResult
            // 
            lbResult.Location = new Point(6, 210);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(504, 232);
            lbResult.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 503);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Случайное число";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox tbResult;
        private Label tb1;
        private Label tb2;
        private TextBox tbFrom;
        private TextBox tbUntil;
        private Button btGenerate;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private ComboBox cbxLong;
        private Label label2;
        private TextBox tbxNumber;
        private Label lbResult;
        private ComboBox cbxPresure;
        private Label label5;
        private ComboBox cbxTemp;
        private Label label4;
    }
}
