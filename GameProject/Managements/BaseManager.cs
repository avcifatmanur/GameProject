using System;
using GameProject.Entities;
using GameProject.Services;

namespace GameProject.Managements
{
    public abstract class BaseManager : IBaseService

    {

        public virtual void Delete(Entity entity)
        {
            Console.WriteLine("{0} Silindi!",entity.Name);
        }


        public virtual void Update(Entity entity)
        {
            Console.WriteLine("{0} Güncellendi!",entity.Name);
        }
    }
}
