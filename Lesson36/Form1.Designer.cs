namespace Lesson36
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
            lbxTask = new ListBox();
            label2 = new Label();
            lbxTaskDate = new ListBox();
            label3 = new Label();
            lbxTaskPriority = new ListBox();
            label4 = new Label();
            lbxPriority = new ListBox();
            label5 = new Label();
            dtpTaskDate = new DateTimePicker();
            tbTask = new TextBox();
            label6 = new Label();
            btAdd = new Button();
            btDelete = new Button();
            btEdit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(3, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 37);
            label1.TabIndex = 0;
            label1.Text = "Задача";
            // 
            // lbxTask
            // 
            lbxTask.FormattingEnabled = true;
            lbxTask.ItemHeight = 31;
            lbxTask.Location = new Point(3, 59);
            lbxTask.Name = "lbxTask";
            lbxTask.Size = new Size(185, 283);
            lbxTask.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 9);
            label2.Name = "label2";
            label2.Size = new Size(154, 31);
            label2.TabIndex = 2;
            label2.Text = "Дата и время";
            // 
            // lbxTaskDate
            // 
            lbxTaskDate.FormattingEnabled = true;
            lbxTaskDate.ItemHeight = 31;
            lbxTaskDate.Location = new Point(194, 59);
            lbxTaskDate.Name = "lbxTaskDate";
            lbxTaskDate.Size = new Size(182, 283);
            lbxTaskDate.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(401, 9);
            label3.Name = "label3";
            label3.Size = new Size(127, 31);
            label3.TabIndex = 4;
            label3.Text = "Приоритет";
            // 
            // lbxTaskPriority
            // 
            lbxTaskPriority.FormattingEnabled = true;
            lbxTaskPriority.ItemHeight = 31;
            lbxTaskPriority.Location = new Point(382, 59);
            lbxTaskPriority.Name = "lbxTaskPriority";
            lbxTaskPriority.Size = new Size(176, 283);
            lbxTaskPriority.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(598, 9);
            label4.Name = "label4";
            label4.Size = new Size(217, 31);
            label4.TabIndex = 6;
            label4.Text = "Укажите приоритет";
            // 
            // lbxPriority
            // 
            lbxPriority.FormattingEnabled = true;
            lbxPriority.ItemHeight = 31;
            lbxPriority.Items.AddRange(new object[] { "Низкий", "Средний", "Высокий" });
            lbxPriority.Location = new Point(576, 59);
            lbxPriority.Name = "lbxPriority";
            lbxPriority.Size = new Size(239, 97);
            lbxPriority.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(576, 174);
            label5.Name = "label5";
            label5.Size = new Size(243, 31);
            label5.TabIndex = 8;
            label5.Text = "Укажите дату и время";
            // 
            // dtpTaskDate
            // 
            dtpTaskDate.Location = new Point(576, 218);
            dtpTaskDate.Name = "dtpTaskDate";
            dtpTaskDate.Size = new Size(250, 38);
            dtpTaskDate.TabIndex = 9;
            // 
            // tbTask
            // 
            tbTask.Location = new Point(8, 453);
            tbTask.Name = "tbTask";
            tbTask.Size = new Size(531, 38);
            tbTask.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 402);
            label6.Name = "label6";
            label6.Size = new Size(238, 31);
            label6.TabIndex = 11;
            label6.Text = "Укажите текст задачи";
            // 
            // btAdd
            // 
            btAdd.Location = new Point(576, 286);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(243, 66);
            btAdd.TabIndex = 12;
            btAdd.Text = "Добавить";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(576, 374);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(243, 68);
            btDelete.TabIndex = 13;
            btDelete.Text = "Удалить";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(576, 467);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(243, 60);
            btEdit.TabIndex = 14;
            btEdit.Text = "Переписать";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 549);
            Controls.Add(btEdit);
            Controls.Add(btDelete);
            Controls.Add(btAdd);
            Controls.Add(label6);
            Controls.Add(tbTask);
            Controls.Add(dtpTaskDate);
            Controls.Add(label5);
            Controls.Add(lbxPriority);
            Controls.Add(label4);
            Controls.Add(lbxTaskPriority);
            Controls.Add(label3);
            Controls.Add(lbxTaskDate);
            Controls.Add(label2);
            Controls.Add(lbxTask);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Планировщик задач";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lbxTask;
        private Label label2;
        private ListBox lbxTaskDate;
        private Label label3;
        private ListBox lbxTaskPriority;
        private Label label4;
        private ListBox lbxPriority;
        private Label label5;
        private DateTimePicker dtpTaskDate;
        private TextBox tbTask;
        private Label label6;
        private Button btAdd;
        private Button btDelete;
        private Button btEdit;
    }
}
