namespace Lesson32_1
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
            lbMark = new Label();
            tbMark = new TextBox();
            chbMark = new CheckBox();
            btMark = new Button();
            lbResult = new Label();
            SuspendLayout();
            // 
            // lbMark
            // 
            lbMark.AutoSize = true;
            lbMark.Location = new Point(44, 36);
            lbMark.Name = "lbMark";
            lbMark.Size = new Size(48, 20);
            lbMark.TabIndex = 0;
            lbMark.Text = "Мили";
            // 
            // tbMark
            // 
            tbMark.Location = new Point(206, 36);
            tbMark.Name = "tbMark";
            tbMark.Size = new Size(182, 27);
            tbMark.TabIndex = 1;
            tbMark.TextChanged += tbMark_TextChanged;
            tbMark.KeyPress += tbMark_KeyPress;
            // 
            // chbMark
            // 
            chbMark.AutoSize = true;
            chbMark.Location = new Point(103, 86);
            chbMark.Name = "chbMark";
            chbMark.Size = new Size(162, 24);
            chbMark.TabIndex = 2;
            chbMark.Text = "мили->километры";
            chbMark.UseVisualStyleBackColor = true;
            chbMark.CheckedChanged += chbMark_CheckedChanged;
            // 
            // btMark
            // 
            btMark.Location = new Point(103, 116);
            btMark.Name = "btMark";
            btMark.Size = new Size(228, 86);
            btMark.TabIndex = 3;
            btMark.Text = "Перевести";
            btMark.UseVisualStyleBackColor = true;
            btMark.Click += btMark_Click;
            // 
            // lbResult
            // 
            lbResult.Dock = DockStyle.Bottom;
            lbResult.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbResult.Location = new Point(0, 229);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(432, 100);
            lbResult.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 329);
            Controls.Add(lbResult);
            Controls.Add(btMark);
            Controls.Add(chbMark);
            Controls.Add(tbMark);
            Controls.Add(lbMark);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Мили-Километры";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMark;
        private TextBox tbMark;
        private CheckBox chbMark;
        private Button btMark;
        private Label lbResult;
    }
}
