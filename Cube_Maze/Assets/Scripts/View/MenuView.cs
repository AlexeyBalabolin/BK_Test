using GameStates;
using UnityEngine;
using UnityEngine.UI;

namespace View
{
    public class MenuView : MonoBehaviour, IView
    {
        [SerializeField]
        private Button _startGameButton;

        [SerializeField]
        private Button _exitButton;

        public IView Construct(GameStateMachine gameStateMachine)
        {
            _startGameButton.onClick.AddListener(() => gameStateMachine.Enter<GameLoopState>());
            _exitButton.onClick.AddListener(() => gameStateMachine.Enter<ExitGameState>());
            return this;
        }

        public void Hide() => gameObject.SetActive(false);

        public void Show() => gameObject.SetActive(true);
    }

}


