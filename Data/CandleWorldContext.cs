using Microsoft.EntityFrameworkCore;
using CandleWorld.Models;

namespace CandleWorld.Data
{
    public class CandleWorldContext : DbContext
    {
        public CandleWorldContext(DbContextOptions<CandleWorldContext> options)
            : base(options)
        {
        }

        public DbSet<Candle> Candle { get; set; }
    }
}