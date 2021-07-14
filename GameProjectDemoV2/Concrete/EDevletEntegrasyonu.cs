using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemoV2.Abstract;
using GameProjectDemoV2.Entities;

namespace GameProjectDemoV2.Concrete
{
    public class EDevletEntegrasyonu:IGamerCheckService
    {
        public bool CheckPersonIfReal(Gamer gamer)
        {
            if (gamer.NationalityId.Length == 11)
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
