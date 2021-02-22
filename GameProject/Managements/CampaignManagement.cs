using System;
using GameProject.Entities;
using GameProject.Services;

namespace GameProject.Managements
{
    public class CampaignManagement : BaseManager
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("{0} kampanyası eklendi!",campaign.Name);
        }
    }
}
