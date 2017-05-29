using System;
using System.Linq;
using System.Windows.Forms;
using TroyTrivia.Business.Containers;
using TroyTrivia.Business.Entities;
using TroyTrivia.Business.Interactors;
using TroyTrivia.UI.Controls;
using TroyTrivia.UI.Forms;

namespace TroyTrivia.UI
{
    public partial class frmMain : Form
    {
        private const int _editTeamNameColumnIndex = 0;
        private const int _teamNameColumnIndex = 1;
        private const int _incrementScoreColumnIndex = 3;
        private const int _decrementScoreColumnIndex = 4;
        private const string _defaultLocationDisplayName = "Troy Trivia";
        private static Game _currentGame = null;
        private static GameSettings _currentGameSettings = null;

        public frmMain()
        {
            InitializeComponent();
            _currentGameSettings = new GameSettings();
        }

        private void bndQuestions_RefreshItems(object sender, EventArgs e)
        {
            SaveGame();
        }

        private void btnCreateGame_Click(object sender, EventArgs e)
        {
            _currentGame = GetGameInstance();
            if (_currentGame != null)
            {
                lblLocationTitle.Text = false == string.IsNullOrWhiteSpace(_currentGame.Location?.Name) ? _currentGame.Location.Name : _defaultLocationDisplayName;
                if (_currentGame.Questions.Any())
                {
                    questionsBindingSource.DataSource = _currentGame.Questions;
                    pnlQuestions.Update();                    
                }

                this.grdScoreboard.DataSource = _currentGame.ScoreBoard.Scores.Select(d => new { d.Key, d.Value }).ToList();

                this.grdScoreboard.Update();
            }
        }

        private static Game GetGameInstance()
        {
            if (_currentGame != null)
            {
                var response = MessageBox.Show("Do you want to start a new game?", "New Game?", MessageBoxButtons.YesNo);

                if (response.Equals(DialogResult.Yes))
                {
                    return GetNewGameFromForm();
                }
                else
                {
                    return _currentGame;
                }
            }

            return GetNewGameFromForm();
        }

        private static Game GetNewGameFromForm()
        {
            Game game;

            using (var gameForm = new NewGameForm())
            {
                gameForm.ShowDialog();
                game = gameForm.Game;
            }

            return game;
        }

        private static GameSettings GetGameSettings()
        {
            GameSettings gameSettings;

            if (_currentGameSettings != null)
            {
                var response = MessageBox.Show("Do you want to use the current settings?", "Use Current Settings?", MessageBoxButtons.YesNo);

                if (response.Equals(DialogResult.Yes))
                {
                    return _currentGameSettings;
                }

                gameSettings = new GameSettings();
            }
            else
            {
                gameSettings = new GameSettings();
            }

            return gameSettings;
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            var teamName = txtTeamName.Text.Trim();
            if (_currentGame == null || string.IsNullOrWhiteSpace(teamName))
            {
                return;
            }

            var team = new TeamSegment
            {
                Team = new Team
                {
                    Name = teamName
                }
            };

            _currentGame.Teams.Add(team);
            _currentGame.AddTeamsToScoreBoard();

            this.grdScoreboard.DataSource = _currentGame.ScoreBoard.Scores.Select(d => new {d.Key, d.Value}).ToList();

            this.grdScoreboard.Update();
        }

        private void grdScoreboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var teamName = grdScoreboard.Rows[e.RowIndex].Cells[_teamNameColumnIndex].Value.ToString();

            if (e.ColumnIndex == _incrementScoreColumnIndex)
            {
                var promptResult = Prompt.ShowDialog($"How many points are to be added to \"{teamName}\"?", "Add Points");
                int score;
                score = int.TryParse(promptResult, out score) ? score : 0;

                _currentGame.ScoreBoard.IncrementScore(teamName, score);
            }
            else if (e.ColumnIndex == _decrementScoreColumnIndex)
            {
                var promptResult = Prompt.ShowDialog($"How many points are to be removed from \"{teamName}\"?", "Remove Points");
                int score;
                score = int.TryParse(promptResult, out score) ? score : 0;

                _currentGame.ScoreBoard.DecrementScore(teamName, score);
            }

            _currentGame.AddTeamsToScoreBoard();

            this.grdScoreboard.DataSource = _currentGame.ScoreBoard.Scores.Select(d => new { d.Key, d.Value }).OrderByDescending(d => d.Value).ToList();

            this.grdScoreboard.Update();
        }

        private void grdScoreboard_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.grdScoreboard.Rows[e.RowIndex].Cells[0].Value
             = (e.RowIndex + 1).ToString();

            SaveGame();
        }

        private void SaveGame()
        {
            if (_currentGame != null)
            {
                FilesInteractor.SaveCurrentGame(_currentGame);
            }
        }

        private void btnLoadGame_Click(object sender, EventArgs e)
        {
            loadGameFileDialog.InitialDirectory = Business.Properties.Settings.Default.SaveGameFolderPath;
            if (loadGameFileDialog.ShowDialog() == DialogResult.OK)
            {
                _currentGame = FilesInteractor.LoadGameFromFile(loadGameFileDialog.FileName);
            }

            questionsBindingSource.DataSource = _currentGame.Questions;
            pnlQuestions.Update();

            this.grdScoreboard.DataSource = _currentGame.ScoreBoard.Scores.Select(d => new { d.Key, d.Value }).OrderByDescending(d => d.Value).ToList();
            this.grdScoreboard.Update();
        }
    }
}
