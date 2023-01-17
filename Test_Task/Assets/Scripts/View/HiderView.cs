using UnityEngine;
using UnityEngine.UI;

namespace View
{
    //класс, управляющий скрытием/ отображением объектов на сцене
    public class HiderView : MonoBehaviour
    {
        [SerializeField]
        private MenuSelectorView _menuView;

        [SerializeField]
        private Toggle _activateToggle;

        private void Start() => _activateToggle.onValueChanged.AddListener((ctx) => SetObjectsVisible(ctx));

        /// <summary>
        /// скрыть/показать объекты на сцене
        /// </summary>
        /// <param name="isVisible">видимость</param>
        public void SetObjectsVisible(bool isVisible)
        {
            foreach(var interactiveObject in _menuView.CreatedObjects)
            {
                if (isVisible)
                    interactiveObject.Show();
                else
                    interactiveObject.Hide();
            }
        }
    }
}

