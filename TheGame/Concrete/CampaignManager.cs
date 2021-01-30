using System;
using System.Collections.Generic;
using System.Text;
using TheGame.Abstract;
using TheGame.Entities;

namespace TheGame
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya başladı!");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya sona erdi.");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
