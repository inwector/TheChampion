using System;
using System.Collections.Generic;

namespace TheChampion.Context
{
    public partial class ItemRarities
    {
        public ItemRarities()
        {
            Items = new HashSet<Items>();
        }

        public int ItemRarityId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Items> Items { get; set; }
    }
}
