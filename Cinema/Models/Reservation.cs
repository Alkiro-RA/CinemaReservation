using System.ComponentModel;

namespace Cinema.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public string ReservationName { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; } = null!;
    }
}
