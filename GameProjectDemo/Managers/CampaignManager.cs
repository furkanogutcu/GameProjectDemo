using System;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstract.Managers
{
    public class CampaignManager:ICampaignManagerService
    {
        public Campaign AddCampaign(int id, string name, int discountRate)
        {
            return new Campaign
            {
                Id = id,
                Name = name,
                DiscountRate = discountRate
            };
        }

        public Campaign UpdateCampaignDiscountRate(Campaign campaign, int discountRate)
        {
            campaign.DiscountRate = discountRate;
            return campaign;
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("Deleted campaign: " + campaign.Name);
        }
    }
}