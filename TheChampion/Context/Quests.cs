using System;
using System.Collections.Generic;

namespace TheChampion.Context
{
    public partial class Quests
    {
        public Quests()
        {
            ChampionQuests = new HashSet<ChampionQuests>();
        }

        public int QuestId { get; set; }
        public int QuestTypeId { get; set; }
        public int EnemyTypeId { get; set; }
        public string Name { get; set; }
        public int Time { get; set; }
        public int LevelReq { get; set; }
        public int AngerRate { get; set; }
        public int Difficulty { get; set; }
        public int? StaminaCost { get; set; }

        public virtual QuestTypes QuestType { get; set; }
        public virtual ICollection<ChampionQuests> ChampionQuests { get; set; }
    }
}
