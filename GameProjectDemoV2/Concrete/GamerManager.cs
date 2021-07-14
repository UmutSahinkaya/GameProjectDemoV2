using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemoV2.Abstract;
using GameProjectDemoV2.Entities;

namespace GameProjectDemoV2.Concrete
{
    public class GamerManager:IGamerService
    {
        private EDevletEntegrasyonu _entregrasyon;

        public GamerManager(EDevletEntegrasyonu entregrasyon)
        {
            this._entregrasyon = entregrasyon;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + gamer.LastName + " adlı oyuncu silindi.");
        }

        public void Save(Gamer gamer)
        {
            if (_entregrasyon.CheckPersonIfReal(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + "Kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Bilgilerinizi tekrar kontrol ediniz.");
            }

        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + gamer.LastName + " adlı oyuncunun bilgileri güncellendi.");
        }
    }
}
