using System.Collections.Generic;
using TBQuestGame.S_.Models;

namespace TBQuestGame.S_.PresentationLayer
{
    public partial class GameSessionViewModel
    {
        public GameSessionViewModel gameSessionViewModel;

        #region Fields
        public Player _player;
        public List<string> _messages;
        public GameSessionViewModel _gam;
        #endregion

        #region Properties
        public List<string> Messages
        {
            get { return _messages; }
            set { _messages = value; }
        }
        public Player Player
        {
            get { return _player; }
            set { _player = value; }
        }
        #endregion

        #region Constructor
        public GameSessionViewModel()
        {

        }

        public GameSessionViewModel(
            Player player,
            List<string> initialMessages)
        {
            _player = player;
            _messages = initialMessages;
        }
        #endregion

        #region Methods

        #endregion
    }
}
