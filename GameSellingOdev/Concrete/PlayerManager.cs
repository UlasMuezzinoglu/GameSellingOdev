using GameSellingOdev.Abstracts;
using GameSellingOdev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GameSellingOdev.Concrete
{
    class PlayerManager : IPlayerService
    {
        IPlayerCheckService playerCheckService;

        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            this.playerCheckService = playerCheckService;
        }

        public void add(Player player)
        {
            if (this.playerCheckService.isPersonReal(player))
            {
                Console.WriteLine(player.FirstName + " "+player.LastName + ": İsimli Oyuncu Sisteme Eklendi");
            }else
            {
                Console.WriteLine("Doğrulama Başarısız");
            }
        }

        public void delete(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + ": İsimli Oyuncu Sistemden Silindi");
        }

        public void update(Player player)
        {
            Console.WriteLine(player.FirstName + " " + player.LastName + ": İsimli Oyuncu Sistemden Silindi");
        }
    }

    }
