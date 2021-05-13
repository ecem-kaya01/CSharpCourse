using System;
using System.Collections.Generic;
using System.Text;

namespace Day5Homework
{
    class GameBuyService
    {

        public void Add(Customer customer,Game game)
        {
            Console.WriteLine(customer.firstName+" adlı müşterimize bizi tercih edip "+ game.name +" adlı oyunu aldığı için teşekkür ederiz" );
        }
        public void Delete(Game game)
        {
            Console.WriteLine(game.name+ " adlı oyun silindi!");
        }
    }
}
