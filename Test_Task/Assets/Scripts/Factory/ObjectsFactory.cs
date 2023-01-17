using Logic;
using UnityEngine;

namespace Factory
{
    //фабрика инкапсулирует логику создания объектов
    public class ObjectsFactory : IFactory
    {
        private GameConfigs _gameConfigs;
        public ObjectsFactory(GameConfigs gameConfigs) => _gameConfigs = gameConfigs;

        /// <summary>
        /// создание объекта из префаба
        /// </summary>
        /// <param name="prefab">префаб</param>
        /// <returns></returns>
        public GameObject CreateFromPrefab(GameObject prefab) => Object.Instantiate(prefab);

        /// <summary>
        /// создание объекта по пути к файлу ресурса
        /// </summary>
        /// <param name="resourcePath"></param>
        /// <returns></returns>
        public GameObject CreateFromResource(string resourcePath) => (GameObject)Object.Instantiate(Resources.Load(resourcePath));

        /// <summary>
        /// создание примитивного объекта по типу
        /// </summary>
        /// <param name="primitiveType">тип примитивного объекта</param>
        /// <returns></returns>
        public GameObject CreatePrimitive(PrimitiveType primitiveType)
        {
            GameObject primitive = GameObject.CreatePrimitive(primitiveType);           
            RegisterCreatedObject(primitive,_gameConfigs);
            return primitive;
        }

        //установка свойств созданного объекта
        private void RegisterCreatedObject(GameObject createdObject, GameConfigs gameConfigs)
        {
            PrimitiveGameObject primitiveGameObject = createdObject.AddComponent(typeof(PrimitiveGameObject)) as PrimitiveGameObject;
            primitiveGameObject.Create(gameConfigs);
        }
    }
}

