namespace Lesson31_Windows_Forms_
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
            tbFirst = new TextBox();
            label2 = new Label();
            tbSecond = new TextBox();
            btAdd = new Button();
            btSub = new Button();
            btMult = new Button();
            btDif = new Button();
            lbResult = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 150);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(305, 38);
            label1.TabIndex = 0;
            label1.Text = "Введите первое число";
            // 
            // tbFirst
            // 
            tbFirst.Location = new Point(194, 194);
            tbFirst.Margin = new Padding(6);
            tbFirst.Name = "tbFirst";
            tbFirst.Size = new Size(439, 43);
            tbFirst.TabIndex = 1;
            tbFirst.Text = "8";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 265);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(301, 38);
            label2.TabIndex = 2;
            label2.Text = "Введите второе число";
            // 
            // tbSecond
            // 
            tbSecond.Location = new Point(204, 324);
            tbSecond.Margin = new Padding(6);
            tbSecond.Name = "tbSecond";
            tbSecond.Size = new Size(439, 43);
            tbSecond.TabIndex = 3;
            tbSecond.Text = "7";
            // 
            // btAdd
            // 
            btAdd.Location = new Point(56, 429);
            btAdd.Margin = new Padding(6);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(176, 54);
            btAdd.TabIndex = 4;
            btAdd.Text = "+";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btSub
            // 
            btSub.Location = new Point(296, 429);
            btSub.Margin = new Padding(6);
            btSub.Name = "btSub";
            btSub.Size = new Size(176, 54);
            btSub.TabIndex = 5;
            btSub.Text = "-";
            btSub.UseVisualStyleBackColor = true;
            btSub.Click += btSub_Click;
            // 
            // btMult
            // 
            btMult.Location = new Point(549, 429);
            btMult.Margin = new Padding(6);
            btMult.Name = "btMult";
            btMult.Size = new Size(176, 54);
            btMult.TabIndex = 6;
            btMult.Text = "*";
            btMult.UseVisualStyleBackColor = true;
            btMult.Click += btMult_Click;
            // 
            // btDif
            // 
            btDif.Location = new Point(791, 429);
            btDif.Margin = new Padding(6);
            btDif.Name = "btDif";
            btDif.Size = new Size(176, 54);
            btDif.TabIndex = 7;
            btDif.Text = "/";
            btDif.UseVisualStyleBackColor = true;
            btDif.Click += btDif_Click;
            // 
            // lbResult
            // 
            lbResult.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbResult.Location = new Point(73, 549);
            lbResult.Margin = new Padding(6, 0, 6, 0);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(894, 179);
            lbResult.TabIndex = 8;
            lbResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(893, 718);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(141, 38);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 1055);
            Controls.Add(linkLabel1);
            Controls.Add(lbResult);
            Controls.Add(btDif);
            Controls.Add(btMult);
            Controls.Add(btSub);
            Controls.Add(btAdd);
            Controls.Add(tbSecond);
            Controls.Add(label2);
            Controls.Add(tbFirst);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Моя первая программа";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbFirst;
        private Label label2;
        private TextBox tbSecond;
        private Button btAdd;
        private Button btSub;
        private Button btMult;
        private Button btDif;
        private Label lbResult;
        private LinkLabel linkLabel1;
    }
}
