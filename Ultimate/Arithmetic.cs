using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate
{
    class Arithmetic
    {
        public Random number;
        public Random operators;
        public int answers { get; set; }

        public Arithmetic (Random number , Random operators)
        {
            this.number = number;
            this.operators = operators;
        }

        public int Play()
        {
            return answers;
        }


        
        }
}
