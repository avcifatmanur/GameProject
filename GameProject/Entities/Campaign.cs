using System;
using GameProject.Entities;
using GameProject.Services;

namespace GameProject
{
    public class Campaign:Entity

    {
        public string campaignName;
        public override string Name 
        {  
            set { base.Name = value; }
            get { return campaignName; }
        }
       
        public int campaignDisc { get; set; }

    }
}
