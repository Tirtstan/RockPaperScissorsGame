using System.Linq.Expressions;

namespace RockPaperScissorsGame
{
    public partial class formMain : Form
    {
        private enum Choice
        {
            Rock = 0,
            Paper = 1,
            Scissors = 2,
        }
        private enum GameOutcome
        {
            PlayerWins = 0,
            ComputerWins = 1,
            Draw = 2,
        }
        private Label[] labelWinners;
        private int gameCount = -1;

        public formMain()
        {
            InitializeComponent();
        }

        private void buttonRock_Click(object sender, EventArgs e)
        {
            StartGame(Choice.Rock);
        }

        private void buttonPaper_Click(object sender, EventArgs e)
        {
            StartGame(Choice.Paper);
        }

        private void buttonScissors_Click(object sender, EventArgs e)
        {
            StartGame(Choice.Scissors);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartGame(Choice playerChoice)
        {
            labelWinners = new Label[3] { labelWinner1, labelWinner2, labelWinner3 };   
            gameCount++;

            labelPlayerChoice.Text = "Player Selected: " + playerChoice;
            Random random = new Random();
            Choice computerChoice = (Choice)random.Next(0, 3);
            labelComputerChoice.Text = "Computer Selected: " + computerChoice;

            GameOutcome gameOutcome = DetermineWinner(playerChoice, computerChoice);
            switch (gameOutcome)
            {
                default:
                case GameOutcome.Draw:
                    labelWinners[gameCount].Text += " Draw";
                    break;
                case GameOutcome.PlayerWins:
                    labelWinners[gameCount].Text += " Player Won";
                    break;
                case GameOutcome.ComputerWins:
                    labelWinners[gameCount].Text += " Computer Won";
                    break;
            }

            if (gameCount >= 2)
            {
                EndGame();
            }
        }

        private GameOutcome DetermineWinner(Choice playerChoice, Choice computerChoice)
        {
            GameOutcome outcome;
            if (playerChoice == computerChoice)
            {
                outcome = GameOutcome.Draw;
            }
            // Heirachy of moves (which moves beat which)
            else if ((playerChoice == Choice.Rock && computerChoice == Choice.Scissors) || // rock vs scissors
                     (playerChoice == Choice.Paper && computerChoice == Choice.Rock) || // paper vs rock
                     (playerChoice == Choice.Scissors && computerChoice == Choice.Paper)) // scissors vs paper
            {
                outcome = GameOutcome.PlayerWins;
            }
            else
            {
                outcome = GameOutcome.ComputerWins;
            }

            return outcome;
        }

        private void EndGame()
        {
            gameCount = -1;

            buttonPlayAgain.Enabled = true;
            buttonRock.Enabled = false;
            buttonPaper.Enabled = false;
            buttonScissors.Enabled = false;
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < labelWinners.Length; i++)
            {
                labelWinners[i].Text = $"Winner of Game {i + 1}: ";
            }

            buttonPlayAgain.Enabled = false;
            buttonRock.Enabled = true;
            buttonPaper.Enabled = true;
            buttonScissors.Enabled = true;
        }
    }
}