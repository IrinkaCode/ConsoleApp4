namespace Lesson25_2_DZ_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            bt2 = new Button();
            linkLabel1 = new LinkLabel();
            lb1 = new Label();
            lb2 = new Label();
            pbox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbox1).BeginInit();
            SuspendLayout();
            // 
            // bt2
            // 
            bt2.BackColor = Color.Black;
            bt2.FlatStyle = FlatStyle.Popup;
            bt2.ForeColor = Color.White;
            bt2.Location = new Point(57, 570);
            bt2.Name = "bt2";
            bt2.Size = new Size(353, 66);
            bt2.TabIndex = 1;
            bt2.Text = "login          ->";
            bt2.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Navy;
            linkLabel1.Location = new Point(310, 697);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(68, 23);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up";
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.ForeColor = Color.Black;
            lb1.Location = new Point(93, 697);
            lb1.Name = "lb1";
            lb1.Size = new Size(191, 23);
            lb1.TabIndex = 4;
            lb1.Text = "Don't have an account?";
            // 
            // lb2
            // 
            lb2.BackColor = Color.Plum;
            lb2.ForeColor = Color.Black;
            lb2.Location = new Point(57, 459);
            lb2.Name = "lb2";
            lb2.Size = new Size(353, 96);
            lb2.TabIndex = 5;
            lb2.Text = "Fell less stressed and more minful with \r\nmeditation\r\n";
            lb2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbox1
            // 
            pbox1.BackgroundImageLayout = ImageLayout.None;
            pbox1.BorderStyle = BorderStyle.FixedSingle;
            pbox1.Cursor = Cursors.No;
            pbox1.Dock = DockStyle.Top;
            pbox1.Image = (Image)resources.GetObject("pbox1.Image");
            pbox1.Location = new Point(0, 0);
            pbox1.Name = "pbox1";
            pbox1.Size = new Size(458, 378);
            pbox1.SizeMode = PictureBoxSizeMode.Zoom;
            pbox1.TabIndex = 6;
            pbox1.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Plum;
            label3.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(112, 409);
            label3.Name = "label3";
            label3.Size = new Size(240, 50);
            label3.TabIndex = 7;
            label3.Text = "Welcome";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Plum;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(458, 784);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(pbox1);
            Controls.Add(lb2);
            Controls.Add(lb1);
            Controls.Add(linkLabel1);
            Controls.Add(bt2);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            TransparencyKey = Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)pbox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bt2;
        private LinkLabel linkLabel1;
        private Label lb1;
        private Label lb2;
        private PictureBox pbox1;
        private Label label3;
    }
}
