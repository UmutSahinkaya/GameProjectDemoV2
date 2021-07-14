using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemoV2.Abstract;
using GameProjectDemoV2.Entities;

namespace GameProjectDemoV2.Concrete
{
    public class GameManager:IGameService
    {
        public void Save(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun eklendi.\n" +
                              "Fiyatı: " + game.GamePrice +
                              "\nKategori: " + game.GameCategory);
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun güncellendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun kaldırıldı.");
        }
    }
}
