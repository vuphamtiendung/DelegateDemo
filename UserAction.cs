using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Delegate_003
{
    internal class UserAction : TestDelegate
    {
        public static TestDelegate testdelegate = null;

        public delegate int Delegate(int number_A, int number_B);

        public static UserAction useraction;
        public UserAction() { }
        public static UserAction GetUserAction()
        {
            if(useraction == null)
            {
                useraction = new UserAction();
            }
            return useraction;
        }

        public void Perform()
        {
            WriteLine("-------------------------------");

            testdelegate = new TestDelegate();

            Delegate number = new Delegate(AddNumber);
            Delegate numberMult = new Delegate(MultNumber);

            number(100, 500);
            WriteLine($"Gia tri cua num la: {Number}");
            numberMult(500, 1000);
            WriteLine($"Gia tri cua num la: {Number}");

            ReadKey();
        }
    }
}
