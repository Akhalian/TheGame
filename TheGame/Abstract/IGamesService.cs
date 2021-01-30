using System;
using System.Collections.Generic;
using System.Text;
using TheGame.Entities;

namespace TheGame.Abstract
{
    interface IGamesService
    {
        void Add(Games games);
        void Delete(Games games);
        void Update(Games games);
    }
}
