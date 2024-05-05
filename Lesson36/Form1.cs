namespace Lesson36
{
    public partial class Form1 : Form
    {
        private List<MyTask> myTasks;
        public Form1()
        {
            InitializeComponent();
            myTasks = new List<MyTask>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = lbxTask.SelectedIndex;
            MyTask currentTask= myTasks[index];
            tbTask.Text=currentTask.getTaskName();
            lbxPriority.Text=currentTask.getPriority();
            dtpTaskDate.Value = currentTask.getTaskDataTime();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddTask(tbTask.Text, dtpTaskDate.Value, lbxPriority.SelectedItem.ToString()!);
        }
        private void ClearForm()
        {
            tbTask.Text = "";
            dtpTaskDate.Value = DateTime.Now;
            lbxPriority.SelectedIndex = -1;
        }
        private void AddTask(string task, DateTime dt, string p)
        {
            MyTask myTask = new MyTask(task, dt, p);
            myTasks.Add(myTask);
            lbxTask.Items.Add(tbTask.Text);
            lbxTaskDate.Items.Add(dtpTaskDate.Value);
            lbxTaskPriority.Items.Add(lbxPriority.SelectedItem.ToString()!);
            ClearForm();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int index = lbxTask.SelectedIndex;
            myTasks.RemoveAt(index);
            lbxTask.Items.RemoveAt(index);
            lbxTaskDate.Items.RemoveAt(index);
            lbxTaskPriority.Items.RemoveAt(index);
        }
    }
}
