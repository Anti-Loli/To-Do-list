using ToDoList;
using Newtonsoft.Json;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

namespace TimCoreyWinFormDemo
{
    public partial class Form1 : Form
    {
        List<ToDoTask1> currentTaskList = new List<ToDoTask1>();//list for the tasks in the checkedlistbox object
        List<ToDoTask1> completedTaskList = new List<ToDoTask1>();//list for the listbox object
        //file path for the JSON file for the storage of the checkedlistbox(current) tasks
        string currentTaskListFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CurrentTasklist.json";
        //file path for the JSON file for the storage of the listbox(completed) tasks 
        string completedTaskListFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CompletedTasklist.json";


        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)//add task button
        {
            //creates a new ToDoTask1 object and sets it's Name, Date, and Status variables
            var newTask = new ToDoTask1();
            newTask.setTaskName(textBox1.Text);
            newTask.setTaskDate(monthCalendar1.SelectionRange.Start.ToString("MM/dd/yyyy"));

            currentTaskList.Add(newTask);//adds the task to the currentTask list
            checkedListBox1.Items.Add(newTask.ToString());//Adds the task name and date to the list using the ToDoTask1 ToString

            textBox1.Text = "";//Removes text from the text box


            string json = JsonConvert.SerializeObject(currentTaskList, Formatting.Indented);//Serializes the task to JSON
            File.WriteAllText(currentTaskListFilePath, json);//writes text into JSON file for storage
        }

        private void button6_Click(object sender, EventArgs e)//remove task button
        {
            //Gets the index of the currently selected task
            int selectedTask = checkedListBox1.SelectedIndex;

            if (selectedTask != -1 || selectedTask > -1)//Checks if a task was selected. If no then a messagebox is shown.
            {
                checkedListBox1.Items.RemoveAt(selectedTask);//Removes the task from the checkedListBox

                currentTaskList.RemoveAt(selectedTask);

                string jsonUpdate = File.ReadAllText(currentTaskListFilePath);//Opens the JSON file

                JArray jsonArray = JArray.Parse(jsonUpdate);//Parses the JSON array in the file

                jsonArray.RemoveAt(selectedTask);//Removes the task at the same index as the task

                File.WriteAllText(currentTaskListFilePath, jsonArray.ToString());//Closes the JSON file
            }
            else
            {
                //Send message to user in case a task is not seleceted but they press the remove task button
                MessageBox.Show("Please select a task from the task list to remove.");
            }
        }

        private void CompletedTaskRemoveButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            completedTaskList.Clear();

            string jsonUpdate = File.ReadAllText(completedTaskListFilePath);

            JArray jsonArray = JArray.Parse (jsonUpdate);

            for (int i = 0; i < jsonArray.Count; i++) 
            { 
                jsonArray[i].Remove();
            }

            File.WriteAllText(completedTaskListFilePath, jsonArray.ToString());
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)//checks if enter key was pressed 
            {
                AddTaskButton.PerformClick();//runs AddTaskButton method
                e.Handled = true;
            }

        }

        private void checkedListBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)//checks if enter key was pressed 
            {
                RemoveTaskButton.PerformClick();//runs REmoveTaskButton method
                e.Handled = true;
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate 
            {
                int selectedTask = e.Index;
                Debug.WriteLine(selectedTask.ToString());

                if (selectedTask != -1)
                {
                    listBox1.Items.Add(currentTaskList.ElementAt(selectedTask));

                    completedTaskList.Add(currentTaskList.ElementAt(selectedTask));

                    currentTaskList.RemoveAt(selectedTask);

                    checkedListBox1.Items.RemoveAt(selectedTask);

                    string jsonUpdate = File.ReadAllText(currentTaskListFilePath);//Opens the JSON file

                    JArray jsonArray = JArray.Parse(jsonUpdate);//Parses the JSON array in the file

                    jsonArray.RemoveAt(selectedTask);//Removes the task at the same index as the task

                    File.WriteAllText(currentTaskListFilePath, jsonArray.ToString());//Closes the JSON file

                    string json = JsonConvert.SerializeObject(completedTaskList, Formatting.Indented);//Serializes the task to JSON
                    File.WriteAllText(completedTaskListFilePath, json);//writes text into JSON file for storage
                }
            });
        }

        private void monthCalendar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)//checks if enter key was pressed 
            {
                AddTaskButton.PerformClick();//runs AddTaskButton method
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //gets file path for the current task lists
            string loadCurrentTaskListFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CurrentTasklist.json";
           


            if (File.Exists(loadCurrentTaskListFilePath))//checks that the file path exists. 
            {
                string json = File.ReadAllText(loadCurrentTaskListFilePath);//opens JSOn file

                currentTaskList = JsonConvert.DeserializeObject<List<ToDoTask1>>(json);//deserializes list into the currentTaskList list

                //adds each task in JSON file into checkedBoxList(current task list)
                foreach (var task in currentTaskList)
                {
                    checkedListBox1.Items.Add(task.ToString());
                }
            }

            //gets file path for the completed task lists
            string loadCompletedTaskListFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CompletedTasklist.json";

            if (File.Exists(loadCompletedTaskListFilePath))
            {
                string json = File.ReadAllText(loadCompletedTaskListFilePath);//opens JSOn file

                completedTaskList = JsonConvert.DeserializeObject<List<ToDoTask1>>(json);//deserializes list into the currentTaskList list

                foreach (var task in completedTaskList)
                {
                    listBox1.Items.Add(task.ToString());
                }
            }
        }
    }
}
