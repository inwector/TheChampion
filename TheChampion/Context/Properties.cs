using System;
using System.Collections.Generic;

namespace TheChampion.Context
{
    public partial class Properties
    {
        public int PropertyId { get; set; }
        public string Name { get; set; }
        public int? MaxValues { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
    }
}
