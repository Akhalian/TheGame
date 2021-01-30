using System;
using System.Collections.Generic;
using System.Text;
using TheGame.Entities;

namespace TheGame
{
    interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
