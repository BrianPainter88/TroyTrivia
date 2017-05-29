using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TroyTrivia.Business.Entities;
using TroyTrivia.Business.Interactors;
using TroyTrivia.Business.Interfaces;

namespace TroyTrivia.UI.Forms
{
    public partial class NewGameForm : Form
    {
        private static readonly string _databasePath = Business.Properties.Settings.Default.DatabaseFilePath;
        private Question _currentQuestion;
        private HashSet<Question> _gameQuestions;

        public Game Game { get; set; }
        public DialogResult PageResult { get; set; }
        
        public NewGameForm()
        {
            InitializeComponent();
            var gameSettings = new GameSettings();
            Game = new Game(gameSettings);
            _gameQuestions = new HashSet<Question>();

            FillFormData();
        }
        
        private void FillFormData()
        {
            IDatabase sqlInteractor = new SqLiteInteractor();
            var connection = sqlInteractor.GetDatabaseConnection();

            var locationList = Business.Entities.Location.Select(connection).ToList();
            cmbLocation.DataSource = locationList.Select(l => l.Name).ToList();
            cmbLocation.Update();

            var difficultyList = QuestionDifficulty.Select(connection).Select(q => q.Name).ToList();
            cmbDifficulty.DataSource = difficultyList;
            cmbDifficulty.Update();

            var typeList = QuestionType.Select(connection).Select(q => q.Name).ToList();
            cmbType.DataSource = typeList;
            cmbType.Update();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            IDatabase sqlInteractor = new SqLiteInteractor();
            var connection = sqlInteractor.GetDatabaseConnection();

            PageResult = DialogResult.OK;
            Game.Questions = _gameQuestions;
            Game.Location = Business.Entities.Location.Select(connection, cmbLocation.Text);
            this.Close();
        }

        private void btnGenerateRandomQuestion_Click(object sender, EventArgs e)
        {
            IDatabase sqlInteractor = new SqLiteInteractor();
            var connection = sqlInteractor.GetDatabaseConnection();

            var selectedDifficulty = QuestionDifficulty.Select(connection, cmbDifficulty.SelectedValue.ToString());
            var selectedType =  QuestionType.Select(connection, cmbType.SelectedValue.ToString());

            if (selectedDifficulty != null && selectedType != null)
            {
                try
                {
                    _currentQuestion = Question.GetRandomQuestion(connection, selectedDifficulty.Id, selectedType.Id);
                    txtCategory.Text = _currentQuestion.Category.Name;
                    rchQuestion.Text = _currentQuestion.QuestionText;
                    rchAnswer.Text = _currentQuestion.GetAnswer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
            else if (selectedDifficulty != null)
            {
                try
                {
                    _currentQuestion = Question.GetRandomQuestionByType(connection, selectedDifficulty.Id);
                    txtCategory.Text = _currentQuestion.Category.Name;
                    rchQuestion.Text = _currentQuestion.QuestionText;
                    rchAnswer.Text = _currentQuestion.GetAnswer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
            else if (selectedType != null)
            {
                try
                {
                    _currentQuestion = Question.GetRandomQuestionByType(connection, selectedType.Id);
                    txtCategory.Text = _currentQuestion.Category.Name;
                    rchQuestion.Text = _currentQuestion.QuestionText;
                    rchAnswer.Text = _currentQuestion.GetAnswer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            _gameQuestions.Add(_currentQuestion);
            RefreshQuestionCountLabel();
        }

        private void RefreshQuestionCountLabel()
        {
            lblQuestionCount.Text = $"Question Count: {_gameQuestions.Count}";
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            IDatabase sqlInteractor = new SqLiteInteractor();
            var connection = sqlInteractor.GetDatabaseConnection();

            using (var locationForm = new LocationForm())
            {
                locationForm.ShowDialog();
                if (locationForm.PageResult == DialogResult.OK)
                {
                    var location = new Location()
                    {
                        Name = locationForm.LocationName,
                        Phone = locationForm.Phone,
                        Address = locationForm.Address
                    };

                    location.Insert(connection);
                }

            }

            var locationList = Business.Entities.Location.Select(connection).ToList();
            cmbLocation.DataSource = locationList.Select(l => l.Name).ToList();
            cmbLocation.Update();
        }
    }
}
