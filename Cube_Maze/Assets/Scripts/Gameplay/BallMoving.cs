using UnityEngine;

namespace Gameplay
{
    [RequireComponent(typeof(CharacterController))] // необходимый компонент для перемещения
    public class BallMoving : MonoBehaviour
    {
        [SerializeField, Range(0.5f, 5f)]
        private float _movingSpeed = 3f;

        private IInput _playerInput;
        private CharacterController _characterController;

        private void Start()
        {
            _playerInput = new KeyboardInput(); // реализация ввода игрока
            _characterController = GetComponent<CharacterController>();
        }
        void Update() => _characterController.Move(_playerInput.InputAxis * _movingSpeed * Time.deltaTime);
    }
}


