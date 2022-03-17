using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public delegate int deladd(int a, int b);
    public delegate int delmulti(int a, int b);
    public delegate int delsub(int a, int b);
    public delegate int deldiv(int a, int b);
    public delegate string delstr(string name);
    public class Calculation
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Multi(int a, int b)
        {
            return a * b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Div(int a, int b)
        {
            return a / b;
        }
        public string Name(string name)
        {
            return name; ;
        }
    }
}
