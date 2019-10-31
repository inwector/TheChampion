using System;
using System.Collections.Generic;

namespace TheChampion.Context
{
    public partial class ItemProperties
    {
        public int ItemPropertyId { get; set; }
        public string Name { get; set; }
        public int ItemTypeId { get; set; }

        public virtual ItemTypes ItemType { get; set; }
    }
}
