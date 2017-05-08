using System;
using System.Collections.Generic;

namespace SharePlay.Entities
{
    public enum AccountStatusEnum
    {
        Active,
        InActive
    }

    public class Account: BaseClass
    {
        public int AccountId { get; set; }

        public string AccountName { get; set; }

        public string Owner { get; set; }

        public AccountStatusEnum AccountStatus { get; set; }

        public List<Portfolio> Portfolios { get; set; }
    }
}
