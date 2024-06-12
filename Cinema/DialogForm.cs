using Cinema.Data;
using Cinema.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class DialogForm : Form
    {
        private readonly CinemaContext context;
        private readonly int movieId;
        private readonly int availableSeats; 
        internal DialogForm(Movie movie, CinemaContext context)
        {
            InitializeComponent();
            this.context = context;
            this.movieId = movie.MovieId;
            this.availableSeats = movie.AvailableSeats;
            titleTextBox.Text = movie.Title;
            timeTextBox.Text = movie.TimePlayed;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // nazwa nie może być pusta
            if (nameTextBox == null)
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
                return;
            }
            // jak dostępne miejsca spadną do 0 to nie pozwól na rezerwację
            if (availableSeats <= 0)
            {
                MessageBox.Show("All sits sold out, sorry!");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            // przygtouj obiekt rezerwacji
            var reservation = new Reservation
            {
                ReservationName = nameTextBox.Text,
                MovieId = movieId,
            };
            // dodaj rezerwacje do bazy
            context.Reservations.Add(reservation);

            // zapisz zmiany
            context.SaveChanges();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
