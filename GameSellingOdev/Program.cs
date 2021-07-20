using GameSellingOdev.Concrete;
using GameSellingOdev.Entities;
using System;
using System.Collections.Generic;

namespace GameSellingOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------Start of Player Management----------------------------");
            Player ulas = new Player(1, "Ulaş", "Müezzinoğlu"
                , "11111111111", "martulas5252@gmail.com"
                , "123456", "05445575231");
            PlayerManager playerManager = new PlayerManager(new PlayerCheckManager());
            playerManager.add(ulas);
            playerManager.update(ulas);
            playerManager.delete(ulas);
            Console.WriteLine("------------------------End of Player Management----------------------------\n");
            Console.WriteLine("------------------------Start of Game Management----------------------------\n");
            Game callOfDuty = new Game(1, "Call of Duty", 300);
            Game counterStrike = new Game(2, "Counter-Strike", 200);
            Game batmanArkhamCity = new Game(3, "Batman Arkham City", 350);
            List<Game> games = new List<Game>() { callOfDuty, counterStrike, batmanArkhamCity };
            GameManager gameManager = new GameManager();
            gameManager.add(callOfDuty);
            gameManager.update(callOfDuty);
            gameManager.delete(callOfDuty);
            Console.WriteLine("------------------------------------");
            gameManager.addMultiple(games);
            Console.WriteLine("------------------------End of Game Management----------------------------\n");
            Console.WriteLine("------------------------Start of Campaign Management----------------------------\n");
            Campaign blackFriday = new Campaign(1, "Kara Cuma", 10, new DateTime(2021,5,13), new DateTime(2022, 5, 13));
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.add(blackFriday);
            campaignManager.update(blackFriday);
            campaignManager.delete(blackFriday);
            Console.WriteLine("------------------------End of Campaign Management----------------------------\n");
            Console.WriteLine("------------------------Start of CheckOut Management----------------------------\n");
            CheckoutManager checkoutManager = new CheckoutManager();
            checkoutManager.saleGame(callOfDuty, ulas);
            checkoutManager.saleGameWithCampaign(batmanArkhamCity, ulas, blackFriday);
            Console.WriteLine("------------------------End of CheckOut Management----------------------------\n");

        }
    }
}
