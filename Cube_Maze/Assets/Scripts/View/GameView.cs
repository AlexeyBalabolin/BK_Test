using GameStates;
using UnityEngine;
using UnityEngine.UI;

namespace View
{
    public class GameView : MonoBehaviour, IView
    {
        [SerializeField]
        private Button _pause, _resume, _menu;

        [SerializeField]
        private GameObject _pausePanel;

        public IView Construct(GameStateMachine gameStateMachine)
        {
            _pause.onClick.AddListener(PauseGame);
            _menu.onClick.AddListener(() => OpenMainMenu(gameStateMachine));
            _resume.onClick.AddListener(ResumeGame);
            return this;
        }

        public void Hide()
        {
            gameObject.SetActive(false);
            ResumeGame();
        }

        public void Show()
        {
            gameObject.SetActive(true);
        }

        private void PauseGame()
        {
            Time.timeScale = 0;
            _pausePanel.SetActive(true);
        }

        private void ResumeGame()
        {
            Time.timeScale = 1;
            _pausePanel.SetActive(false);
        }

        private void OpenMainMenu(GameStateMachine gameStateMachine) => gameStateMachine.Enter<MenuState>();
    }

}


