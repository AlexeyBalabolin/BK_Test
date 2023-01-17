using GameStates;
using UnityEngine;

namespace Gameplay
{
    //класс, переводящий игру в состояние победы, если игрок вошел в триггер
    public class FinishTrigger : BallTrigger
    {
        private GameStateMachine _gameStateMachine;
        private AudioController _audioController;
        public void Construct(GameStateMachine gameStateMachine, AudioController audioController)
        {
            _gameStateMachine = gameStateMachine;
            _audioController = audioController;
        }

        protected override void OnTriggerEnter(Collider other)
        {
            base.OnTriggerEnter(other);
            _gameStateMachine.Enter<WinState>();
            _audioController.PlayWinSound();
        }
    }
}


