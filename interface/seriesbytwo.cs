using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop_4
{
    public class seriesbytwo : iserias
    {
        public int current { get; set ; }

        public void getnext()
        {
           current+=2;
        }

        public void reset()
        {
           current = 0 ;
        }
    }
}
