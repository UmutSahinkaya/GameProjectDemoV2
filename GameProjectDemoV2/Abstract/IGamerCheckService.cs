using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemoV2.Entities;

namespace GameProjectDemoV2.Abstract
{
   public interface IGamerCheckService
    {
        bool CheckPersonIfReal(Gamer gamer);
    }
}
