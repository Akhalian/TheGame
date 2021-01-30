using System;
using System.Collections.Generic;
using System.Text;
using TheGame.Entities;

namespace TheGame
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
