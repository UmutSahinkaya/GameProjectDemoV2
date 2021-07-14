using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemoV2.Entities;

namespace GameProjectDemoV2.Abstract
{
    public interface IGameService
    {
        void Save(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
