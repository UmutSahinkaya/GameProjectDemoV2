using System;
using GameProjectDemoV2.Abstract;
using GameProjectDemoV2.Entities;

namespace GameProjectDemoV2.Concrete
{
    public class GameSaleManager : IGameSaleService
    {
        public void Sale(Gamer gamer, Game game, Campaing campaing)
        {
            var indirimlifiyat = game.GamePrice * (campaing.CampaingDiscount / 100);
            var newPrice = game.GamePrice - indirimlifiyat;
            Console.WriteLine(game.GameName + " oyunu " + gamer.FirstName + " " + gamer.LastName + "Kişisine satıldı.");
            Console.WriteLine("Oyunun indirimli hali:" + newPrice + " TL");
            Console.WriteLine("Uygulanan indirim fiyatı:" + indirimlifiyat);
        }
    }
}