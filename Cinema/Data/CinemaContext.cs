using Cinema.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Data
{
    internal class CinemaContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=cinema.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie { MovieId = 1, Title = "X-Men", TimePlayed = "14:00", AvailableSeats = 10 },
                new Movie { MovieId = 2, Title = "Titanic", TimePlayed = "18:00", AvailableSeats = 20 },
                new Movie { MovieId = 3, Title = "Mad Max", TimePlayed = "21:00", AvailableSeats = 30 },
                new Movie { MovieId = 4, Title = "Transformers", TimePlayed = "22:00", AvailableSeats = 40 });

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { ReservationId = 1, ReservationName = "Gal Anonim", MovieId = 1 },
                new Reservation { ReservationId = 2, ReservationName = "Gal Drugi", MovieId = 1 },
                new Reservation { ReservationId = 3, ReservationName = "Gal Trzeci", MovieId = 2 },
                new Reservation { ReservationId = 4, ReservationName = "Gal Czwarty", MovieId = 3});
        }
    }
}
