using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiProjectDemo6
{
    class Program
    {
        public delegate Int32 someDelegatePointer(Int32 a, Int32 b);

        static void Main(string[] args)
        {

            someDelegatePointer delegateObj = new someDelegatePointer(delegateFunction);

            Int32 a = 54;
            Int32 b = 55;

            Int32 result = delegateObj.Invoke(a,b);

            Console.WriteLine("This amount {0} is hte result", result);

            var t1 = new Task(delegate() {

                Thread.Sleep(2000);
                Console.WriteLine("this is task");
            });

            t1.Start();

            Console.ReadKey();

        }


        static public Int32 delegateFunction(Int32 a, Int32 b)
        {
            Int32 temp = a + b;
            return temp;
        }


    } // End of class
} // End of namespace
