using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU.Library
{
    public class Fenn
    {
        public int id { get; private set; }
        public string name { get; set; }
        public Fenn()
        {
            this.id = Tool.get_id();
            this.name = "Ana dili";
        }
        public Fenn(string name)
        {
            this.id = Tool.get_id();
            this.name = name;
        }
        public void Print()
        {
            Console.WriteLine($"Fenn ad= {name} ID = {id}");
        }
    }
}
