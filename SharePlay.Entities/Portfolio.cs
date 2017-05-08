using System;
using System.Collections.Generic;
using System.Text;

namespace SharePlay.Entities
{

    public enum PortfolioStatusEnum
    {
        Active,
        InActive
    }

    public class Portfolio: BaseClass
    {
        public int PortfolioId { get; set; }

        public string Name { get; set; }
        public virtual List<Trade> Trades { get; set; }

        public PortfolioStatusEnum PortfolioStatus { get; set; }

        public Account Account { get; set; }
        public int AccountId { get; set; }
    }
}
