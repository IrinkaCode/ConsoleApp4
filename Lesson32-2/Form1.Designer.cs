namespace Lesson32_2
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
            groupBox1 = new GroupBox();
            tb9x13 = new TextBox();
            tb10x15 = new TextBox();
            tb15x20 = new TextBox();
            rb9x13 = new RadioButton();
            rb10x15 = new RadioButton();
            rb15x20 = new RadioButton();
            tbCount = new TextBox();
            label1 = new Label();
            btOk = new Button();
            lbResult = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb9x13);
            groupBox1.Controls.Add(tb10x15);
            groupBox1.Controls.Add(tb15x20);
            groupBox1.Controls.Add(rb9x13);
            groupBox1.Controls.Add(rb10x15);
            groupBox1.Controls.Add(rb15x20);
            groupBox1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(306, 195);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Размеры и цены";
            // 
            // tb9x13
            // 
            tb9x13.Enabled = false;
            tb9x13.Location = new Point(104, 154);
            tb9x13.Name = "tb9x13";
            tb9x13.Size = new Size(182, 35);
            tb9x13.TabIndex = 5;
            tb9x13.KeyPress += tb9x13_KeyPress;
            // 
            // tb10x15
            // 
            tb10x15.Enabled = false;
            tb10x15.Location = new Point(104, 95);
            tb10x15.Name = "tb10x15";
            tb10x15.Size = new Size(182, 35);
            tb10x15.TabIndex = 4;
            tb10x15.KeyPress += textBox2_KeyPress;
            // 
            // tb15x20
            // 
            tb15x20.Enabled = false;
            tb15x20.Location = new Point(104, 44);
            tb15x20.Name = "tb15x20";
            tb15x20.Size = new Size(182, 35);
            tb15x20.TabIndex = 3;
            tb15x20.KeyPress += tb15x20_KeyPress;
            // 
            // rb9x13
            // 
            rb9x13.AutoSize = true;
            rb9x13.Location = new Point(0, 157);
            rb9x13.Name = "rb9x13";
            rb9x13.Size = new Size(85, 32);
            rb9x13.TabIndex = 2;
            rb9x13.TabStop = true;
            rb9x13.Text = "9X13";
            rb9x13.UseVisualStyleBackColor = true;
            rb9x13.CheckedChanged += rb9x13_CheckedChanged;
            // 
            // rb10x15
            // 
            rb10x15.AutoSize = true;
            rb10x15.Location = new Point(0, 98);
            rb10x15.Name = "rb10x15";
            rb10x15.Size = new Size(98, 32);
            rb10x15.TabIndex = 1;
            rb10x15.TabStop = true;
            rb10x15.Text = "10X15";
            rb10x15.UseVisualStyleBackColor = true;
            rb10x15.CheckedChanged += rb10x15_CheckedChanged;
            // 
            // rb15x20
            // 
            rb15x20.AutoSize = true;
            rb15x20.Location = new Point(0, 44);
            rb15x20.Name = "rb15x20";
            rb15x20.Size = new Size(98, 32);
            rb15x20.TabIndex = 0;
            rb15x20.TabStop = true;
            rb15x20.Text = "15X20";
            rb15x20.UseVisualStyleBackColor = true;
            rb15x20.CheckedChanged += rb15x20_CheckedChanged;
            // 
            // tbCount
            // 
            tbCount.Location = new Point(134, 244);
            tbCount.Name = "tbCount";
            tbCount.Size = new Size(182, 27);
            tbCount.TabIndex = 1;
            tbCount.KeyPress += tbCount_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 247);
            label1.Name = "label1";
            label1.Size = new Size(116, 24);
            label1.TabIndex = 2;
            label1.Text = "Количество";
            // 
            // btOk
            // 
            btOk.Location = new Point(116, 310);
            btOk.Name = "btOk";
            btOk.Size = new Size(182, 29);
            btOk.TabIndex = 3;
            btOk.Text = "Расчитать";
            btOk.UseVisualStyleBackColor = true;
            btOk.Click += btOk_Click;
            // 
            // lbResult
            // 
            lbResult.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbResult.Location = new Point(24, 359);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(312, 114);
            lbResult.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 509);
            Controls.Add(lbResult);
            Controls.Add(btOk);
            Controls.Add(label1);
            Controls.Add(tbCount);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Фотоателье";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rb9x13;
        private RadioButton rb10x15;
        private RadioButton rb15x20;
        private TextBox tb9x13;
        private TextBox tb10x15;
        private TextBox tb15x20;
        private TextBox tbCount;
        private Label label1;
        private Button btOk;
        private Label lbResult;
    }
}
