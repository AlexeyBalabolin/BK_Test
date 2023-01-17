using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace View
{
    //класс для смены прозрачности выделенных объектов
    public class AlphaChangerView : MonoBehaviour
    {
        [SerializeField]
        private List<ButtonValue> _alphaButtons = new List<ButtonValue>();

        [SerializeField]
        private MenuSelectorView _menuView;

        private void Start()
        {
            foreach(var button in _alphaButtons)
                button.Button.onClick.AddListener(() => SetActiveObjectsAlpha(button.AlphaValue));
        }

        /// <summary>
        /// скрыть или показать выбранные объекты
        /// </summary>
        /// <param name="alphaLevel">уровень прозрачности</param>
        public void SetActiveObjectsAlpha(float alphaLevel)
        {
            foreach(var primitive in _menuView.SelectableObjects)
                primitive.ChangeAlpha(alphaLevel);
        }

        //вспомогательный класс, связывающий кнопку и уровень прозрачности
        [Serializable]
        private class ButtonValue 
        {
            public Button Button;
            
            [Range(0,1)]
            public float AlphaValue;
        }
    }
}

