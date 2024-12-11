namespace C_AdvancedPractice
{
    public class RefDemo
    {
        static void ApplyDiscount(ref decimal totalAmount, decimal discount)
        {
            totalAmount -= discount;
        }

        public static void Main()
        {
            decimal refrencedParam = 1000m;
            decimal discount = 100m;

            Console.WriteLine($"Initial Amount: {refrencedParam}");
            ApplyDiscount(ref refrencedParam, discount);
            Console.WriteLine($"Amount after Discount: {refrencedParam}");
        }

        static void ApplyDiscount(decimal totalAmount, decimal discount)
        {
            totalAmount -= discount; // This only modifies the local copy
        }

        public static void Main2()
        {
            decimal totalAmount = 1000m;
            decimal discount = 100m;

            Console.WriteLine($"Initial Amount: {totalAmount}");
            ApplyDiscount(totalAmount, discount); // Passes totalAmount by value
            Console.WriteLine($"Amount after Discount: {totalAmount}"); // Original value remains unchanged
        }

    }
}
