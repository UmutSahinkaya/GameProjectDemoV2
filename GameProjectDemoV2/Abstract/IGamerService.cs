using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemoV2.Entities;

namespace GameProjectDemoV2.Abstract
{
    public interface IGamerService
    {
        void Save(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
