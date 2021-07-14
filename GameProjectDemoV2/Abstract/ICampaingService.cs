using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemoV2.Entities;

namespace GameProjectDemoV2.Abstract
{
    public interface ICampaingService
    {
        void Save(Campaing campaing);
        void Update(Campaing campaing);
        void Delete(Campaing campaing);
    }
}
