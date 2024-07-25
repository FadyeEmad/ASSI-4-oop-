using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop_4
{
    internal interface imytype
    {
        public int id { get; set; }

        public void myfun( int y);

        public void print()
        {
            Console.WriteLine("Hello Default Implemented Method From Interface");
        }
    }
}
