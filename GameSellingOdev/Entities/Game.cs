using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellingOdev.Entities
{
    class Game
    {
        public Game()
        {

        }
        public Game(int id, string gameName, double price)
        {
            this.Id = id;
            this.GameName = gameName;
            this.Price = price;
        }
        public int Id { get; set; }
        public string GameName { get; set; }
        public double Price { get; set; }
    }
}
