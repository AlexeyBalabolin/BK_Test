using UnityEngine;

namespace Factory
{
    public interface IFactory
    {
        GameObject CreateFromPrefab(GameObject prefab);
        GameObject CreateFromResource(string path);
        void Destroy(GameObject targetObject);
    }
}

