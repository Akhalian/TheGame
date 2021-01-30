using System;
using System.Collections.Generic;
using System.Text;
using TheGame.Abstract;
using TheGame.Entities;

namespace TheGame
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1997 && gamer.FirstName=="Burak" && gamer.LastName=="Baskın" && gamer.IdentityNumber==12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
