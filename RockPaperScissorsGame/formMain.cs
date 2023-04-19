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

        private int playerScore = 0;
        private int computerScore = 0;
        private int gameCount = 0; // counter to track the amount of games

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

        // starts the game
        private void StartGame(Choice playerChoice)
        {
            gameCount++; // increases game round

            Random random = new Random();
            Choice computerChoice = (Choice)random.Next(0, 3); /* randomly generates computer's choice between 0 and 2 and casts it
            into the Choice enum */

            // outputs choices
            labelComputerChoice.Text = "Computer Selected: " + computerChoice;
            labelPlayerChoice.Text = "Player Selected: " + playerChoice;

            // receives game outcome
            GameOutcome gameOutcome = DetermineWinner(playerChoice, computerChoice);

            string outcome;
            switch (gameOutcome) // creates a outcome string based on the game outcome
            {
                default:
                case GameOutcome.Draw:
                    outcome = " Draw";
                    break;
                case GameOutcome.PlayerWins:
                    outcome = " Player Won";
                    break;
                case GameOutcome.ComputerWins:
                    outcome = " Computer Won";
                    break;
            }

            switch (gameCount) // adds outcome to relevant label and reveals them
            {
                default:
                case 1:
                    labelWinner1.Visible = true;
                    labelWinner1.Text += outcome;
                    break;
                case 2:
                    labelWinner2.Visible = true;
                    labelWinner2.Text += outcome;
                    break;
                case 3:
                    labelWinner3.Visible = true;
                    labelWinner3.Text += outcome;
                    break;
                case 4:
                    labelWinner4.Visible = true;
                    labelWinner4.Text += outcome;
                    break;
            }

            if (gameCount >= 3) // if game round exceeds or equals 3 times
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

                if (overallOutcome != GameOutcome.Draw || gameCount >= 4) // if last game was a draw, play one more game (round 4)
                {
                    labelOverallWinner.Visible = true;
                    labelOverallWinner.Text = "Overall Winner: " + winner;
                    EndGame();
                }
            }
        }

        // takes in player's choice + computer's choice and returns the outcome in the GameOutcome enum
        // scores are incremented
        private GameOutcome DetermineWinner(Choice playerChoice, Choice computerChoice)
        {
            GameOutcome outcome;
            if (playerChoice == computerChoice)
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
                playerScore++;
            }
            else
            {
                outcome = GameOutcome.ComputerWins;
                computerScore++;
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
            gameCount = 0;
            playerScore = 0;
            computerScore = 0;

            buttonRock.Enabled = false;
            buttonPaper.Enabled = false;
            buttonScissors.Enabled = false;
        }

        // re-enables game buttons to start the game again, clears and hides game history
        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            labelWinner1.Text = "Winner of Game 1:";
            labelWinner1.Visible = false;

            labelWinner2.Text = "Winner of Game 2:";
            labelWinner2.Visible = false;

            labelWinner3.Text = "Winner of Game 3:";
            labelWinner3.Visible = false;

            labelWinner4.Text = "Winner of Game 4:";
            labelWinner4.Visible = false;

            labelPlayerChoice.Text = "Player Selected: ";
            labelComputerChoice.Text = "Computer Selected: ";
            labelOverallWinner.Visible = false;

            buttonRock.Enabled = true;
            buttonPaper.Enabled = true;
            buttonScissors.Enabled = true;
        }
    }

    #region Reference List
    /*
  
    Tenor. 2022. The Rock Raising Eyebrow GIF. [Online].
    Available at: https://tenor.com/view/the-rock-raising-eyebrow-gif-25067257
    [Accessed 19 April 2023].

    BetterCloud. 2021. clippy. [Online].
    Available at: https://www.bettercloud.com/monitor/the-academy/how-to-find-clippy-in-office-2013/clippy/
    [Accessed 19 April 2023].

    iStock. 2016. Scissors Icon stock illustration. [Online].
    Available at: https://www.istockphoto.com/vector/scissors-icon-gm518699616-90180015
    [Accessed 19 April 2023].
    
     */
    #endregion
}
