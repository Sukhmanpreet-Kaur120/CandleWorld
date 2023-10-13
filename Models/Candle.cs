using System;
using System.ComponentModel.DataAnnotations;

namespace CandleWorld.Models
{
    public class Candle
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Tradingdate { get; set; }
        public string Fragrance { get; set; }
        public string Wax { get; set; }
        public decimal Price { get; set; }
    }
}
