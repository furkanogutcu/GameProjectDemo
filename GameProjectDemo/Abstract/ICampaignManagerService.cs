using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstract
{
    interface ICampaignManagerService
    {
        Campaign AddCampaign(int id, string name, int discountRate);
        Campaign UpdateCampaignDiscountRate(Campaign campaign, int discountRate);
        void DeleteCampaign(Campaign campaign);
    }
}
