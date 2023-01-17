using Factory;
using Gameplay;
using UnityEngine;
using View;

namespace GameStates
{
    // состояние активной игры
    public class GameLoopState : IGameState
    {
        private GameObject _maze;
        private IFactory _factory;
        private GameStateMachine _gameStateMachine;
        private IView _view;
        private GameObject _gamePanel;
        private const string ResourcePath = "MAZE";
        private AudioController _audioController;

        public GameLoopState(GameStateMachine gameStateMachine, IFactory factory, GameObject gamePanel, AudioController audioController)
        {
            _factory = factory;
            _gameStateMachine = gameStateMachine;
            _gamePanel = gamePanel;
            _audioController = audioController;
        }

        public void Enter()
        {
            GenerateNewMaze(); // каждую новую игру создаем новый лабиринт

            if (_view == null)
            {
                _view = _factory.CreateFromPrefab(_gamePanel).GetComponent<IView>();
                _view.Construct(_gameStateMachine);
            }
            _view.Show();
        }

        public void Exit()
        {
            //очищаем лабиринт при выходе из активного игрового цикла
            _factory.Destroy(_maze.gameObject);
            _maze = null;

            _view.Hide();
        }

        //создание нового лабиринта
        private void GenerateNewMaze()
        {
            _maze = _factory.CreateFromResource(ResourcePath);
            _maze.GetComponentInChildren<FinishTrigger>().Construct(_gameStateMachine, _audioController);
            _maze.GetComponentInChildren<CubeRotator>().OnRotationStart.AddListener(_audioController.PlayRotationSound);
        }
    }
}

