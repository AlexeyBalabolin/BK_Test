using Factory;
using Logic;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace View
{
    //класс для выбора объектов
    public class MenuSelectorView : MonoBehaviour, IView
    {
        [SerializeField]
        private GameObject _togglePrefab;

        [SerializeField]
        private Transform _toggleParent;

        [SerializeField]
        private Toggle _selectAllToggle;

        private List<InteractiveObject> _createdObjects = new List<InteractiveObject>();
        private List<InteractiveObject> _selectedObjects = new List<InteractiveObject>();
        private List<Toggle> _toggles = new List<Toggle>();

        public List<InteractiveObject> CreatedObjects { get => _createdObjects; }
        public List<InteractiveObject> SelectableObjects { get => _selectedObjects; }

        private void Start() => _selectAllToggle.onValueChanged.AddListener((ctx) => SelectHideAll(ctx));

        public void RegisterObject(InteractiveObject createdObject, IFactory factory)
        {
            _createdObjects.Add(createdObject);

            GameObject toggleObject = factory.CreateFromPrefab(_togglePrefab);
            toggleObject.transform.SetParent(_toggleParent);
            toggleObject.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
            Toggle toggle = toggleObject.GetComponentInChildren<Toggle>();
            _toggles.Add(toggle);

            InteractiveObject selectable = createdObject.GetComponent<InteractiveObject>();
            toggle.onValueChanged.AddListener((ctx) => SelectObject(ctx, selectable));        
        }

        //метод выбора предмета
        private void SelectObject(bool isOn, InteractiveObject selectable)
        {
            if (isOn)
            {
                selectable.Select();
                _selectedObjects.Add(selectable);
            }
            else
            {
                selectable.Deselect();
                _selectedObjects.Remove(selectable);
            }
        }

        //выбрать все объекты
        private void SelectHideAll(bool isSelect)
        {
            foreach(var toggle in _toggles)
                toggle.isOn = isSelect;
        }
    }
}

