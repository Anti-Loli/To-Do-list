using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class ToDoTask : IComparable<ToDoTask>
    {
        public string? taskName;
        public string? taskDate;
        public string? taskType;
        public bool? taskNotified;

        public ToDoTask(string name, string date, string type, bool notified)
        {
            taskName = name;
            taskDate = date;
            taskType = type;
            taskNotified = notified;
        }

        public void setTaskName(string name)
        {
            taskName = name;
        }

        public void setTaskDate(string date)
        {
            taskDate = date;
        }

        public void setTaskType(string type)
        {
            taskType = type;
        }

        public void setTaskNotified(bool notified)
        {
            taskNotified = notified; 
        }

        public override string ToString()
        {
            return (taskName + " " + taskDate + " Tag: " + taskType);
        }

        public int CompareTo(ToDoTask? other)
        {
            return taskName.CompareTo(other.taskName);
        }
    }

    public class TypeComparer : IComparer<ToDoTask>
    {
        public int Compare(ToDoTask x, ToDoTask y)
        {
            return x.taskType.CompareTo(y.taskType);
        }
    }

    public class DateComparer : IComparer<ToDoTask>
    {
        public int Compare(ToDoTask x, ToDoTask y)
        {
            return x.taskDate.CompareTo(y.taskDate);
        }
    }
}
