using System;
using TheGame.Concrete;
using TheGame.Entities;

namespace TheGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer 
            {
                Id = 1,
                BirthYear = 1997,
                FirstName = "Burak",
                LastName = "Baskın",
                IdentityNumber = 12345
            });

            Games game1 = new Games();
            game1.Id = 123;
            game1.Name = "The Game";


            SalesManager salesManager = new SalesManager();
            salesManager.Purchase(game1);
        }
    }
}
