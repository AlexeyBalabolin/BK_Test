using GameStates;
using UnityEngine;
using UnityEngine.UI;

namespace View
{
    public class WinView : MonoBehaviour, IView
    {
        [SerializeField]
        private Button _restartButton;

        [SerializeField]
        private Button _menuButton;

        public IView Construct(GameStateMachine gameStateMachine)
        {
            _restartButton.onClick.AddListener(() => gameStateMachine.Enter<GameLoopState>());
            _menuButton.onClick.AddListener(() => gameStateMachine.Enter<MenuState>());
            return this;
        }

        public void Hide() => gameObject.SetActive(false);

        public void Show() => gameObject.SetActive(true);
    }

}


