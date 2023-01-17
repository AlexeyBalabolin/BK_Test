using UnityEngine;

namespace Logic
{
    //выбор объекта со сменой материала
    public class SelectColorChange : ISelect
    {
        private Material _selectedMaterial, _deselectedMaterial;
        private GameObject _target;
        public SelectColorChange(Material selectedMaterial, Material deselectedMaterial, GameObject target)
        {
            _selectedMaterial = selectedMaterial;
            _deselectedMaterial = deselectedMaterial;
            _target = target;
        }
        public void Deselect()
        {
            var renderer = _target.GetComponent<Renderer>();
            renderer.material = _deselectedMaterial;
        }

        public void Select()
        {
            var renderer = _target.GetComponent<Renderer>();
            renderer.material = _selectedMaterial;
        }
    }
}

