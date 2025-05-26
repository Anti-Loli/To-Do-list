using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class ToDoTask1
    {
        string? taskName;
        string? taskDate;

        public void ToDoTask()
        {

        }

        public void setTaskName(string name)
        {
            taskName = name;
        }

        public void setTaskDate(string date)
        {
            taskDate = date;
        }

        public override string ToString()
        {
            return (taskName + " " + taskDate);
        }
    }
}
