using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class GameSalesManager : IGameSalesService
    {
        Campaign campaign;

        public GameSalesManager(Campaign _campaign)
        {
            campaign = _campaign;
        }
        public void Sale(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.firstName +", "+ game.Name +" adlı oyunu satın aldı ve " + campaign.campaignName +" kampanyası uygulandı");
        }
    }
}
