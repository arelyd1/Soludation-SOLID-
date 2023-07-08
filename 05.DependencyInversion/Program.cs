using System;
using System.Linq.Expressions;

namespace _05.DependencyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HomeIndex();
            CategoryIndex();
            CategoryIndex2();
            CategoryIndex3();
        }

        static void HomeIndex()
        {
            //CategoryRepositoryEf ef = new CategoryRepositoryEf();
            //ef.GetCategories();
            Container container = new Container();
            container.GetInstanve().GetCategories();
        }
        static void CategoryIndex()
        {
            Container container = new Container();
            container.GetInstanve().GetCategories();
        }

        static void CategoryIndex2()
        {
            Container container = new Container();
            container.GetInstanve().GetCategories();
        }
        static void CategoryIndex3()
        {
            Container container = new Container();
            container.GetInstanve().GetCategories();
        }

    }
    class Container
    {
        public ICategoryRepository GetInstanve()
        {
            return new CategoryRepositoryDP();
        }
    }

    interface ICategoryRepository
    {
        void GetCategories();
    }
    class CategoryRepositoryEf: ICategoryRepository
    {
      //  private readonly ICategoryRepository _repository;
      //public CategoryRepositoryEf(ICategoryRepository repository)
      //  {

      //  }
        public void GetCategories()
        {
            Console.WriteLine("Ef");
        }
    }

    class CategoryRepositoryDP :ICategoryRepository
    {
        public void GetCategories()
        {
            Console.WriteLine("Dp");
        }
    }
}
