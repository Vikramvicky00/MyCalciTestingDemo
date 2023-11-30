using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalci
{
    public class Calculator
    {
        public int a {  get; set; }
        public int b { get; set; }

        public int Add() { return a + b; }
        public int Sub() { return a - b; }
        public int Mul() { return a * b;}
        public int Div() { return a / b;}
    }
}
