using System;
using System.Collections.Generic;

namespace TheChampion.Context
{
    public partial class Accounts
    {
        public Accounts()
        {
            Champions = new HashSet<Champions>();
        }

        public int AccountId { get; set; }
        public string LoginName { get; set; }
        public string LoginPassword { get; set; }
        public string Email { get; set; }
        public string FacebookId { get; set; }
        public string GooglePlayId { get; set; }
        public string AppleStoreId { get; set; }
        public bool IsDonor { get; set; }

        public virtual ICollection<Champions> Champions { get; set; }
    }
}
