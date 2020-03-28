using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RaceCondition
{
    class Program
    {
        static int result = 0;

        static void ChangeToOne() => result = 1;
        static void ChangeToTwo() => result = 2;
        static void ChangeToThree() => result = 3;

        static void Main(string[] args)
        {
            for(int i = 0; i < 20; i++)
            {
                Thread firstThread = new Thread(ChangeToOne);
                Thread secondThread = new Thread(ChangeToTwo);
                Thread thirdThread = new Thread(ChangeToThree);

                firstThread.Start();
                secondThread.Start();
                thirdThread.Start();

                Console.WriteLine($"Result is {result}");
            }

            Console.ReadKey();
        }
    }
}
