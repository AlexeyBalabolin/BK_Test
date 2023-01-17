using UnityEngine;

namespace Logic
{
    public class PrimitiveGameObject : InteractiveObject, ICreate
    {
        private readonly float MaxOffset = 3f;

        //установка значений и реализация интерфейсов
        public void Create(GameConfigs gameConfigs)
        {
            transform.position = new Vector3(SetOffset(), 0, SetOffset());
            Construct(new AlphaChanger(gameObject),
                new SelectColorChange(gameConfigs.SelectedMaterial, gameConfigs.DeselectedMaterial, gameObject),
                new HideRenderer(gameObject.GetComponent<MeshRenderer>()));
        }

        //начальное смещение созданного объекта
        private float SetOffset() => Random.Range(-MaxOffset, MaxOffset);
    }
}

