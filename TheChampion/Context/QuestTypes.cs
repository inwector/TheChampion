using System;
using System.Collections.Generic;

namespace TheChampion.Context
{
    public partial class QuestTypes
    {
        public QuestTypes()
        {
            Quests = new HashSet<Quests>();
        }

        public int QuestTypeId { get; set; }
        public string Name { get; set; }
        public int StamCost { get; set; }
        public int GoldCost { get; set; }
        public int GoldReward { get; set; }
        public int ItemReward { get; set; }

        public virtual ICollection<Quests> Quests { get; set; }
    }
}
