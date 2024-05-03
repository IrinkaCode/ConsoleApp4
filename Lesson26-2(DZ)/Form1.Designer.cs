namespace Lesson26_2_DZ_
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
            firstOperandTB = new TextBox();
            secondOperandTB = new TextBox();
            resultTB = new TextBox();
            countButton = new Button();
            summCheckBox1 = new CheckBox();
            substractCheckBox = new CheckBox();
            MultCheckBox = new CheckBox();
            DivCheckBox = new CheckBox();
            ClearButton = new Button();
            SuspendLayout();
            // 
            // firstOperandTB
            // 
            firstOperandTB.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            firstOperandTB.Location = new Point(22, 48);
            firstOperandTB.Name = "firstOperandTB";
            firstOperandTB.Size = new Size(104, 51);
            firstOperandTB.TabIndex = 0;
            firstOperandTB.TextAlign = HorizontalAlignment.Center;
            // 
            // secondOperandTB
            // 
            secondOperandTB.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            secondOperandTB.Location = new Point(132, 48);
            secondOperandTB.Name = "secondOperandTB";
            secondOperandTB.Size = new Size(112, 51);
            secondOperandTB.TabIndex = 1;
            secondOperandTB.TextAlign = HorizontalAlignment.Center;
            // 
            // resultTB
            // 
            resultTB.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            resultTB.Location = new Point(12, 165);
            resultTB.Name = "resultTB";
            resultTB.Size = new Size(394, 51);
            resultTB.TabIndex = 2;
            resultTB.TextAlign = HorizontalAlignment.Center;
            // 
            // countButton
            // 
            countButton.Location = new Point(12, 242);
            countButton.Name = "countButton";
            countButton.Size = new Size(276, 162);
            countButton.TabIndex = 3;
            countButton.Text = "Посчитать";
            countButton.UseVisualStyleBackColor = true;
            countButton.Click += button1_Click;
            // 
            // summCheckBox1
            // 
            summCheckBox1.AutoSize = true;
            summCheckBox1.Location = new Point(292, 48);
            summCheckBox1.Name = "summCheckBox1";
            summCheckBox1.Size = new Size(102, 24);
            summCheckBox1.TabIndex = 4;
            summCheckBox1.Text = "Сложение";
            summCheckBox1.UseVisualStyleBackColor = true;
            // 
            // substractCheckBox
            // 
            substractCheckBox.AutoSize = true;
            substractCheckBox.Location = new Point(292, 75);
            substractCheckBox.Name = "substractCheckBox";
            substractCheckBox.Size = new Size(108, 24);
            substractCheckBox.TabIndex = 5;
            substractCheckBox.Text = "Вычитание";
            substractCheckBox.UseVisualStyleBackColor = true;
            // 
            // MultCheckBox
            // 
            MultCheckBox.AutoSize = true;
            MultCheckBox.Location = new Point(292, 105);
            MultCheckBox.Name = "MultCheckBox";
            MultCheckBox.Size = new Size(114, 24);
            MultCheckBox.TabIndex = 6;
            MultCheckBox.Text = "Умножение";
            MultCheckBox.UseVisualStyleBackColor = true;
            // 
            // DivCheckBox
            // 
            DivCheckBox.AutoSize = true;
            DivCheckBox.Location = new Point(293, 135);
            DivCheckBox.Name = "DivCheckBox";
            DivCheckBox.Size = new Size(91, 24);
            DivCheckBox.TabIndex = 7;
            DivCheckBox.Text = "Деление";
            DivCheckBox.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(312, 257);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 82);
            ClearButton.TabIndex = 8;
            ClearButton.Text = "Очистка";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(416, 416);
            Controls.Add(ClearButton);
            Controls.Add(DivCheckBox);
            Controls.Add(MultCheckBox);
            Controls.Add(substractCheckBox);
            Controls.Add(summCheckBox1);
            Controls.Add(countButton);
            Controls.Add(resultTB);
            Controls.Add(secondOperandTB);
            Controls.Add(firstOperandTB);
            Name = "Form1";
            ShowIcon = false;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstOperandTB;
        private TextBox secondOperandTB;
        private TextBox resultTB;
        private Button countButton;
        private CheckBox summCheckBox1;
        private CheckBox substractCheckBox;
        private CheckBox MultCheckBox;
        private CheckBox DivCheckBox;
        private Button ClearButton;
    }
}
