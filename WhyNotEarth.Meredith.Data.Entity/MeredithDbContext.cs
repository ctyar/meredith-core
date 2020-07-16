using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WhyNotEarth.Meredith.Data.Entity.Models;
using WhyNotEarth.Meredith.Data.Entity.Models.Modules.BrowTricks;
using WhyNotEarth.Meredith.Data.Entity.Models.Modules.Hotel;
using WhyNotEarth.Meredith.Data.Entity.Models.Modules.Shop;
using WhyNotEarth.Meredith.Data.Entity.Models.Modules.Volkswagen;
using Product = WhyNotEarth.Meredith.Data.Entity.Models.Product;
using ShoppingProduct = WhyNotEarth.Meredith.Data.Entity.Models.Modules.Shop.Product;

namespace WhyNotEarth.Meredith.Data.Entity
{
    public class MeredithDbContext : IdentityDbContext<User, Role, int>
    {
        // Public
        public DbSet<Card> Cards { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<ProductCategory> ProductCategories { get; set; } = null!;

        public DbSet<Company> Companies { get; set; } = null!;

        public DbSet<Image> Images { get; set; } = null!;

        public DbSet<Page> Pages { get; set; } = null!;

        public DbSet<SendGridAccount> SendGridAccounts { get; set; } = null!;

        public DbSet<StripeAccount> StripeAccounts { get; set; } = null!;

        public DbSet<StripeOAuthRequest> StripeOAuthRequests { get; set; } = null!;

        public DbSet<Keyword> Keywords { get; set; } = null!;

        public DbSet<Setting> Settings { get; set; } = null!;

        public DbSet<Email> Emails { get; set; } = null!;
        
        public DbSet<EmailEvent> EmailEvents { get; set; } = null!;

        // Shop
        public DbSet<Tenant> Tenants { get; set; } = null!;

        public DbSet<Reservation> Reservations { get; set; } = null!;

        public DbSet<Price> Prices { get; set; } = null!;

        public DbSet<Payment> Payments { get; set; } = null!;

        public DbSet<ShoppingProduct> ShoppingProducts { get; set; } = null!;

        public DbSet<Variation> Variations { get; set; } = null!;

        public DbSet<ProductAttribute> ProductAttributes { get; set; } = null!;

        public DbSet<ProductLocationInventory> ProductLocationInventories { get; set; } = null!;

        public DbSet<Location> Locations { get; set; } = null!;

        public DbSet<BusinessHour> BusinessHours { get; set; } = null!;

        // Remove in next steps
        public DbSet<Product> Products { get; set; } = null!;

        // Hotel
        public DbSet<Amenity> Amenities { get; set; } = null!;

        public DbSet<Bed> Beds { get; set; } = null!;

        public DbSet<Hotel> Hotels { get; set; } = null!;

        public DbSet<Language> Languages { get; set; } = null!;

        public DbSet<Room> Rooms { get; set; } = null!;

        public DbSet<RoomType> RoomTypes { get; set; } = null!;

        public DbSet<Rule> Rules { get; set; } = null!;

        public DbSet<Space> Spaces { get; set; } = null!;

        // Volkswagen
        public DbSet<Article> Articles { get; set; } = null!;

        public DbSet<JumpStart> JumpStarts { get; set; } = null!;

        public DbSet<Recipient> Recipients { get; set; } = null!;

        public DbSet<Memo> Memos { get; set; } = null!;

        public DbSet<NewJumpStart> NewJumpStarts { get; set; } = null!;

        // BrowTricks
        public DbSet<Client> Clients { get; set; } = null!;

        public MeredithDbContext(DbContextOptions<MeredithDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasPostgresExtension("uuid-ossp");
            
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeredithDbContext).Assembly);
        }
    }
}