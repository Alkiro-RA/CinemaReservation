using System.ComponentModel;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Cinema.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string? TimePlayed { get; set; }
        public int AvailableSeats { get; set; }

        public virtual ObservableCollectionListSource<Reservation> Reservations { get; } = new();
    }
}