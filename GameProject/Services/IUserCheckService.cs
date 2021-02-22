using System;
using GameProject.Entities;

namespace GameProject.Services
{
    public interface IUserCheckService
    {
        bool CheckIfRealPerson(User user);
    }
}
