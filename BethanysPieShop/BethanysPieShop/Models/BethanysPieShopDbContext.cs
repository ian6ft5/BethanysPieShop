using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
    public class BethanysPieShopDbContext : DbContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Pie> Pies { get; set; }
    }
}
