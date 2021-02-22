using System;
using GameProject.Entities;
using GameProject.Services;

namespace GameProject.Managements
{
    public class SalesManager
    {
        public void SaleGame(Sale sale)
        {
            Console.WriteLine("{0} isimli oyuncu {1} oyununu {2} tl'ye satın aldı!",
                sale.user.firstName, sale.game.Name, sale.game.price);
        }
        public void CampaignSales(Campaign campaign,Sale sale)
        {
            Console.WriteLine("{0} oyununda {1} kampanyası ile %{2} indirimi bulunmaktadır."
                ,sale.game.Name,campaign.Name,campaign.campaignDisc);
        }
    }
}
