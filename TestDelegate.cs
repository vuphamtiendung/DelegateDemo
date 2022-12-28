using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Delegate_003
{
    internal class TestDelegate
    {
        private static int _number;

        public static int Number { get { return _number; } }

        public TestDelegate()
        {
            _number = 0;
        }

        public TestDelegate(int number)
        {
            _number = number;
        }

        public int AddNumber(int number_A, int number_B)
        {
            return _number = number_A + number_B;
        }

        public int MultNumber(int number_A, int number_B)
        {
            return _number = number_A * number_B;
        }
    }
}
