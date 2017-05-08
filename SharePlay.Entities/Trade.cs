using System;
using System.Collections.Generic;

namespace SharePlay.Entities
{
    public class Trade : BaseClass
    {
        public int TradeId { get; set; }

        public virtual List<Share> Shares { get; set; }

        public DateTime TradeDate { get; set; }

        public Portfolio Portfolio { get; set; }

        public int PortfolioId {get;set;}
    }
}