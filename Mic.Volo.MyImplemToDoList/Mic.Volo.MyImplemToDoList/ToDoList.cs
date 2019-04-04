using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Volo.MyImplemToDoList
{
    class Dict<Key,Value>
    {

    }
    class ToDoList
    {
        private List<string> data = new List<string>();
        //private string[] Date = new string[]();
        public ToDoList()
        {
                
        }
        public void AddText()
        {
            Console.WriteLine("********Here Write the Text for Save Press Enter********");
            string s = Console.ReadLine();
            data.Add(s);
        }
        public void ShowAll()
        {
            var Content = from s in data select s;
            foreach (var item in Content)
            {
                Console.Write(item);
            }
        }
    }
}
