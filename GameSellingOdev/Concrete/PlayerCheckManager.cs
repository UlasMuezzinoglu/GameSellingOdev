using GameSellingOdev.Abstracts;
using GameSellingOdev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GameSellingOdev.Concrete
{
    class PlayerCheckManager : IPlayerCheckService
    {
        public bool isPersonReal(Player player)
        {
            return true;
        }
    }
}
