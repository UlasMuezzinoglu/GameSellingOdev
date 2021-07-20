using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellingOdev.Entities
{
    class Campaign
    {
        public Campaign()
        {

        }
        public Campaign(int id,string campaignName, double discountRate,DateTime startDate,DateTime endDate)
        {
            this.Id = id;
            this.CampaignName = campaignName;
            this.DiscountRate = discountRate;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public double DiscountRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
