namespace Lesson33_1
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
            label2 = new Label();
            lbxMaterial = new ListBox();
            pbxMaterial = new PictureBox();
            lbResult = new Label();
            tbxWidth = new TextBox();
            tbxHeight = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbxMaterial).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 34);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Ширина";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 87);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Высота";
            // 
            // lbxMaterial
            // 
            lbxMaterial.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbxMaterial.FormattingEnabled = true;
            lbxMaterial.ItemHeight = 28;
            lbxMaterial.Items.AddRange(new object[] { "Алюминий", "Пластик", "Дерево", "Бамбук" });
            lbxMaterial.Location = new Point(40, 137);
            lbxMaterial.Name = "lbxMaterial";
            lbxMaterial.Size = new Size(226, 172);
            lbxMaterial.TabIndex = 2;
            lbxMaterial.SelectedIndexChanged += lbxMaterial_SelectedIndexChanged;
            // 
            // pbxMaterial
            // 
            pbxMaterial.Location = new Point(306, 34);
            pbxMaterial.Name = "pbxMaterial";
            pbxMaterial.Size = new Size(288, 387);
            pbxMaterial.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxMaterial.TabIndex = 5;
            pbxMaterial.TabStop = false;
            // 
            // lbResult
            // 
            lbResult.Location = new Point(306, 456);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(288, 102);
            lbResult.TabIndex = 6;
            // 
            // tbxWidth
            // 
            tbxWidth.Location = new Point(141, 35);
            tbxWidth.Name = "tbxWidth";
            tbxWidth.Size = new Size(125, 27);
            tbxWidth.TabIndex = 7;
            // 
            // tbxHeight
            // 
            tbxHeight.Location = new Point(141, 87);
            tbxHeight.Name = "tbxHeight";
            tbxHeight.Size = new Size(125, 27);
            tbxHeight.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(615, 684);
            Controls.Add(tbxHeight);
            Controls.Add(tbxWidth);
            Controls.Add(lbResult);
            Controls.Add(pbxMaterial);
            Controls.Add(lbxMaterial);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Жалюзи";
            ((System.ComponentModel.ISupportInitialize)pbxMaterial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lbxMaterial;
        private PictureBox pbxMaterial;
        private Label lbResult;
        private TextBox tbxWidth;
        private TextBox tbxHeight;
    }
}
