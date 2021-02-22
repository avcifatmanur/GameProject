using System;
using GameProject.Entities;
using GameProject.Services;

namespace GameProject.Managements
{
    public class UserManagement : BaseManager

    {
        public IUserCheckService _userCheckService;
        public UserManagement(IUserCheckService userCheckService)
        {
            _userCheckService = userCheckService;
        }
        public void Add(User user)
        {
            Console.WriteLine("-----------KİMLİK DOĞRULAMA-----------");
            if (_userCheckService.CheckIfRealPerson(user))
            {
                Console.WriteLine("{0} Eklendi!",user.firstName);
            }
            else {
                Console.WriteLine("{0} Eklenemedi!", user.firstName);
            }
        }        
    }
}
