using System;
using System.Collections.Generic;

namespace TheChampion.Context
{
    public partial class ItemSlots
    {
        public ItemSlots()
        {
            ItemTypes = new HashSet<ItemTypes>();
        }

        public int ItemSlotId { get; set; }
        public string SlotName { get; set; }

        public virtual ICollection<ItemTypes> ItemTypes { get; set; }
    }
}
