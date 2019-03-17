using System.Collections.Generic;
using TBQuestGame.PresentationLayer;
using TBQuestGame.S_.DataLayer;
using TBQuestGame.S_.Models;
using TBQuestGame.S_.PresentationLayer;

namespace TBQuestGame.S_.BusinessLayer
{
    public class GameBusiness
    {
        GameSessionViewModel _gameSessionViewModel;
        Player _player;
        List<string> _message;
        bool _newPlayer = true;
        PlayerSetUpView _playerSetUpView;

        public GameBusiness()
        {
            SetupPlayer();
            InitalizeDataSet();
            InstantiateAndShowView();
        }
        public void InitalizeDataSet()
        {
            _player = GameData.PlayerData();
            _message = GameData.InitialMesseges();
        }
        public void SetupPlayer()
        {
            if (_newPlayer)
            {
                _playerSetUpView = new PlayerSetUpView(_player);
                _playerSetUpView.ShowDialog();

                _player.Sanity = 0;
                _player.Health = 100;
                _player.Lives = 1;
            }
            else
            {
                _player = GameData.PlayerData();
            }

        }
        private void InstantiateAndShowView()
        {
            _gameSessionViewModel = new GameSessionViewModel(
            _player,
            GameData.InitialMesseges()
            );

            GameSessionView gameSessionView = new GameSessionView(_gameSessionViewModel);

            gameSessionView.DataContext = _gameSessionViewModel;

            gameSessionView.Show();

            _playerSetUpView.Close();
        }
    }
}
