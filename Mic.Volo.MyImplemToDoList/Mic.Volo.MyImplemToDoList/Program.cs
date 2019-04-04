using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.MyImplemToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoList toDo = new ToDoList();
            toDo.AddText();
            toDo.ShowAll();
        }
    }
}
