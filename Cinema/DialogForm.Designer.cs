namespace Cinema
{
    partial class DialogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nameLabel = new Label();
            nameTextBox = new TextBox();
            titleLabel = new Label();
            timeLabel = new Label();
            labelTime = new Label();
            titleTextBox = new TextBox();
            timeTextBox = new TextBox();
            okButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 83);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(141, 15);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name for the reservation:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 101);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(206, 23);
            nameTextBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(12, 13);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(32, 15);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(12, 38);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(78, 15);
            timeLabel.TabIndex = 4;
            timeLabel.Text = "Scheduled at:";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(105, 53);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(0, 15);
            labelTime.TabIndex = 5;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(50, 10);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.ReadOnly = true;
            titleTextBox.Size = new Size(168, 23);
            titleTextBox.TabIndex = 7;
            // 
            // timeTextBox
            // 
            timeTextBox.Location = new Point(96, 35);
            timeTextBox.Name = "timeTextBox";
            timeTextBox.ReadOnly = true;
            timeTextBox.Size = new Size(122, 23);
            timeTextBox.TabIndex = 8;
            // 
            // okButton
            // 
            okButton.Location = new Point(15, 143);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 9;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(143, 143);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 10;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // DialogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 178);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(timeTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(labelTime);
            Controls.Add(timeLabel);
            Controls.Add(titleLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Name = "DialogForm";
            Text = "DialogForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameTextBox;
        private Label titleLabel;
        private Label timeLabel;
        private Label labelTime;
        private TextBox titleTextBox;
        private TextBox timeTextBox;
        private Button okButton;
        private Button cancelButton;
    }
}