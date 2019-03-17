using System;
using System.Windows;

namespace TBQuestGame.S_.PresentationLayer
{
    /// <summary>
    /// Interaction logic for GameSessionView.xaml
    /// </summary>
    public partial class GameSessionViewModel : Window
    {
        GameSessionViewModel _gameSessionViewModel;

        public GameSessionView(GameSessionViewModel gameSessionViewModel)
        {
            _gameSessionViewModel = gameSessionViewModel;

            InitializeComponent();
        }

        public void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
