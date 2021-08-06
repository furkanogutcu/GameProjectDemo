using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstract.Managers
{
    class GameManager:IGameManagerService
    {
        public void Buy(Gamer gamer, List<Game> games)
        {
            foreach (Game game in games)
            {
                gamer.Money -= game.Price;
                gamer.OwnGames.Add(game);
            }
        }
    }
}
