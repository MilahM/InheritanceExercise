using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {

        }

        public int NumberOfLegs { get; set; }
        public string BeakSize { get; set; }
        public bool LaysEggs { get; set; }
        public bool CanFly { get; set; }
        
    }
}
