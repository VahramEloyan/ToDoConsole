using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoConsole
{
   public class ToDo
    {
        public int Index { set; get; }
        public List<string> ListDes { set; get; }       
        public bool IsDone { set; get; }
        public int Caunt { set; get; }
        public void ShowList(List<string> ls)
        {
            foreach(string x in ls)
            {
                Console.WriteLine(x);
            }
        }
        public void AddDes(List<string> list, string description)
        {
            list.Add(description);
        }
       // public void ChangeColore()
    }
}
