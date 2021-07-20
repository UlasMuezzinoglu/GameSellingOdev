using GameSellingOdev.Abstracts;
using GameSellingOdev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GameSellingOdev.Concrete
{
    class GameManager : IGameService
    {
        public void add(Game game)
        {
            Console.WriteLine(game.GameName + " İsimli Oyun Eklendi");

        }

        public void addMultiple(List<Game> games)
        {
            foreach (Game game in games)
            {
                add(game);
            }
        }

        public void delete(Game game)
        {
            Console.WriteLine(game.GameName + " İsimli Oyun Silindi");
        }

        public void update(Game game)
        {
            Console.WriteLine(game.GameName + " İsimli Oyun Güncellendi");
        }
    }
}
