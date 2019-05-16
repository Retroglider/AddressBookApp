using Domain;
using Repository;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using(var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
            {
                //var addressBook = new AddressBook() {Name="Test" , SystemId="rhyss", Password ="123" };
            }
        }

        static void CreateUser(User user)
        {
            using(var unitOfWork = new UnitOfWork(new ApplicationDbContext()))
            {
               
            }
        }
    }
}
