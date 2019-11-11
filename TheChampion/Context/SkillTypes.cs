using System;
using System.Collections.Generic;

namespace TheChampion.Context
{
    public partial class SkillTypes
    {
        public SkillTypes()
        {
            ChampionSkills = new HashSet<ChampionSkills>();
        }

        public int SkillTypeId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ChampionSkills> ChampionSkills { get; set; }
    }
}
