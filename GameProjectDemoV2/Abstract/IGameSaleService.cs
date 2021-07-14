using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemoV2.Entities;

namespace GameProjectDemoV2.Abstract
{
    public interface IGameSaleService
    {
        void Sale(Gamer gamer, Game game, Campaing campaing);
    }
}
