using System;
using System.Collections.Generic;

namespace TheChampion.Context
{
    public partial class ChampionPassives
    {
        public int PassiveId { get; set; }
        public string Name { get; set; }
        public int PropertyId { get; set; }
        public int Amount { get; set; }
    }
}
