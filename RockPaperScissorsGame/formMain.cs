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

        private Label[] labelWinners = new Label[3]; // array of labels for game history
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
            labelWinners = new Label[3] { labelWinner1, labelWinner2, labelWinner3 }; // creates an array of all game history labels
            gameCount++;

            labelPlayerChoice.Text = "Player Selected: " + playerChoice; // outputs the player's choice
            Random random = new Random();
            Choice computerChoice = (Choice)random.Next(0, 3); /* randomly generates computer's choice between 0 and 2 and casts it
            into the Choice enum */
            labelComputerChoice.Text = "Computer Selected: " + computerChoice; // outputs computer's choice

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

            if (gameCount >= 2) // game will end after 3 turns
            {
                EndGame();
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
            // Hierarchy of moves (which moves beat which)
            else if (
                (playerChoice == Choice.Rock && computerChoice == Choice.Scissors)
                || (playerChoice == Choice.Paper && computerChoice == Choice.Rock)
                || (playerChoice == Choice.Scissors && computerChoice == Choice.Paper)
            )
            {
                outcome = GameOutcome.PlayerWins;
            }
            else // opposite of above
            {
                outcome = GameOutcome.ComputerWins;
            }

            return outcome;
        }

        private void EndGame() // resets the game counter and disables game buttons (to prevent errors)
        {
            gameCount = -1;

            buttonPlayAgain.Enabled = true;
            buttonRock.Enabled = false;
            buttonPaper.Enabled = false;
            buttonScissors.Enabled = false;
        }

        // re-enables game buttons to start the game again and clears game history
        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < labelWinners.Length; i++)
            {
                labelWinners[i].Text = $"Winner of Game {i + 1}: ";
            }
            labelPlayerChoice.Text = "Player Selected: ";
            labelComputerChoice.Text = "Computer Selected: ";

            buttonPlayAgain.Enabled = false;
            buttonRock.Enabled = true;
            buttonPaper.Enabled = true;
            buttonScissors.Enabled = true;
        }
    }
}
