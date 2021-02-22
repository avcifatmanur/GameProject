using System;
using GameProject.Services;

namespace GameProject.Entities
{
    public class Game:Entity

    {
        public string gameName;
        public override string Name 
        {
            set { base.Name = value; }
            get { return gameName; }
        }
        public int price { get; set; }

    }
}
