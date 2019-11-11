using System;
using System.Collections.Generic;

namespace TheChampion.Context
{
    public partial class ChampionRaces
    {
        public int RaceId { get; set; }
        public string Name { get; set; }
        public int PrimarySkillId { get; set; }
        public int? SecondarySkillId { get; set; }
        public int PassiveId { get; set; }
    }
}
