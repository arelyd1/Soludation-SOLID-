// See https://aka.ms/new-console-template for more information
Employee Employee = new PartTimeEmployee();

class Employee
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }
    
}
class PartTimeEmployee :Employee
{

    public decimal DailyWage { get; set; }
}
class FullTimeEmployee :Employee
{
    public decimal HourlyWage { get; set; }
}

