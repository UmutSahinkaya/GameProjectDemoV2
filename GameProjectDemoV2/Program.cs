using System;
using GameProjectDemoV2.Concrete;
using GameProjectDemoV2.Entities;

namespace GameProjectDemoV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game'lerin oluşturuldu kısım 
            Game game1 = new Game
            {
                GameName = "Last Of Us 2",
                GameCategory = "Hayatta Kalma",
                GamePrice = 250
            };
            Game game2 = new Game
            {
                GameName = "Uncharted 4",
                GameCategory = "Macera",
                GamePrice = 350
            };
            Game game3 = new Game
            {
                GameName = "God Of War",
                GameCategory = "Aksiyon, Dövüş",
                GamePrice = 450
            };

            //Kampanyaların Oluşturulduğ Kısım 
            Campaing campaing1 = new Campaing 
                {CampaingName = "Yaz İndirimi", CampaingDiscount = 50};

            Campaing campaing2 = new Campaing()
                {CampaingName = "Haftasonu İndirimi",CampaingDiscount = 25};

            //Gamer'ların oluşturuluğu kısım
            Gamer gamer1 = new Gamer
            {
                FirstName = "Engin ",
                LastName = "Demiroğ",
                NationalityId = "12345678910",
                DateOfBirth = new DateTime(1985, 1, 6)
            };
            Gamer gamer2 = new Gamer
            {
                FirstName = "Umut ",
                LastName = "Şahinkaya",
                NationalityId = "10987654321",
                DateOfBirth = new DateTime(1998, 10, 20)
            };

            //Gamer'ların yönetildiği kısım (Add, Update, Delete)
            GamerManager gamerManager = new GamerManager(new EDevletEntegrasyonu());
            gamerManager.Save(gamer1);
            gamerManager.Save(gamer2);
            gamerManager.Update(gamer1);

            Console.WriteLine("************************");

            //Game'lerin yönetildiği kısım 
            GameManager gameManager = new GameManager();
            gameManager.Save(game1);

            Console.WriteLine("-------------------------");


            gameManager.Save(game2);

            Console.WriteLine("************************");

            //Kampanyaların yönetildiği kısım 
            CampaingManager campaingManager = new CampaingManager();
            campaingManager.Save(campaing1);
            campaingManager.Save(campaing2);

            Console.WriteLine("************************");

            //Oyun satışlarının yönetildiği kısım. 
            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(gamer1, game1, campaing1);

            Console.WriteLine("************************");

            gameSaleManager.Sale(gamer2, game3, campaing2);






            Console.ReadLine();
        }
    }
}
