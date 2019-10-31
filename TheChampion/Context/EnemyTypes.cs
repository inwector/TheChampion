using System;
using System.Collections.Generic;

namespace TheChampion.Context
{
    public partial class EnemyTypes
    {
        public int EnemyTypeId { get; set; }
        public string EnemyTypeName { get; set; }
        public int Health { get; set; }
        public int Morale { get; set; }
        public int Armor { get; set; }
        public int WeaknessId { get; set; }
        public decimal WeaknessMultiplier { get; set; }
        public int? MinDamage { get; set; }
        public int? MaxDamage { get; set; }
        public int? DamageTypeId { get; set; }
        public int Speed { get; set; }
    }
}
