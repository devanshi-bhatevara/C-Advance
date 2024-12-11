using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AdvancedPractice
{
    public class ExceptionAbuse
    {
        public static void DivideAbuse()
        {
            try
            {
                Console.WriteLine("Enter numerator");
                int numerator = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter denominator");
                int denominator = Convert.ToInt32(Console.ReadLine());

                int result = numerator / denominator;
                Console.WriteLine(result);
            }

            //NOT A GOOD PRACTICE TO USE EXCEPTIONS TO IMPLEMENT CODE LOGIC 
            catch (FormatException)
            {
                Console.WriteLine("Enter a valid number");

            }
            catch (OverflowException)
            {
                Console.WriteLine("Enter a value between {0} and {1}", Int32.MinValue, Int32.MaxValue);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch
            {
                Console.WriteLine("Something went wrong!");
            }
        }  
        
        //BETTER WAY
        public static void Divide()
        {
            try
            {
                Console.WriteLine("Enter numerator");
                int numerator;
                bool IsNumeratorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out numerator);
                if (IsNumeratorConversionSuccessful)
                {

                    Console.WriteLine("Enter denominator");
                    int denominator;
                    bool IsDenominatorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out denominator);

                    if (IsDenominatorConversionSuccessful && denominator != 0)
                    {
                        int result = numerator / denominator;
                        Console.WriteLine(result);
                    }
                    else
                    {
                        if (denominator == 0)
                        {
                            Console.WriteLine("Cannot divide by zero");
                        }
                        else
                        {
                            Console.WriteLine("Enter a valid number value between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid number value between {0} and {1}", Int32.MinValue, Int32.MaxValue);
                }
            }
            catch
            {
                Console.WriteLine("Something went wrong!");
            }
        }
    }
}
