using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.ToDoConsole
{
    class To_do:IComparable<To_do>
    {
        public int Todo_ID { get; set; }
        public DateTime date { get; set; }
        public string Task { get; set; }
        public int Lvl_Imp { get; set; }
        public To_do(int todo_ID, DateTime date, string task, int lvl_Imp)
        {
            Todo_ID = todo_ID;
            this.date = date;
            Task = task;
            Lvl_Imp = lvl_Imp;
        }

        public int CompareTo(To_do other)
        {
            return this.Todo_ID.CompareTo(other.Todo_ID);
        }
    }
}
