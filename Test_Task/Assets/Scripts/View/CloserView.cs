using UnityEngine;
using UnityEngine.UI;

namespace View
{
    public class CloserView : MonoBehaviour
    {
        private const string PARAM_NAME = "IsOpen";

        [SerializeField]
        private Animator _panelAnimator;

        [SerializeField]
        private Button _openCloseButton;

        private bool _isOpen = true;

        private void Start() => _openCloseButton.onClick.AddListener(ChangePanelState);

        public void ChangePanelState()
        {
            if (_isOpen)
                ClosePanel();
            else
                OpenPanel();
            _isOpen = !_isOpen;
        }

        private void OpenPanel() => _panelAnimator.SetBool(PARAM_NAME, true);
        private void ClosePanel() => _panelAnimator.SetBool(PARAM_NAME, false);
    }
}

