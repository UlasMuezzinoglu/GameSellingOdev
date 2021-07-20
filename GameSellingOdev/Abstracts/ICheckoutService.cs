using GameSellingOdev.Entities;

namespace GameSellingOdev.Abstracts
{
    interface ICheckoutService
    {
        void saleGame(Game game, Player player);
        void saleGameWithCampaign(Game game, Player player, Campaign campaign);
    }
}
