using Factory;
using Logic;
using UnityEngine;
using View;

//точка входа в игру
public class GameBootstraper : MonoBehaviour
{
    [SerializeField]
    private GameConfigs _gameConfigs;

    private IFactory _factory;
    private GameObjectAnchorView _anchorView;

    void Start()
    {
        _factory = new ObjectsFactory(_gameConfigs);
        _anchorView = new GameObjectAnchorView(_factory);

        IView menuView = _factory.CreateFromPrefab(_gameConfigs.MenuPrefab).GetComponent<IView>();

        foreach (var primitiveType in _gameConfigs.PrimitiveTypes)
        {
            GameObject primitive = _factory.CreatePrimitive(primitiveType);
            _anchorView.LinkObjectToView(menuView, primitive.GetComponent<InteractiveObject>());
        }
           
    }
}
