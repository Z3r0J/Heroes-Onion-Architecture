using HeroesOnionArchitecture.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HeroesOnionArchitecture.Infrastructure.Persistence.Contexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Universe> Universes { get; set; }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Quality> Qualities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Fluent API
            #region Tables
            modelBuilder.Entity<Hero>().ToTable("Heroes");
            modelBuilder.Entity<Quality>().ToTable("Qualities");
            modelBuilder.Entity<Universe>().ToTable("Universes");
            #endregion

            #region Primary Key
            modelBuilder.Entity<Hero>().HasKey(hero => hero.Id);
            modelBuilder.Entity<Quality>().HasKey(quality => quality.Id);
            modelBuilder.Entity<Universe>().HasKey(universe => universe.Id);
            #endregion

            #region Foreign Key
            modelBuilder.Entity<Universe>()
                .HasMany<Hero>(universe => universe.Heroes)
                .WithOne(hero => hero.Universe)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Quality>()
                .HasMany<Hero>(quality => quality.Heroes)
                .WithOne(hero => hero.Quality)
                .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region Properties Configuration

            #region Hero

            modelBuilder.Entity<Hero>()
                .Property(hero => hero.Name)
                .IsRequired();

            modelBuilder.Entity<Hero>()
                .Property(hero => hero.PhotoUrl)
                .IsRequired();

            #endregion

            #region Universe

            modelBuilder.Entity<Universe>()
                .Property(universe => universe.Name)
                .IsRequired();

            #endregion

            #region Quality

            modelBuilder.Entity<Quality>()
                .Property(quality => quality.Name)
                .IsRequired();

            #endregion

            #endregion
        }


    }
}
