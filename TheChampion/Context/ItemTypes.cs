using System;
using System.Collections.Generic;

namespace TheChampion.Context
{
    public partial class ItemTypes
    {
        public ItemTypes()
        {
            ItemProperties = new HashSet<ItemProperties>();
            Items = new HashSet<Items>();
        }

        public int ItemTypeId { get; set; }
        public string Name { get; set; }
        public int SkillId { get; set; }
        public int ItemSlotId { get; set; }
        public int? DamageTypeId { get; set; }
        public int? MinDamage { get; set; }
        public int? MaxDamage { get; set; }
        public int? Speed { get; set; }

        public virtual ItemSlots ItemSlot { get; set; }
        public virtual ChampionSkills Skill { get; set; }
        public virtual ICollection<ItemProperties> ItemProperties { get; set; }
        public virtual ICollection<Items> Items { get; set; }
    }
}
