namespace C_AdvancedPractice.Tasks
{
    public class TaskPractice
    {

        public static int CalculateStringLength(string input)
        {
            Console.WriteLine("CalculateStringLength's thread Id " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(3000);
            return input.Length;
        }
    }
}
