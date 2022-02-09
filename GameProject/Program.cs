using System;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer
            {
                firstName = "İlker",
                lastName = "Baykara",
                Id = 1,
                birthYear = "2000"
            };

            //  GamerManager gamerManager = new GamerManager(new UserValidationManager());
            //gamerManager.Add(gamer);
            GamerManager gamerManager2 = new GamerManager(new NewEStateUserValidationManager());
            gamerManager2.Add(gamer);

            Game game1 = new Game { Name ="Forza Horizon", Id = 1 ,unitPrice=150};
            GameSalesManager gameSalesManager = new GameSalesManager(new Campaign { Id=1,campaignName="Efsane Cuma"});
            gameSalesManager.Sale(game1, gamer);
        }
    }
}
