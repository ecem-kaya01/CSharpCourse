using System;

namespace Day5Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.id = "123456";
            customer1.firstName = "Ecem";
            customer1.lastName = "Kaya";
            customer1.birthDay = "18/06/2007";

            Customer customer2 = new Customer() { id = "245563", firstName = "Engin", lastName = "Yılmaz", birthDay = "06/01/1988" };
            Customer customer3 = new Customer() { id = "896765", firstName = "Salih", lastName = "Çakır", birthDay = "26/09/2001" };

            CustomerManager customerManager = new CustomerManager();
            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (Customer customer in customers)
            {
                customerManager.AddCustomer(customer);
                Console.WriteLine("---------------------------------------------------");
                customerManager.Delete(customer);
                Console.WriteLine("---------------------------------------------------");
                customerManager.Upgrade(customer);
                Console.WriteLine("---------------------------------------------------");

            }
            Game game1 = new Game() { id= "1" , name ="Mount and Blade", price=200 };
            Game game2 = new Game() { id = "2", name = "Assasins Creed", price = 156 };

            GameBuyService gameBuyService = new GameBuyService();

            Game[] games = new Game[] { game1, game2 };

            foreach (Game game in games)
            {
                foreach (Customer customer in customers)
                {
                    gameBuyService.Add(customer, game);
                    Console.WriteLine("---------------------------------------------------");
                }
                gameBuyService.Delete(game);
                Console.WriteLine("---------------------------------------------------");
            }


        }
    }
}
