using Microsoft.EntityFrameworkCore;
using MoviesEtickets.Models;

namespace MoviesEtickets.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().
                HasKey(am => new {am.ActorId, am.MovieId});

            modelBuilder.Entity<Actor_Movie>()
                .HasOne(n => n.Actor)
                .WithMany(a => a.Actors_Movies)
                .HasForeignKey(n => n.ActorId);
            modelBuilder.Entity<Actor_Movie>()
                .HasOne(m => m.Movie)
                .WithMany(b => b.Actors_Movies)
                .HasForeignKey(m => m.MovieId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
