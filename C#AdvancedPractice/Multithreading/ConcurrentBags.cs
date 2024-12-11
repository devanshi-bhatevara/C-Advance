using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AdvancedPractice.Multithreading
{
    public class ConcurrentBags
    {
        public const int pi = 3;
        public static int piStatic = 3;

        public void NonThreadSafe()
        {
            List<int> numbers = new List<int>();
            Parallel.For(0, 1000, i =>
            {
                Thread.Sleep(100);

                numbers.Add(i); 
                
            });
            foreach (var i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }   
        
        public void ThreadSafe()
        {
            ConcurrentBag<int> safeNumbers = new ConcurrentBag<int>();
            Parallel.For(101, 2000, i =>
            {
                safeNumbers.Add(i);  
            });
            foreach (var num in safeNumbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
