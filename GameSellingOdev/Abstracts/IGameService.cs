using GameSellingOdev.Entities;
using System.Collections.Generic;

namespace GameSellingOdev.Abstracts
{
    interface IGameService
    {
        void add(Game game);
        void delete(Game game);
        void update(Game game);
        void addMultiple(List<Game> games);
    }
}
