using Factory;
using Logic;

namespace View
{
    public class GameObjectAnchorView
    {
        private IFactory _factory;
        public GameObjectAnchorView(IFactory factory) => _factory = factory;
        public void LinkObjectToView(IView view, InteractiveObject interactive) => view.RegisterObject(interactive, _factory);
    }
}

