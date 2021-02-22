using System;
using GameProject.Entities;
using GameProject.Services;

namespace GameProject
{
    public class User:Entity
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public long tcNo { get; set; }
        public int birthDateYear { get; set; }
        public string password { get; set; }

    }
}
