using Factory;
using UnityEngine;
using View;

namespace GameStates
{
    //состояние победы в игре
    public class WinState: IGameState
    {
        private IView _view;
        private IFactory _factory;
        private GameStateMachine _gameStateMachine;
        private GameObject _winMenuPrefab;

        public WinState(GameStateMachine gameStateMachine, IFactory factory, GameObject winMenuPrefab)
        {
            _gameStateMachine = gameStateMachine;
            _factory = factory;
            _winMenuPrefab = winMenuPrefab;
        }

        public void Enter()
        {
            if (_view == null)
            {
                _view = _factory.CreateFromPrefab(_winMenuPrefab).GetComponent<IView>();
                _view.Construct(_gameStateMachine);
            }
            _view.Show();
        }

        public void Exit()
        {
            _view.Hide();
        }
    }

}

