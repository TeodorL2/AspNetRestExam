using Examen.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Examen.Data
{
    public class ExamenContext : DbContext
    {
        public DbSet<Film> Filme { get; set; }
        public DbSet<Actor> Actori { get; set; }
        public DbSet<FilmActor> FilmActori { get; set; }

        public ExamenContext(DbContextOptions<ExamenContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FilmActor>()
                        .HasOne(fa => fa.Actor)
                        .WithMany(a => a.FilmActori)
                        .HasForeignKey(fa => fa.IdActor);

            modelBuilder.Entity<FilmActor>()
                        .HasOne(fa => fa.Film)
                        .WithMany(f => f.FilmActori)
                        .HasForeignKey(fa => fa.IdFilm);

            modelBuilder.Entity<FilmActor>().HasKey(fa => new { fa.IdFilm, fa.IdActor });

            base.OnModelCreating(modelBuilder);
        }
    }
}
