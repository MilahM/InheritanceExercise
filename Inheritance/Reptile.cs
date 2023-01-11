﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile() 
        { 
        }

        public bool IsColdBlooded { get; set; }
        public bool HasScales { get; set; }
        public int NumberOfLegs { get; set; }
        public int NumberOfLungs { get; set; }  
    }
}
