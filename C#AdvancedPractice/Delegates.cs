

namespace C_AdvancedPractice
{
    public delegate void HelloDelegate(string message);
    public class Delegates
    {
        public void Hello(string message)
        {
            Console.WriteLine(message);
        }
    }

    public delegate bool IsPromotable(Employee emp);

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }


        //don't want to hardcode the logic to promote employees
        public static void PromoteEmployee(List<Employee> employees, IsPromotable isPromotable)
        {
            foreach (Employee employee in employees)
            {
                if(isPromotable(employee))
                {
                    Console.WriteLine(employee.Name + "promoted");
                }
            }
        }

        //lambda expressions simplify this too,no need of this method
        public static bool Promote(Employee emp)
        {
            if (emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }

        }  

    }
}
