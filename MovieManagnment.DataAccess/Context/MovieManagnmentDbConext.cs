using Microsoft.EntityFrameworkCore;
using MovieManagnment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagnment.DataAccess.Context
{
    public class MovieManagnmentDbConext : DbContext
    {
        public MovieManagnmentDbConext(DbContextOptions<MovieManagnmentDbConext> options): base(options)
        {
        
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Biography> Biographies  { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasData(
                new Actor {Id=1,FirstName="Asad",LastName="Ali" },
                new Actor {Id=2,FirstName="Usama",LastName="Usman" },
                new Actor {Id=33,FirstName="Ali",LastName="Umar" }
              
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Name = "vdfv", Description = "ekqwbe;of",ActorId=1},
                new Movie { Id = 2, Name = "vdfvdl", Description = "wdwckwb", ActorId = 1},
                new Movie { Id = 3, Name = "thrwt", Description = "eougroeb", ActorId = 2 },
                new Movie { Id = 4, Name = "tdveqrgt", Description = "ym53ytrf", ActorId = 2 }
            );
        }
    }
}
