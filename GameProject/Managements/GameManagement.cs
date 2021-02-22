using System;
using GameProject.Entities;
using GameProject.Services;

namespace GameProject.Managements
{
    public class GameManagement : BaseManager
    {
        public void Add(Game game)
        {
            Console.WriteLine("{0} oyunu eklendi!",game.Name);
        }
        
    }
}
