namespace RockPaperScissorsGame
{
    public partial class formMain : Form
    {
        private enum Choice // enum for all possible choices for the game
        {
            Rock = 0,
            Paper = 1,
            Scissors = 2,
        }

        private enum GameOutcome // all possible results from the game
        {
            PlayerWins = 0,
            ComputerWins = 1,
            Draw = 2,
        }

        private Label[] labelWinners = new Label[4]; // array of labels for game history
        private int playerScore = 0;
        private int computerScore = 0;
        private int gameCount = -1; // counter to track the amount of games (useful for labelWinners and ending the game)

        public formMain()
        {
            InitializeComponent();
        }

        private void buttonRock_Click(object sender, EventArgs e)
        {
            StartGame(Choice.Rock); // starts game with rock choice
        }

        private void buttonPaper_Click(object sender, EventArgs e)
        {
            StartGame(Choice.Paper); // starts game with paper choice
        }

        private void buttonScissors_Click(object sender, EventArgs e)
        {
            StartGame(Choice.Scissors); // starts game with scissors choice
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); // closes application
        }

        private void StartGame(Choice playerChoice) // method to start the game
        {
            labelWinners = new Label[4] { labelWinner1, labelWinner2, labelWinner3, labelWinner4 }; // creates an array of all game history labels
            gameCount++; // tracks game round

            Random random = new Random();
            Choice computerChoice = (Choice)random.Next(0, 3); /* randomly generates computer's choice between 0 and 2 and casts it
            into the Choice enum */

            labelComputerChoice.Text = "Computer Selected: " + computerChoice; // outputs computer's choice
            labelPlayerChoice.Text = "Player Selected: " + playerChoice; // outputs the player's choice

            labelWinners[gameCount].Visible = true; // reveal relevant label as game goes on
            GameOutcome gameOutcome = DetermineWinner(playerChoice, computerChoice); // receives game outcome
            switch (gameOutcome) // switch statement on all outcomes of gameOutcome
            {
                default: // game counter is useful to display correct info in the correct label at the correct time
                case GameOutcome.Draw:
                    labelWinners[gameCount].Text += " Draw"; // adds draw text if draw
                    break;
                case GameOutcome.PlayerWins:
                    labelWinners[gameCount].Text += " Player Won"; // adds player won text if player won
                    break;
                case GameOutcome.ComputerWins:
                    labelWinners[gameCount].Text += " Computer Won"; // adds computer won text if computer won
                    break;
            }

            if (gameCount >= 2) // if game round exceeds or equals 3 times (starts at -1)
            {
                GameOutcome overallOutcome = DetermineOverallWinner(playerScore, computerScore);
                string winner;
                switch (overallOutcome)
                {
                    case GameOutcome.Draw:
                        winner = "Draw";
                        break;
                    case GameOutcome.PlayerWins:
                        winner = "Player Wins";
                        break;
                    default:
                    case GameOutcome.ComputerWins:
                        winner = "Computer Wins";
                        break;
                }

                if (overallOutcome != GameOutcome.Draw || gameCount >= 3) // if last game was a draw, play one more game
                {
                    labelOverallWinner.Visible = true;
                    labelOverallWinner.Text = "Overall Winner: " + winner;
                    EndGame();
                }
            }
        }

        // takes in player's choice + computer's choice and returns the outcome in the GameOutcome enum
        private GameOutcome DetermineWinner(Choice playerChoice, Choice computerChoice)
        {
            GameOutcome outcome;
            if (playerChoice == computerChoice) // draw
            {
                outcome = GameOutcome.Draw;
            }
            else if (
                (playerChoice == Choice.Rock && computerChoice == Choice.Scissors)
                || (playerChoice == Choice.Paper && computerChoice == Choice.Rock) // Hierarchy of moves (which moves beat which)
                || (playerChoice == Choice.Scissors && computerChoice == Choice.Paper)
            )
            {
                outcome = GameOutcome.PlayerWins;
                playerScore++; // add 1 to player's score
            }
            else // opposite of above
            {
                outcome = GameOutcome.ComputerWins;
                computerScore++; // add 1 to computer's score
            }

            return outcome;
        }

        // method to calculate overall winner based on two scores
        private GameOutcome DetermineOverallWinner(int scorePlayer, int scoreComputer)
        {
            GameOutcome outcome;
            if (scorePlayer > scoreComputer)
            {
                outcome = GameOutcome.PlayerWins;
            }
            else if (scoreComputer > scorePlayer)
            {
                outcome = GameOutcome.ComputerWins;
            }
            else
            {
                outcome = GameOutcome.Draw;
            }

            return outcome;
        }

        private void EndGame() // resets the game counter, player and computer score, and disables game buttons (to prevent errors)
        {
            gameCount = -1;
            playerScore = 0;
            computerScore = 0;

            buttonPlayAgain.Enabled = true;
            buttonRock.Enabled = false;
            buttonPaper.Enabled = false;
            buttonScissors.Enabled = false;
        }

        // re-enables game buttons to start the game again, clears and hides game history
        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < labelWinners.Length; i++)
            {
                labelWinners[i].Text = $"Winner of Game {i + 1}: ";
                labelWinners[i].Visible = false;
            }

            labelPlayerChoice.Text = "Player Selected: ";
            labelComputerChoice.Text = "Computer Selected: ";
            labelOverallWinner.Visible = false;

            buttonPlayAgain.Enabled = false;
            buttonRock.Enabled = true;
            buttonPaper.Enabled = true;
            buttonScissors.Enabled = true;
        }
    }
}
