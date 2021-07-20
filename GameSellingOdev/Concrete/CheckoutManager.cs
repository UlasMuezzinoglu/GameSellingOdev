using GameSellingOdev.Abstracts;
using GameSellingOdev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellingOdev.Concrete
{
    



    class CheckoutManager : ICheckoutService
    {
        public void saleGame(Game game, Player player)
        {
            Console.WriteLine(player.FirstName+ " " + player.LastName + " İsimli Oyuncuya,"+game.GameName+" adlı oyun Satıldı.");
        }

        public void saleGameWithCampaign(Game game, Player player, Campaign campaign)
        {
            double finalUnitPrice = game.Price - (game.Price * campaign.DiscountRate / 100);
            DateTime start = campaign.StartDate;
            DateTime end = campaign.EndDate;
            DateTime today = DateTime.Today;

            if ((start.Day <= today.Day) && (today.Month <= end.Month) )
            {
                Console.WriteLine("Kampanya Bitmiştir."+game.GameName+" oyunu için mevcut fiyat Baz alınacak");
            }
            else
            {
                Console.WriteLine(player.FirstName + " " + player.LastName + " İsimli Oyuncuya," + game.GameName + " adlı oyun,"+ campaign.DiscountRate+ " Oranında İndirim Uygulandı.");

            }
        }
    }
}
