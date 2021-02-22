using System;
using GameProject.Entities;
using GameProject.Managements;
using GameProject.Services;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oyuncular oluşturuldu ve mernis kontrolü yapılıp eklendi.
            //isim,soyisim,doğumyılı,tcNo doğru girildiğinde çalışıyor.
            User user1 = new User
            {
                firstName = "Elife",
                lastName = "Avcı",
                tcNo=10426,
                birthDateYear=1970,
                
            };
            UserManagement userManagement=new UserManagement(new UserCheckManager());

            User user2 = new User
            {
                firstName = "Feyzi",
                lastName = "Avcı",
                tcNo=10664,
                birthDateYear=1973
            };
            userManagement.Add(user1);
            userManagement.Add(user2);


            //Oyunlar oluşturuldu.Ekleme,silme ve güncelleme işlemleri yapıldı.
            Game game1 = new Game
            {
                gameName="Need For Speed",
                price=199
            };
            Game game2 = new Game 
            {
                gameName = "GTA5",
                price = 349
            };

            GameManagement gameManagement = new GameManagement();
            gameManagement.Add(game1);
            gameManagement.Add(game2);
            gameManagement.Update(game1);
            gameManagement.Delete(game2);

            //Kampanyalar oluşturuldu.Ekleme,silme, güncelleme işlemleri yapıldı.
            Campaign campaign1 = new Campaign {
                campaignName = "Büyük Fırsat",
                campaignDisc = 80,
            };
            Campaign campaign2 = new Campaign {
                campaignName = "Yüzde Elli",
                campaignDisc = 50,
            };

            CampaignManagement campaignManagent = new CampaignManagement();
            campaignManagent.Add(campaign1);
            campaignManagent.Add(campaign2);
            gameManagement.Update(campaign2);
            gameManagement.Delete(campaign1);

            //Satışları yapılan oyunlar ve satışa ait bilgiler yazdırıldı.
            Sale sales1 = new Sale() 
            {
                game = game1,
                user = user2   
            };

            Sale sales2 = new Sale() {
                game = game2,
                user = user1
            };
            SalesManager salesManager = new SalesManager();
            salesManager.SaleGame(sales1);
            salesManager.CampaignSales(campaign2, sales1);
            salesManager.SaleGame(sales2);
            salesManager.CampaignSales(campaign1, sales2);

            Console.ReadKey();

            
        }
    }
}
