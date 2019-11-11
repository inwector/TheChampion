using System;
using System.Collections.Generic;

namespace TheChampion.Context
{
    public partial class ChampionSkills
    {
        public ChampionSkills()
        {
            ItemTypes = new HashSet<ItemTypes>();
        }

        public int SkillId { get; set; }
        public string Name { get; set; }
        public int? SkillTypeId { get; set; }

        public virtual SkillTypes SkillType { get; set; }
        public virtual ICollection<ItemTypes> ItemTypes { get; set; }
    }
}
