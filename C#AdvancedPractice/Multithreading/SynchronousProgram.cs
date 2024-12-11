using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AdvancedPractice.Multithreading
{
    public class SynchronousProgram
    {
        public static void PrintPluses(int n)
        {
            Console.WriteLine("Thread's Id Plus: " + Thread.CurrentThread.ManagedThreadId);
            for (int i = 0; i < n; i++)
            {
                Console.Write("+");
            }
        }
        public static void PrintMinuses(int n)
        {
            Console.WriteLine("Thread's Id Minus: " + Thread.CurrentThread.ManagedThreadId);
            for (int i = 0; i < n; i++)
            {
                Console.Write("-");
            }
        }

        public static void PrintA(object obj)
        {
            //Console.WriteLine("A");
        }
    }
}
