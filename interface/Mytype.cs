using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop_4
{
    public class Mytype : imytype
    {
        public int id { get; set; }

        public void myfun(int y)
        {
            Console.WriteLine($" y = {y} _________ id = {id}");
        }
    }
}
