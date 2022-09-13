using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDLL
{
    public class Simple
    {
        public string SayHello(string name)
        {
            return "สวัสดีคุณ" + name;
        }
        public double calculate(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
