using System;
using System.Collections.Generic;

namespace TheChampion.Context
{
    public partial class ChampionQuests
    {
        public int ChampionQuestId { get; set; }
        public int QuestId { get; set; }
        public int ChampionId { get; set; }
        public DateTime QuestDate { get; set; }
        public bool? IsSuccessful { get; set; }

        public virtual Champions Champion { get; set; }
        public virtual Quests Quest { get; set; }
    }
}
