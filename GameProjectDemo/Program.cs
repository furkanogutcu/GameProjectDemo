using System;
using System.Collections.Generic;
using GameProjectDemo.Abstract.Managers;
using GameProjectDemo.Entities;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer
            {
                Id = 1,
                FirstName = "Furkan",
                LastName = "Ogutcu",
                BirthOfDay = new DateTime(1985,1,1),
                NationalityId = 12345678910,
                Money = 105.30
            };

            Gamer gamer2 = new Gamer
            {
                Id = 2,
                FirstName = "Ahmet",
                LastName = "Ogutcu",
                BirthOfDay = new DateTime(1989, 1, 1),
                NationalityId = 10987654321,
                Money = 70.35
            };

            GamerManager gamerManager = new GamerManager(new GamerVerificateManager());
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);

            Game game1 = new Game
            {
                Id = 1,
                Name = "Call of Duty",
                CategoryId = 1,
                Price = 20.10
            };

            Game game2 = new Game
            {
                Id = 2,
                Name = "FIFA 21",
                CategoryId = 2,
                Price = 34.55
            };

            GameManager gameManager = new GameManager();
            gameManager.Buy(gamer1, new List<Game> {game1, game2});
            gameManager.Buy(gamer2,new List<Game> {game1});

            gamerManager.ShowOwnGames(gamer1);
            gamerManager.ShowOwnGames(gamer2);
            gamerManager.ShowMoney(gamer1);
            gamerManager.ShowMoney(gamer2);
        }
    }
}
