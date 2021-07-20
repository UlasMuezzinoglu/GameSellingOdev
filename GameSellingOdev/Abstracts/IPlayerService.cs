using GameSellingOdev.Entities;

namespace GameSellingOdev.Abstracts
{
    interface IPlayerService
    {
        void add(Player player);
        void update(Player player);
        void delete(Player player);
    }
}
