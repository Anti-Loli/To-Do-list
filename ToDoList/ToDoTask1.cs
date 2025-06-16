using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class ToDoTask1
    {
        public string? taskName;
        public string? taskDate;
        public bool taskStatus; 

        public void ToDoTask(string name, string date)
        {
            taskName = name;
            taskDate = date;
            taskStatus = false;
        }

        public void setTaskName(string name)
        {
            taskName = name;
        }

        public void setTaskDate(string date)
        {
            taskDate = date;
        }

        public void setTaskStatus(bool status)
        {
            taskStatus = status; 
        }

        public override string ToString()
        {
            return (taskName + " " + taskDate);
        }
    }
}
