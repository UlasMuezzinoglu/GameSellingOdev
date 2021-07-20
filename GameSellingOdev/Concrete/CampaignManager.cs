using GameSellingOdev.Abstracts;
using GameSellingOdev.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellingOdev.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" İsimli kampanya Eklendi");
        }

        public void delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " İsimli kampanya Silindi");
        }

        public void update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " İsimli kampanya Güncellendi");
        }
    }
}
