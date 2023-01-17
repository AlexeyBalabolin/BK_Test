using UnityEngine;

namespace GameStates
{
    public class ExitGameState : IGameState
    {
        public void Enter()
        {
            Debug.Log("Exit");
            Application.Quit();
        }

        public void Exit()
        {
            
        }
    }
}

