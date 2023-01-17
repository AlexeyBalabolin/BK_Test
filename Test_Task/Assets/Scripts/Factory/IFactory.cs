using UnityEngine;
using View;

namespace Factory
{
    public interface IFactory
    {
        GameObject CreateFromResource(string resourcePath);
        GameObject CreateFromPrefab(GameObject prefab);
        GameObject CreatePrimitive(PrimitiveType primitiveType);
    }
}

