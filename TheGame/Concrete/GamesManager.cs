using System;
using System.Collections.Generic;
using System.Text;
using TheGame.Abstract;
using TheGame.Entities;

namespace TheGame.Concrete
{
    
    class GamesManager : IGamesService
    {
        public void Add(Games games)
        {
            Console.WriteLine("Oyun eklendi.");
        }

        public void Delete(Games games)
        {
            Console.WriteLine("Oyun silindi.");
        }

        public void Update(Games games)
        {
            Console.WriteLine("Oyun güncellendi.");
        }
    }
}
