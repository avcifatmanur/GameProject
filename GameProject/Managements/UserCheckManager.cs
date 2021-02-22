using System;
using GameProject.Entities;
using GameProject.Services;
using MernisServiceReference;

namespace GameProject.Managements
{
    public class UserCheckManager:IUserCheckService

    { 
        public bool CheckIfRealPerson(User user)
        { 

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(
                    user.tcNo,user.firstName,user.lastName,user.birthDateYear).
                    Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
