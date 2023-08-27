using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaiterService.Domain.Entities;

namespace WaiterService.Infra.Context
{
    public class MyContext: DbContext
    {
            public DbSet<Order> Orders { get; set; }
            public DbSet<Table> Tables { get; set; }
            public DbSet<OrderCard> OrderCards { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Order>()
                    .HasOne(p => p.Table)
                    .WithMany(m => m.Order)
                    .HasForeignKey(p => p.TableId);

                modelBuilder.Entity<Order>()
                    .HasOne(p => p.Products)
                    .WithMany()
                    .HasForeignKey(p => p.Products);

                modelBuilder.Entity<OrderCard>()
                    .HasOne(c => c.Table)
                    .WithOne(m => m.OrderCard)
                    .HasForeignKey<OrderCard>(c => c.TableId);

                modelBuilder.Entity<OrderCard>()
                    .HasMany(c => c.Orders)
                    .WithOne(p => p.OrderCard)
                    .HasForeignKey(p => p.Id);
            }
        

    }
}
