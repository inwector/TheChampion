using System;
using System.Collections.Generic;

namespace TheChampion.Context
{
    public partial class ChampionDuelLogs
    {
        public int ChampionDuelLogId { get; set; }
        public int RoundNumber { get; set; }
        public int ChampionId1 { get; set; }
        public int ChampionId2 { get; set; }
        public decimal Damage { get; set; }
    }
}
