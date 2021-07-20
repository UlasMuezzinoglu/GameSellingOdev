using GameSellingOdev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellingOdev.Abstracts
{
    interface ICampaignService
    {
        void add(Campaign campaign);
        void update(Campaign campaign);
        void delete(Campaign campaign);
    }
}
