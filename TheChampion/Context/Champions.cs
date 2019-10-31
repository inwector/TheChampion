using System;
using System.Collections.Generic;

namespace TheChampion.Context
{
    public partial class Champions
    {
        public Champions()
        {
            ChampionQuests = new HashSet<ChampionQuests>();
        }

        public int ChampionId { get; set; }
        public int AccountId { get; set; }
        public string Name { get; set; }
        public bool? GenderId { get; set; }
        public int Age { get; set; }
        public int RaceId { get; set; }
        public int ClassId { get; set; }
        public int Lvl { get; set; }
        public int Experience { get; set; }
        public int Health { get; set; }
        public int Stamina { get; set; }
        public int Morale { get; set; }
        public int Gold { get; set; }

        public virtual Accounts Account { get; set; }
        public virtual ICollection<ChampionQuests> ChampionQuests { get; set; }
    }
}
