using GameStates;

namespace View
{
    public interface IView
    {
        IView Construct(GameStateMachine gameStateMachine);
        void Show();
        void Hide();
    }
}


