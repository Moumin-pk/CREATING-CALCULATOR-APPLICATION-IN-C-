using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Calculater_in_C_Sharp
{
    internal class Calculater
    {

        public int sum(int a, int b)
        {

            return a + b;
        }

        public int min(int a, int b)
        {

            return a - b;
        }

        public int Div(int a, int b)
        {

            return a / b;
        }

        public int Mult(int a, int b)
        {

            return a * b;
        }

        public int Moduls(int a, int b)
        {

            return a % b;
        }
    }
}
