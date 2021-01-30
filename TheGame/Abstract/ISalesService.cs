using System;
using System.Collections.Generic;
using System.Text;
using TheGame.Entities;

namespace TheGame.Abstract
{
    interface ISalesService
    {
        void Purchase (Games games);
        void SpecialOffer (Campaign campaign);
    }
}
