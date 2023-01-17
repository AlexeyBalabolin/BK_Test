using UnityEngine;

namespace Logic
{
    public class AlphaChanger : IAlphaChange
    {
        private GameObject _target;

        public AlphaChanger(GameObject target) => _target = target;

        /// <summary>
        /// установка значения Color.a
        /// </summary>
        /// <param name="alphaLevel">уровень прозрачности</param>
        public void SetAlpha(float alphaLevel)
        {
            var renderer = _target.GetComponent<Renderer>();
            Color newColor = renderer.material.color;
            newColor.a = alphaLevel;
            renderer.material.color = newColor;
        }
    }
}

