using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CandleWorld.Data;
using System;
using System.Linq;

namespace CandleWorld.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CandleWorldContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CandleWorldContext>>()))
            {
                // Look for any movies.
                if (context.Candle.Any())
                {
                    return;   // DB has been seeded
                }

                context.Candle.AddRange(
                    new Candle
                    {
                        Name = "Roseline",
                        Tradingdate = DateTime.Parse("2023-2-12"),
                        Fragrance = "Rose",
                        Wax = "beeswax",
                        Price = 19.58m
                    },

                    new Candle
                    {
                        Name = "Roseline",
                        Tradingdate = DateTime.Parse("2023-11-15"),
                        Fragrance = "Rose",
                        Wax = "beeswax",
                        Price = 19.58m
                    },

                    new Candle
                    {
                        Name = "Roseline",
                        Tradingdate = DateTime.Parse("2023-109-16"),
                        Fragrance = "Rose",
                        Wax = "beeswax",
                        Price = 19.58m
                    },

                    new Candle
                    {
                        Name = "Roseline",
                        Tradingdate = DateTime.Parse("2023-11-11"),
                        Fragrance = "Rose",
                        Wax = "beeswax",
                        Price = 19.58m
                    },

                    new Candle
                    {
                        Name = "Roseline",
                        Tradingdate = DateTime.Parse("2023-08-10"),
                        Fragrance = "Rose",
                        Wax = "beeswax",
                        Price = 19.58m
                    },

                    new Candle
                    {
                        Name = "Roseline",
                        Tradingdate = DateTime.Parse("2023-04-15"),
                        Fragrance = "Rose",
                        Wax = "",
                        Price = 19.58m
                    },

                    new Candle
                    {
                        Name = "Roseline",
                        Tradingdate = DateTime.Parse("2023-06-13"),
                        Fragrance = "Rose",
                        Wax = "Sperm Whale",
                        Price = 19.58m
                    },

                    new Candle
                    {
                        Name = "Roseline",
                        Tradingdate = DateTime.Parse("2023-11-15"),
                        Fragrance = "Rose",
                        Wax = "beeswax",
                        Price = 19.58m
                    },

                    new Candle
                    {
                        Name = "",
                        Tradingdate = DateTime.Parse("2023-11-15"),
                        Fragrance = "Rose",
                        Wax = "Tallow",
                        Price = 19.58m
                    },

                    new Candle
                    {
                        Name = "Roseline",
                        Tradingdate = DateTime.Parse("2023-11-15"),
                        Fragrance = "Rose",
                        Wax = "beeswax",
                        Price = 19.58m
                    }

                );
                context.SaveChanges();
            }
        }
    }
}