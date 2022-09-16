using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext (DbContextOptions <AppDbContext> options) : base(options)
        {

        }

        //for Many_to_Many Relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Actor_Movie
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new { am.ActorID, am.MovieID });
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieID);
            modelBuilder.Entity<Actor_Movie>().HasOne(a => a.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(a => a.ActorID);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ActorModel> Actors { get; set; }
        public DbSet<MovieModel> Movies { get; set; }
        public DbSet<Actor_Movie> Actor_Movies { get; set; }
        public DbSet<CInemaModels> CInemaModels { get; set; }
        public DbSet<ProducerModel> ProducerModels { get; set; }
    }
}
