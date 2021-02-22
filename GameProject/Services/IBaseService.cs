using System;
using GameProject.Entities;

namespace GameProject.Services
{
    public interface IBaseService
    {
        void Update(Entity entity);
        void Delete(Entity entity);
    }
}
