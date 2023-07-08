using System;

namespace _04.İnterfaceSegregation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public interface IRepository
    {
        void add();
        
       
    }
    public interface ICategoryRepository : IRepository
    {
        void GetCategories();

    }
    public interface IProductRepository : IRepository
    {
        void GetProduct();
    }
    public class CategoryRepository : ICategoryRepository
    {
        public void add()
        {
            Console.WriteLine("added");
        }

        public void GetCategories()
        {
            Console.WriteLine("List category");
        }
    }
    public class ProductRepository: IProductRepository
    {
        public void add()
        {
            Console.WriteLine("added");
        }

        public void GetProduct()
        {
            Console.WriteLine("List Product");
        }

     
    }

}
