using System;
using System.Collections.Generic;
using System.Text;
using TheGame.Entities;

namespace TheGame.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
