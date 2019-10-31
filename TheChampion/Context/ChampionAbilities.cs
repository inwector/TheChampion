using System;
using System.Collections.Generic;

namespace TheChampion.Context
{
    public partial class ChampionAbilities
    {
        public int AbilityId { get; set; }
        public string Name { get; set; }
        public int PrimarySkillReqId { get; set; }
        public int PrimarySkillReqAmount { get; set; }
        public int? SecondarySkillReqId { get; set; }
        public int? SecondarySkillReqAmount { get; set; }
        public TimeSpan Duration { get; set; }
        public int StaminaCost { get; set; }
        public int EffectedPropertyId { get; set; }
        public int EffectedPropertyAmount { get; set; }
    }
}
