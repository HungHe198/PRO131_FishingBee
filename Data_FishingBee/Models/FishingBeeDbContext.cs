using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_FishingBee.Models
{
    public class FishingBeeDbContext : DbContext
    {
        public FishingBeeDbContext()
        {
            
        }
        public FishingBeeDbContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Role> Roles { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Supplier> Suppliers { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Cart> Carts { get; set; }
        DbSet<Cart_Product> Cart_Products { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductDetail> ProductDetail { get; set; }
        DbSet<Category> entities { get; set; }
        DbSet<BillDetail> Bills { get; set; }
        DbSet<BillDetail> BillDetails { get; set; }
        DbSet<DailyRevenue> DailyRevenues { get; set; }
        DbSet<WeekRevenue> WeekRevenues { get; set; }
        DbSet<MonthRevenue> MonthRevenues { get; set; }
        DbSet<ProductRevenue> ProductRevenues { get; set; }
        DbSet<CategoryRevenue> CategoryRevenues { get; set; }
        DbSet<Inventory> Inventories { get; set; }
        DbSet<Promotion> Promotions { get; set; }
        DbSet<PromotionDetail> PromotionDetails { get; set; }
        DbSet<WishList> WishLists { get; set; }
        DbSet<TransactionHistory> TransactionHistories { get; set; }
        DbSet<Coupon> Coupons { get; set; }
        DbSet<UserActivityLog> UserActivityLogs { get; set; }
        DbSet<CustomerSupport> CustomerSupports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LEVANHUNG\\LEVANHUNG;Initial Catalog=PRO131_FishingBee;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
    
}
