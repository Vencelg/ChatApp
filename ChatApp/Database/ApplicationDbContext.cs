using ChatApp.Model;
using Microsoft.EntityFrameworkCore;

namespace ChatApp.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ChatRoom> ChatRooms { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=chat_app_db;Port=5432;Username=postgres;Password=postgres;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure your model relationships and other settings here
            modelBuilder.Entity<ChatRoom>()
                .HasMany(c => c.Users)
                .WithMany(u => u.ChatRooms)
                .UsingEntity(j => j.ToTable("ChatRoomUsers"));

            modelBuilder.Entity<ChatRoom>()
                .HasMany(c => c.Messages)
                .WithOne(m => m.ChatRoom)
                .HasForeignKey(m => m.ChatRoomId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Messages)
                .WithOne(m => m.User)
                .HasForeignKey(m => m.UserId);
        }
    }
}

