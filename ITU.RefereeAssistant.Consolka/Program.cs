using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ITU.RefereeAssistant.Consolka
{
    class test
    {
        public void test_print()
        {
            Console.WriteLine("test");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            test obj_1 = new test();
            obj_1.test_print();

        }
    }
}
