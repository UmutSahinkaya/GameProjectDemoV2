using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemoV2.Abstract;
using GameProjectDemoV2.Entities;

namespace GameProjectDemoV2.Concrete
{
    public class CampaingManager:ICampaingService
    {
        public void Save(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName+"kampanyası eklendi.");
            Console.WriteLine("Kampanya indirimi:%"+campaing.CampaingDiscount);
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName+"kampanyası güncellendi.");
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine(campaing.CampaingName + "kampanyanın süresi doldu.");
        }
    }
}
