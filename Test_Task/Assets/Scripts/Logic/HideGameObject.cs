using UnityEngine;

namespace Logic
{
    public class HideGameObject : IHide
    {
        private GameObject _target;

        public HideGameObject(GameObject target) => _target = target;

        public void Hide() => _target.SetActive(false);

        public void Show() => _target.SetActive(true);
    }
}

