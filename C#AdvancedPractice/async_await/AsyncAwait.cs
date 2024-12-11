using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AdvancedPractice.async_await
{
    public class AsyncAwait
    {
        public static int CalculateLength(string input)
        {
            Console.WriteLine("inside CalculateLength");
            Thread.Sleep(2000);
            return input.Length;
        }

        public static void Print(int result)
        {
            Console.WriteLine("inside Print");
            Thread.Sleep(2000);
            Console.WriteLine("The result is: " + result);  

        } 
        
        public static async Task<int> CalculateLengthAsync(string input)
        {
            Console.WriteLine("inside CalculateLength");
            await Task.Delay(2000);
            return input.Length;
        }

        public static async Task PrintAsync(int result)
        {
            Console.WriteLine("inside Print");
            await Task.Delay(2000);
            Console.WriteLine("The result is: " + result);  

        }

        public static async Task RunHeavyProcess()
        {
            Console.WriteLine("RunHeavyProcess: " + Thread.CurrentThread.ManagedThreadId);
            string result = await HeavyCalculation();
            Console.WriteLine("RunHeavyProcessAfterAwait: " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(result);
        }

        public static async Task<string> HeavyCalculation()
        {
            Console.WriteLine("HeavyCalculation: " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Some heavy calculation");
            //Thread.Sleep(2000); - it will again cause the code to run synchronously
            await Task.Delay(2000);
            Console.WriteLine("HeavyCalculationAfterAwait: " + Thread.CurrentThread.ManagedThreadId);
            return "Completed";
        }


    }
}
