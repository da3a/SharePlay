namespace SharePlay.Entities
{
    public class Share : BaseClass
    {
        public int ShareId { get; set; }

        public string Stock { get; set; }
        public decimal Price { get; set; }

        public Trade Trade { get; set; }

        public int TradeId { get; set; } 

    }
}