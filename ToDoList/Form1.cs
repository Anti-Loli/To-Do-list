using ToDoList;

namespace TimCoreyWinFormDemo
{
    public partial class Form1 : Form
    {
        ToDoTask1 task1 = new ToDoTask1();
        List<ToDoTask1> tasks;

        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            task1.setTaskName(textBox1.Text);
            task1.setTaskDate(monthCalendar1.SelectionRange.Start.ToString("MM/dd/yyyy"));

            checkedListBox1.Items.Add(task1.ToString());

            tasks.Add(task1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int selectedTask = checkedListBox1.SelectedIndex;

            if (selectedTask != -1)
            {
                checkedListBox1.Items.RemoveAt(selectedTask);
            }
            else
            {
                MessageBox.Show("Please select a task to remove.");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddTaskButton.PerformClick();
                e.Handled = true;
            }

        }

        private void checkedListBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                RemoveTaskButton.PerformClick();
                e.Handled = true;
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void monthCalendar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddTaskButton.PerformClick();
                e.Handled = true;
            }
        }

        private void SaveTaskButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
