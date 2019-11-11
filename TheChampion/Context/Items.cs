using System;
using System.Collections.Generic;

namespace TheChampion.Context
{
    public partial class Items
    {
        public int ItemId { get; set; }
        public int ItemTypeId { get; set; }
        public int ItemRarityId { get; set; }
        public string Name { get; set; }
        public int ChampionId { get; set; }
        public int? CommonProperty { get; set; }
        public int? CommonIntensity { get; set; }
        public int? RareProperty { get; set; }
        public int? RareIntensity { get; set; }
        public int? EpicProperty { get; set; }
        public int? EpicIntensity { get; set; }
        public int? LegendaryProperty { get; set; }
        public int? LegendaryIntensity { get; set; }

        public virtual ItemRarities ItemRarity { get; set; }
        public virtual ItemTypes ItemType { get; set; }
    }
}
