using API.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class StoreContext(DbContextOptions options) : IdentityDbContext<User>(options)
{
    public required DbSet<Product> Products { get; set; }
    public required DbSet<Basket> Baskets { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRole>()
            .HasData(
                new IdentityRole { Id = "5c04e059-edc2-4a50-b4f5-5370d6fef8c4", Name = "Member", NormalizedName = "MEMBER" },
                new IdentityRole { Id = "9914e2d8-0ed8-4afc-916e-07550d73a9a2", Name = "Admin", NormalizedName = "ADMIN" }
            );
    }
}
