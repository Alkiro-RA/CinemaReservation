namespace Cinema
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            saveButton = new Button();
            dataGridViewMovies = new DataGridView();
            movieIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timePlayedDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            availableSeatsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            movieBindingSource = new BindingSource(components);
            label1 = new Label();
            reservationButton = new Button();
            dataGridViewReservations = new DataGridView();
            reservationsBindingSource = new BindingSource(components);
            label2 = new Label();
            reservationIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reservationNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movieBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reservationsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(saveButton);
            splitContainer1.Panel1.Controls.Add(dataGridViewMovies);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(reservationButton);
            splitContainer1.Panel2.Controls.Add(dataGridViewReservations);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(722, 421);
            splitContainer1.SplitterDistance = 405;
            splitContainer1.TabIndex = 0;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Segoe UI", 10F);
            saveButton.Location = new Point(12, 382);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(130, 27);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save Repertoire";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // dataGridViewMovies
            // 
            dataGridViewMovies.AutoGenerateColumns = false;
            dataGridViewMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMovies.Columns.AddRange(new DataGridViewColumn[] { movieIdDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, timePlayedDataGridViewTextBoxColumn, availableSeatsDataGridViewTextBoxColumn });
            dataGridViewMovies.DataSource = movieBindingSource;
            dataGridViewMovies.Location = new Point(12, 33);
            dataGridViewMovies.Name = "dataGridViewMovies";
            dataGridViewMovies.Size = new Size(390, 328);
            dataGridViewMovies.TabIndex = 1;
            dataGridViewMovies.SelectionChanged += dataGridViewMovies_SelectionChanged;
            // 
            // movieIdDataGridViewTextBoxColumn
            // 
            movieIdDataGridViewTextBoxColumn.DataPropertyName = "MovieId";
            movieIdDataGridViewTextBoxColumn.HeaderText = "MovieId";
            movieIdDataGridViewTextBoxColumn.Name = "movieIdDataGridViewTextBoxColumn";
            movieIdDataGridViewTextBoxColumn.ReadOnly = true;
            movieIdDataGridViewTextBoxColumn.Width = 60;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.Width = 112;
            // 
            // timePlayedDataGridViewTextBoxColumn
            // 
            timePlayedDataGridViewTextBoxColumn.DataPropertyName = "TimePlayed";
            timePlayedDataGridViewTextBoxColumn.HeaderText = "TimePlayed";
            timePlayedDataGridViewTextBoxColumn.Name = "timePlayedDataGridViewTextBoxColumn";
            timePlayedDataGridViewTextBoxColumn.Width = 75;
            // 
            // availableSeatsDataGridViewTextBoxColumn
            // 
            availableSeatsDataGridViewTextBoxColumn.DataPropertyName = "AvailableSeats";
            availableSeatsDataGridViewTextBoxColumn.HeaderText = "AvailableSeats";
            availableSeatsDataGridViewTextBoxColumn.Name = "availableSeatsDataGridViewTextBoxColumn";
            // 
            // movieBindingSource
            // 
            movieBindingSource.DataSource = typeof(Models.Movie);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(175, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 0;
            label1.Text = "Movies";
            // 
            // reservationButton
            // 
            reservationButton.Font = new Font("Segoe UI", 10F);
            reservationButton.Location = new Point(171, 382);
            reservationButton.Name = "reservationButton";
            reservationButton.Size = new Size(130, 27);
            reservationButton.TabIndex = 3;
            reservationButton.Text = "Make Reservation";
            reservationButton.UseVisualStyleBackColor = true;
            reservationButton.Click += reservationButton_Click;
            // 
            // dataGridViewReservations
            // 
            dataGridViewReservations.AutoGenerateColumns = false;
            dataGridViewReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservations.Columns.AddRange(new DataGridViewColumn[] { reservationIdDataGridViewTextBoxColumn, reservationNameDataGridViewTextBoxColumn });
            dataGridViewReservations.DataSource = reservationsBindingSource;
            dataGridViewReservations.Location = new Point(3, 33);
            dataGridViewReservations.Name = "dataGridViewReservations";
            dataGridViewReservations.Size = new Size(298, 328);
            dataGridViewReservations.TabIndex = 2;
            // 
            // reservationsBindingSource
            // 
            reservationsBindingSource.DataMember = "Reservations";
            reservationsBindingSource.DataSource = movieBindingSource;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(115, 9);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 1;
            label2.Text = "Reservations";
            // 
            // reservationIdDataGridViewTextBoxColumn
            // 
            reservationIdDataGridViewTextBoxColumn.DataPropertyName = "ReservationId";
            reservationIdDataGridViewTextBoxColumn.HeaderText = "ReservationId";
            reservationIdDataGridViewTextBoxColumn.Name = "reservationIdDataGridViewTextBoxColumn";
            reservationIdDataGridViewTextBoxColumn.ReadOnly = true;
            reservationIdDataGridViewTextBoxColumn.Width = 85;
            // 
            // reservationNameDataGridViewTextBoxColumn
            // 
            reservationNameDataGridViewTextBoxColumn.DataPropertyName = "ReservationName";
            reservationNameDataGridViewTextBoxColumn.HeaderText = "ReservationName";
            reservationNameDataGridViewTextBoxColumn.Name = "reservationNameDataGridViewTextBoxColumn";
            reservationNameDataGridViewTextBoxColumn.ReadOnly = true;
            reservationNameDataGridViewTextBoxColumn.Width = 170;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 421);
            Controls.Add(splitContainer1);
            Name = "MainForm";
            Text = "Cinema";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).EndInit();
            ((System.ComponentModel.ISupportInitialize)movieBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservations).EndInit();
            ((System.ComponentModel.ISupportInitialize)reservationsBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridViewMovies;
        private Label label1;
        private Button reservationButton;
        private DataGridView dataGridViewReservations;
        private Label label2;
        private DataGridViewTextBoxColumn movieIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timePlayedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn availableSeatsDataGridViewTextBoxColumn;
        private BindingSource movieBindingSource;
        private BindingSource reservationsBindingSource;
        private Button saveButton;
        private DataGridViewTextBoxColumn reservationIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reservationNameDataGridViewTextBoxColumn;
    }
}
