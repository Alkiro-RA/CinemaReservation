using Cinema.Data;
using Cinema.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Cinema
{
    public partial class MainForm : Form
    {
        private CinemaContext context;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.context = new CinemaContext();

            /* Uncomment the line below to start fresh with a new database.
            this.dbContext.Database.EnsureDeleted(); */

            this.context.Database.EnsureCreated();

            this.context.Movies.Load();

            this.movieBindingSource.DataSource = context.Movies.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.context?.Dispose();
            this.context = null;
        }

        private void dataGridViewMovies_SelectionChanged(object sender, EventArgs e)
        {
            if (this.context != null)
            {
                var movies = (Movie)this.dataGridViewMovies.CurrentRow.DataBoundItem;
                if (movies != null)
                {
                    this.context.Entry(movies).Collection(e => e.Reservations).Load();
                }
            }
        }

        private void reservationButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewMovies.SelectedCells.Count < 0 || dataGridViewMovies.CurrentRow.Equals(null))   // do poprawy
            {
                MessageBox.Show("Mark a movie you want to book a reservation for.");
            }
            else
            {
                // przejmij info o wybranym filmie
                var currentRow = dataGridViewMovies.CurrentRow;
                var movie = new Movie();
                try
                {
                    movie = new Movie
                    {
                        MovieId = int.Parse(currentRow.Cells[0].Value.ToString()),
                        Title = currentRow.Cells[1].Value.ToString(),
                        TimePlayed = currentRow.Cells[2].Value.ToString(),
                        AvailableSeats = int.Parse(currentRow.Cells[3].Value.ToString())
                    };
                }
                catch (Exception)
                {
                    MessageBox.Show("Retriving movie data failed.");
                }

                using (var newDialogForm = new DialogForm(movie, this.context))
                {
                    var result = newDialogForm.ShowDialog();
                    switch (result)
                    {
                        // zatwierdŸ rezerwacje
                        case DialogResult.OK:
                            {
                                // zaktualizuj liczbe miejsc
                                MessageBox.Show("Reservation made.");
                                break;
                            }
                        // anuluj rezerwacje
                        case DialogResult.Cancel:
                            {
                                MessageBox.Show("Reservation canceled.");
                                break;
                            }
                        // abort = default
                        default:
                            {
                                MessageBox.Show("Reservation error.");
                                break;
                            }
                    }
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.context!.SaveChanges();

            this.dataGridViewMovies.Refresh();
            this.dataGridViewReservations.Refresh();
        }
    }
}
