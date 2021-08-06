using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstract.Managers
{
    class GamerManager:IGamerManagerService
    {
        private readonly IPersonVerificateService _personVerificateService;

        public GamerManager(IPersonVerificateService personVerificateService)
        {
            _personVerificateService = personVerificateService;
        }

        public void Add(Gamer gamer)
        {
            if (_personVerificateService.Verification(gamer))
            {
                Console.WriteLine(gamer.FirstName + " added. Money: "+gamer.Money +" TL");
            }
            else
            {
                Console.WriteLine(gamer.FirstName + " could not be verified.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " updated.");
        }

        public void ShowOwnGames(Gamer gamer)
        {
            foreach (var game in gamer.OwnGames)
            {
                Console.WriteLine(gamer.FirstName + " owns " + game.Name + " (" + game.Price + "TL)");
            }
        }

        public void ShowMoney(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "'s money: " + Math.Round(decimal.Parse(gamer.Money.ToString()),2) + " TL");
        }
    }
}
