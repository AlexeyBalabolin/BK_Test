using UnityEngine;

namespace Logic
{
    // скрытие объекта отключением MeshRenderer
    public class HideRenderer : IHide
    {
        private MeshRenderer _renderer;
        public HideRenderer(MeshRenderer renderer) => _renderer = renderer;
        public void Hide() => _renderer.enabled = false;

        public void Show() => _renderer.enabled = true;
    }
}

