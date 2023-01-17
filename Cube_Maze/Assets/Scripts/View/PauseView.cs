using GameStates;
using UnityEngine;
using UnityEngine.UI;

namespace View
{
    public class PauseView : MonoBehaviour, IView
    {
        [SerializeField]
        private Button _resume;

        [SerializeField]
        private Button _menu;
        public IView Construct(GameStateMachine gameStateMachine)
        {
            _resume.onClick.AddListener(Hide);
            _menu.onClick.AddListener(() => gameStateMachine.Enter<MenuState>());
            return this;
        }

        public void Hide()
        {
            gameObject.SetActive(false);
            Time.timeScale = 1;
        }

        public void Show()
        {
            gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

}


