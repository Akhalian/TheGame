using System;
using System.Collections.Generic;
using System.Text;
using TheGame.Abstract;
using TheGame.Entities;

namespace TheGame
{
    class SalesManager : ISalesService
    {
        public void Purchase(Games games)
        {
            Console.WriteLine("Satın alımınız için teşekkür ederiz.");
        }

        public void SpecialOffer(Campaign campaign)
        {
            Console.WriteLine("Özel teklifimize bakmak ister misiniz?");
        }
    }
}
