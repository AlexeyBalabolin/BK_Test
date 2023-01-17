using Factory;
using System;
using System.Collections.Generic;

namespace GameStates
{
    //класс для изменения игровых состояний
    public class GameStateMachine
    {
        private Dictionary<Type, IGameState> _states;
        private IGameState _activeState;

        public GameStateMachine(Bootstraper bootstraper, IFactory factory)
        {
            _states = new Dictionary<Type, IGameState>()
            {
                [typeof(MenuState)] = new MenuState(this, factory, bootstraper.Menu.gameObject),
                [typeof(ExitGameState)] = new ExitGameState(),
                [typeof(GameLoopState)] = new GameLoopState(this, factory, bootstraper.GamePanel.gameObject, bootstraper.AudioController),
                [typeof(WinState)] = new WinState(this, factory, bootstraper.Win.gameObject),
            };
        }

        //вход в новое состояние
        public void Enter<TState>() where TState : class, IGameState
        {
            IGameState state = ChangeState<TState>();
            state.Enter();
        }

        //смена состояния
        private TState ChangeState<TState>() where TState : class, IGameState
        {
            _activeState?.Exit(); //выход из активного состояния

            TState state = GetState<TState>();
            _activeState = state;

            return state;
        }

        //получение состояния
        private TState GetState<TState>() where TState : class, IGameState => _states[typeof(TState)] as TState;
    }
}

