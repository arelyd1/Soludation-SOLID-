// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
class Customer
{
    public string Name { get; set; }
    
   
    class CustomerValidator
    {
        public bool ValidateName(string name)
        {
            return !string.IsNullOrWhiteSpace(name);
        }

    }

    class CustomerManager
    {
        public void SayHello(string name)
        {
            Console.WriteLine("Hello" + name);
        }
    }
}

