using Configs;
using Factory;
using Gameplay;
using UnityEngine;
using View;

namespace GameStates
{
    //точка входа в игру
    public class Bootstraper : MonoBehaviour
    {
        [SerializeField]
        private GameConfigs _configs;

        private IFactory _factory;

        private GameStateMachine _gameStateMachine;

        public MenuView Menu{ get => _configs.Menu.GetComponent<MenuView>(); }
        public GameView GamePanel { get => _configs.Game.GetComponent<GameView>(); }
        public WinView Win { get => _configs.Win.GetComponent<WinView>(); }

        private AudioController _audioController;
        public AudioController AudioController { get => _audioController; }

        private void Start()
        {
            _factory = new GameFactory();
            _audioController = _factory.CreateFromPrefab(_configs.AudioController.gameObject).GetComponent<AudioController>();
            _gameStateMachine = new GameStateMachine(this, _factory);
            _gameStateMachine.Enter<MenuState>(); // сразу входим в состояние игрового меню
        }
    }
}

