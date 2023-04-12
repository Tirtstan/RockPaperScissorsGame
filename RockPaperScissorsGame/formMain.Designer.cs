namespace RockPaperScissorsGame
{
    partial class formMain
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
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            buttonRock = new Button();
            buttonPaper = new Button();
            buttonScissors = new Button();
            labelPlayerChoice = new Label();
            labelComputerChoice = new Label();
            labelWinner1 = new Label();
            labelWinner2 = new Label();
            labelWinner3 = new Label();
            buttonClose = new Button();
            buttonPlayAgain = new Button();
            labelWinner4 = new Label();
            labelOverallWinner = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dwayne_rock;
            pictureBox1.Location = new Point(35, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 219);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.paper;
            pictureBox2.Location = new Point(321, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(220, 219);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.scissors;
            pictureBox3.Location = new Point(604, 26);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(220, 219);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // buttonRock
            // 
            buttonRock.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRock.Location = new Point(35, 264);
            buttonRock.Name = "buttonRock";
            buttonRock.Size = new Size(220, 50);
            buttonRock.TabIndex = 3;
            buttonRock.Text = "Rock";
            buttonRock.UseVisualStyleBackColor = true;
            buttonRock.Click += buttonRock_Click;
            // 
            // buttonPaper
            // 
            buttonPaper.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPaper.Location = new Point(321, 264);
            buttonPaper.Name = "buttonPaper";
            buttonPaper.Size = new Size(220, 50);
            buttonPaper.TabIndex = 4;
            buttonPaper.Text = "Paper";
            buttonPaper.UseVisualStyleBackColor = true;
            buttonPaper.Click += buttonPaper_Click;
            // 
            // buttonScissors
            // 
            buttonScissors.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonScissors.Location = new Point(604, 264);
            buttonScissors.Name = "buttonScissors";
            buttonScissors.Size = new Size(220, 50);
            buttonScissors.TabIndex = 5;
            buttonScissors.Text = "Scissors";
            buttonScissors.UseVisualStyleBackColor = true;
            buttonScissors.Click += buttonScissors_Click;
            // 
            // labelPlayerChoice
            // 
            labelPlayerChoice.AutoSize = true;
            labelPlayerChoice.Font = new Font("Segoe UI", 14F, FontStyle.Underline, GraphicsUnit.Point);
            labelPlayerChoice.Location = new Point(35, 331);
            labelPlayerChoice.Name = "labelPlayerChoice";
            labelPlayerChoice.Size = new Size(144, 25);
            labelPlayerChoice.TabIndex = 6;
            labelPlayerChoice.Text = "Player Selected:";
            // 
            // labelComputerChoice
            // 
            labelComputerChoice.AutoSize = true;
            labelComputerChoice.Font = new Font("Segoe UI", 14F, FontStyle.Underline, GraphicsUnit.Point);
            labelComputerChoice.Location = new Point(35, 366);
            labelComputerChoice.Name = "labelComputerChoice";
            labelComputerChoice.Size = new Size(176, 25);
            labelComputerChoice.TabIndex = 7;
            labelComputerChoice.Text = "Computer Selected:";
            // 
            // labelWinner1
            // 
            labelWinner1.AutoSize = true;
            labelWinner1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelWinner1.Location = new Point(35, 404);
            labelWinner1.Name = "labelWinner1";
            labelWinner1.Size = new Size(179, 25);
            labelWinner1.TabIndex = 8;
            labelWinner1.Text = "Winner of Game 1:";
            labelWinner1.Visible = false;
            // 
            // labelWinner2
            // 
            labelWinner2.AutoSize = true;
            labelWinner2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelWinner2.Location = new Point(35, 438);
            labelWinner2.Name = "labelWinner2";
            labelWinner2.Size = new Size(179, 25);
            labelWinner2.TabIndex = 9;
            labelWinner2.Text = "Winner of Game 2:";
            labelWinner2.Visible = false;
            // 
            // labelWinner3
            // 
            labelWinner3.AutoSize = true;
            labelWinner3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelWinner3.Location = new Point(35, 472);
            labelWinner3.Name = "labelWinner3";
            labelWinner3.Size = new Size(179, 25);
            labelWinner3.TabIndex = 10;
            labelWinner3.Text = "Winner of Game 3:";
            labelWinner3.Visible = false;
            // 
            // buttonClose
            // 
            buttonClose.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClose.Location = new Point(759, 525);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(109, 50);
            buttonClose.TabIndex = 11;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonPlayAgain
            // 
            buttonPlayAgain.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPlayAgain.Location = new Point(628, 525);
            buttonPlayAgain.Name = "buttonPlayAgain";
            buttonPlayAgain.Size = new Size(125, 50);
            buttonPlayAgain.TabIndex = 12;
            buttonPlayAgain.Text = "Play Again";
            buttonPlayAgain.UseVisualStyleBackColor = true;
            buttonPlayAgain.Click += buttonPlayAgain_Click;
            // 
            // labelWinner4
            // 
            labelWinner4.AutoSize = true;
            labelWinner4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelWinner4.Location = new Point(35, 508);
            labelWinner4.Name = "labelWinner4";
            labelWinner4.Size = new Size(179, 25);
            labelWinner4.TabIndex = 13;
            labelWinner4.Text = "Winner of Game 4:";
            labelWinner4.Visible = false;
            // 
            // labelOverallWinner
            // 
            labelOverallWinner.AutoSize = true;
            labelOverallWinner.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelOverallWinner.Location = new Point(35, 550);
            labelOverallWinner.Name = "labelOverallWinner";
            labelOverallWinner.Size = new Size(151, 25);
            labelOverallWinner.TabIndex = 14;
            labelOverallWinner.Text = "Overall Winner:";
            labelOverallWinner.Visible = false;
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 587);
            Controls.Add(labelOverallWinner);
            Controls.Add(labelWinner4);
            Controls.Add(buttonPlayAgain);
            Controls.Add(buttonClose);
            Controls.Add(labelWinner3);
            Controls.Add(labelWinner2);
            Controls.Add(labelWinner1);
            Controls.Add(labelComputerChoice);
            Controls.Add(labelPlayerChoice);
            Controls.Add(buttonScissors);
            Controls.Add(buttonPaper);
            Controls.Add(buttonRock);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "formMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rock, Paper, Scissors Game";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button buttonRock;
        private Button buttonPaper;
        private Button buttonScissors;
        private Label labelPlayerChoice;
        private Label labelComputerChoice;
        private Label labelWinner1;
        private Label labelWinner2;
        private Label labelWinner3;
        private Button buttonClose;
        private Button buttonPlayAgain;
        private Label labelWinner4;
        private Label labelOverallWinner;
    }
}