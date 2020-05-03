using Microsoft.EntityFrameworkCore.Migrations.Operations;
using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using SimpleTrader.EntityFramework;
using SimpleTrader.EntityFramework.Services;
using System;
using System.Linq;
using System.Transactions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //use create methode to insert into database
            //IDataService<User> userService = new GenericDataService<User>(new SimpleTraderDbContextFactory());
            //userService.Create(new User { Username = "Test" }).Wait ();

            //use get methode to display database
            //IDataService<User> userService = new GenericDataService<User>(new SimpleTraderDbContextFactory());
            //Console.WriteLine(userService.GetAll().Result.Count());
            //Console.ReadLine();


            //use update methode to edit database
            //IDataService<User> userService = new GenericDataService<User>(new SimpleTraderDbContextFactory());
            //Console.WriteLine(userService.Update(1 , new user(){Username="testuser"}).Result);
            //Console.ReadLine();

            //use update methode to delete from database
            IDataService<User> userService = new GenericDataService<User>(new SimpleTraderDbContextFactory());
            Console.WriteLine(userService.Delete(1).Result);
            Console.ReadLine();
        }
    }
}
