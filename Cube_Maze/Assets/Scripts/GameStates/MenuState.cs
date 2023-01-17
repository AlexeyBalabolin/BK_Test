using Factory;
using UnityEngine;
using View;

namespace GameStates
{

    //состояние игрового меню
    public class MenuState : IGameState
    {
        private IView _view;
        private IFactory _factory;
        private GameStateMachine _gameStateMachine;
        private GameObject _menuPrefab;

        public MenuState(GameStateMachine gameStateMachine, IFactory factory, GameObject menuPrefab)
        {
            _gameStateMachine = gameStateMachine;
            _factory = factory;
            _menuPrefab = menuPrefab;
        }

        public void Enter()
        {
            if(_view == null)
            {
                _view = _factory.CreateFromPrefab(_menuPrefab).GetComponent<IView>();
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

