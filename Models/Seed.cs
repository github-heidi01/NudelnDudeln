using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NudelnDudeln.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace NudelnDudeln.Models
{
    public static class Seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                if (!context.Currency.Any())
                {
                    context.Currency.Add(new CurrencyUnit { UnitName = "EUR" });
                }

                if (!context.FoodUnit.Any())
                {
                    context.AddRange(
                        new FoodUnit { UnitName = "g" },
                        new FoodUnit { UnitName = "kg" },
                        new FoodUnit { UnitName = "ml" },
                        new FoodUnit { UnitName = "l" }
                    );
                }
                context.SaveChanges();
                return;
            }
        }
    }
}
