using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AdvancedPractice
{
    public class OutDemo
    {
        public static bool ValidateCredentials(string username, string password, out string role)
        {
            if (username == "admin" && password == "1234")
            {
                role = "Administrator";
                return true;
            }
            else
            {
                role = "Guest";
                return false;
            }
        }

        static void PrintInfo(string message, params int[] numbers)
        {
            Console.WriteLine(message);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void Main2()
        {
            string role;
            bool isValid = ValidateCredentials("admin", "1234", out role);
            Console.WriteLine($"Login Successful: {isValid}, Role: {role}");
        }
    }
}
