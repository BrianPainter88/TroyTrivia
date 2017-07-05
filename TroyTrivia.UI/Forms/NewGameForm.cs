using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TroyTrivia.Business.Entities;
using TroyTrivia.Business.Interfaces;

namespace TroyTrivia.UI.Forms
{
    public partial class NewGameForm : Form, IDialogForm
    {
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
            var locationList = Business.Entities.Location.Select().ToList();
            cmbLocation.DataSource = locationList.Select(l => l.Name).ToList();
            cmbLocation.Update();

            var difficultyList = QuestionDifficulty.Select().Select(q => q.Name).ToList();
            cmbDifficulty.DataSource = difficultyList;
            cmbDifficulty.Update();

            var typeList = QuestionType.Select().Select(q => q.Name).ToList();
            cmbType.DataSource = typeList;
            cmbType.Update();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            PageResult = DialogResult.OK;
            Game.Questions = _gameQuestions;
            Game.Location = Business.Entities.Location.Select(cmbLocation.Text);
            this.Close();
        }

        private void btnGenerateRandomQuestion_Click(object sender, EventArgs e)
        {
            var selectedDifficulty = QuestionDifficulty.Select(cmbDifficulty.SelectedValue.ToString());
            var selectedType =  QuestionType.Select(cmbType.SelectedValue.ToString());

            if (selectedDifficulty != null && selectedType != null)
            {
                try
                {
                    _currentQuestion = Question.GetRandomQuestion(selectedDifficulty.Id, selectedType.Id);
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
                    _currentQuestion = Question.GetRandomQuestionByDifficulty(selectedDifficulty.Id);
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
                    _currentQuestion = Question.GetRandomQuestionByType( selectedType.Id);
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

                    location.Insert();
                }

            }

            var locationList = Business.Entities.Location.Select().ToList();
            cmbLocation.DataSource = locationList.Select(l => l.Name).ToList();
            cmbLocation.Update();
        }
    }
}
