using ToDoList;
using Newtonsoft.Json;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

namespace TimCoreyWinFormDemo
{
    public partial class Form1 : Form
    {
        ToDoTask1 task1 = new ToDoTask1();
        List<ToDoTask1> tasks = new List<ToDoTask1>();
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\tasklist.json";

        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var newTask = new ToDoTask1();
            newTask.setTaskName(textBox1.Text);
            newTask.setTaskDate(monthCalendar1.SelectionRange.Start.ToString("MM/dd/yyyy"));

            tasks.Add(newTask);
            checkedListBox1.Items.Add(newTask.ToString());

            string json = JsonConvert.SerializeObject(tasks, Formatting.Indented);

            textBox1.Text = "";

            File.WriteAllText(filePath, json);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int selectedTask = checkedListBox1.SelectedIndex;

            if (selectedTask != -1)
            {
                checkedListBox1.Items.RemoveAt(selectedTask);

                string jsonUpdate = File.ReadAllText(filePath);

                JArray jsonArray = JArray.Parse(jsonUpdate);

                jsonArray.RemoveAt(selectedTask);

                File.WriteAllText(filePath, jsonArray.ToString());
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

        private void Form1_Load(object sender, EventArgs e)
        {
            string startFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\tasklist.json";

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(startFilePath);

                List<ToDoTask1> startTasks = JsonConvert.DeserializeObject<List<ToDoTask1>>(json);

                foreach (var task in startTasks)
                {
                    checkedListBox1.Items.Add(task.ToString());
                }

                tasks = JsonConvert.DeserializeObject<List<ToDoTask1>>(json);
            }
        }
    }
}
