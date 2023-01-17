using UnityEngine;

namespace Factory
{
    //инкапсулирование создание объектов 
    public class GameFactory : IFactory
    {
        public GameObject CreateFromPrefab(GameObject prefab) => Object.Instantiate(prefab);

        public GameObject CreateFromResource(string path) => (GameObject)Object.Instantiate(Resources.Load(path));

        public void Destroy(GameObject targetObject) => Object.Destroy(targetObject);
    }
}

