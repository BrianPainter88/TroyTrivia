using System.Windows;
using System.Windows.Controls;
using TroyTrivia.Business.Entities;
using TroyTrivia.Business.Interactors;
using TroyTrivia.Business.Interfaces;

namespace TroyTrivia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static  IDatabase _sqlInteractor;
        public Game _currentGame;

        public MainWindow()
        {
            InitializeComponent();
            _sqlInteractor = new SqLiteInteractor();
        }

        private void refreshScoreboardButton_Click(object sender, RoutedEventArgs e)
        {
            scoreboardDataGrid.ItemsSource = _currentGame.ScoreBoard.Scores;
        }

        private void scoreboardDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
