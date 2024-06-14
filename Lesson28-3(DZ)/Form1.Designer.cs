namespace Lesson28_3_DZ_
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
            TreeNode treeNode1 = new TreeNode("Триммеры");
            TreeNode treeNode2 = new TreeNode("Газонокосилки");
            TreeNode treeNode3 = new TreeNode("Аэраторы");
            TreeNode treeNode4 = new TreeNode("Техника для сада", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("Котлы");
            TreeNode treeNode6 = new TreeNode("Насосы");
            TreeNode treeNode7 = new TreeNode("Фильтры");
            TreeNode treeNode8 = new TreeNode("Водоснабжение,фильтрация и отопление", new TreeNode[] { treeNode5, treeNode6, treeNode7 });
            TreeNode treeNode9 = new TreeNode("Сучкорезы");
            TreeNode treeNode10 = new TreeNode("Секаторы");
            TreeNode treeNode11 = new TreeNode("Бензоинструмент");
            TreeNode treeNode12 = new TreeNode("Инструмент", new TreeNode[] { treeNode9, treeNode10, treeNode11 });
            TreeNode treeNode13 = new TreeNode("Подставки");
            TreeNode treeNode14 = new TreeNode("Дачный гарнитур");
            TreeNode treeNode15 = new TreeNode("Мебель", new TreeNode[] { treeNode13, treeNode14 });
            TreeNode treeNode16 = new TreeNode("Садовый инструмент и инвентарь", new TreeNode[] { treeNode12, treeNode15 });
            TreeNode treeNode17 = new TreeNode("Садовая техника", new TreeNode[] { treeNode4, treeNode8, treeNode16 });
            treeView1 = new TreeView();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(-2, -2);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Узел4";
            treeNode1.Text = "Триммеры";
            treeNode2.Name = "Узел5";
            treeNode2.Text = "Газонокосилки";
            treeNode3.Name = "Узел1";
            treeNode3.Text = "Аэраторы";
            treeNode4.Name = "Триммеры";
            treeNode4.Text = "Техника для сада";
            treeNode5.Name = "Узел6";
            treeNode5.Text = "Котлы";
            treeNode6.Name = "Узел7";
            treeNode6.Text = "Насосы";
            treeNode7.Name = "Узел8";
            treeNode7.Text = "Фильтры";
            treeNode8.Name = "Узел2";
            treeNode8.Text = "Водоснабжение,фильтрация и отопление";
            treeNode9.Name = "Узел11";
            treeNode9.Text = "Сучкорезы";
            treeNode10.Name = "Узел12";
            treeNode10.Text = "Секаторы";
            treeNode11.Name = "Узел13";
            treeNode11.Text = "Бензоинструмент";
            treeNode12.Name = "Узел9";
            treeNode12.Text = "Инструмент";
            treeNode13.Name = "Узел14";
            treeNode13.Text = "Подставки";
            treeNode14.Name = "Узел15";
            treeNode14.Text = "Дачный гарнитур";
            treeNode15.Name = "Узел10";
            treeNode15.Text = "Мебель";
            treeNode16.Name = "Узел3";
            treeNode16.Text = "Садовый инструмент и инвентарь";
            treeNode17.Name = "Узел0";
            treeNode17.Text = "Садовая техника";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode17 });
            treeView1.Size = new Size(444, 627);
            treeView1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 446);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
    }
}
