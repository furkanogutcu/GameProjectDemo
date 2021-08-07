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
        public void Buy(Gamer gamer, List<Game> games, List<Campaign> campaigns)
        {
            foreach (Game game in games)
            {
                if (gamer.OwnGames.Contains(game))
                {
                    Console.WriteLine(gamer.FirstName + " already owns " + game.Name);
                }
                else
                {
                    double tempPrice = game.Price;
                    string message = (gamer.FirstName + " bought the game: " + game.Name + "(-" + tempPrice + " TL)");
                    foreach (var campaign in campaigns)
                    {
                        tempPrice = Convert.ToDouble(Math.Round(decimal.Parse((game.Price - (game.Price * (Convert.ToDouble(campaign.DiscountRate * 0.01)))).ToString()), 2));
                        message = (gamer.FirstName + " bought the game: " + game.Name + "(-" + tempPrice + " TL)" + " with the " + campaign.Name +
                                   " (old price: " + game.Price + " TL - " +
                                   "discount rate: %" + campaign.DiscountRate + " - " +
                                   "new price: " + tempPrice + " TL)");
                    }
                    gamer.Money -= tempPrice;
                    gamer.OwnGames.Add(game);
                    Console.WriteLine(message);
                }
            }
        }
    }
}
