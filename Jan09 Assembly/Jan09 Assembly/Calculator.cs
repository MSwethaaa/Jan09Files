using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan09_Assembly
{
  
        public class Calculator
        {
            public int Num1 { get; set; }
            public int Num2 { get; set; }
            public double Adding() { return Num1 + Num2; }
            public double Substract() { return Num1 - Num2; }
            protected double Multiply() { return Num1 * Num2; }
        }
    }
