using System;
using System.Collections.Generic;

namespace TheChampion.Context
{
    public partial class ChampionClasses
    {
        public int ClassId { get; set; }
        public string Name { get; set; }
        public int PrimaryClassSkillId { get; set; }
        public int SecondaryClassSkillId { get; set; }
        public int AbilityId { get; set; }
    }
}
