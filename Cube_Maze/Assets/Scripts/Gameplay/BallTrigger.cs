using UnityEngine;
using UnityEngine.Events;

namespace Gameplay
{
    //класс, детектирующий вход игрока в триггер
    public class BallTrigger : MonoBehaviour
    {
        private const string TAG = "Player"; //тэг объекта, который должен войти в триггер
        public UnityEvent OnPlayerEnter;

        protected virtual void OnTriggerEnter(Collider other)
        {
            if (other.tag == TAG)
                OnPlayerEnter?.Invoke();
        }
    }
}


