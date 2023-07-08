class program
{
    static void Main(string[] args)
    {
        SalaryCalculater calculater = new SalaryCalculater(new FullTimeEmployee());
        calculater.CalculateSalary();
        Console.WriteLine("hello word");
            
    }
}
interface IEmployee
{
    void calculateSalary();
}
class FullTimeEmployee : IEmployee
{
    public void calculateSalary()
    {
        Console.WriteLine("Full");
    }
}

class PartTimeEmployee : IEmployee
    {
        public void CalculateSalary()
        {
            Console.WriteLine("Part");
        }

    public void calculateSalary()
    {
        throw new NotImplementedException();
    }
}
    //class SupportEmployed : IEmployee
    //{
    //    public void CalculateSalary()
    //    {
    //        Console.WriteLine("Support");
    //    }

    //    public void calculateSalary()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    class SalaryCalculater
    {
        //    {
        //     public void CalculateSalary(string employeeType)
        //       {
        //            if (employeeType=="Full")
        //            {
        //                new FullTimeEmployed().calculateSalary();
        //            }
        //            else if (employeeType=="Support")
        //            {
        //                new SuportEmployed().CalculateSalary();
        //            }
        //            else
        //            {
        //                new PartTimeEmployed().CalculateSalary();
        //            }

        //        }
        //    }

        private readonly IEmployee employee;
        public SalaryCalculater(IEmployee employee)
        {
            this.employee = employee;
        }
        public void CalculateSalary()
        {
            this.employee.calculateSalary();
        }
    }

    

