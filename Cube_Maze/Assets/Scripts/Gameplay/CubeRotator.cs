using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Gameplay
{
    public enum RotationDirections
    {
        Left,
        Right,
        Up,
        Down
    }

    public class CubeRotator : MonoBehaviour
    {
        public UnityEvent OnRotationStart, OnRotationEnd;

        [SerializeField, Range(0.1f, 5f)]
        private float _rotationSpeed;

        public void RotateCube(RotationDirections rotationDirection) => StartCoroutine(Rotating(rotationDirection));

        /// <summary>
        /// поворот куба в нужном направлении на 90 градусов
        /// </summary>
        /// <param name="rotationDirection">направление поворота</param>
        /// <returns></returns>
        private IEnumerator Rotating(RotationDirections rotationDirection)
        {
            float angle = 0;
            OnRotationStart?.Invoke();
            Vector3 rotationVector = Vector3.zero;
            switch (rotationDirection)
            {
                case RotationDirections.Down:
                    rotationVector = new Vector3(1, 0, 0);
                    break;
                case RotationDirections.Up:
                    rotationVector = new Vector3(-1, 0, 0);
                    break;
                case RotationDirections.Left:
                    rotationVector = new Vector3(0, 0, -1);
                    break;
                case RotationDirections.Right:
                    rotationVector = new Vector3(0, 0, 1);
                    break;
            }
            while (angle < 90)
            {
                yield return new WaitForEndOfFrame();
                transform.Rotate(rotationVector * _rotationSpeed, Space.World);
                angle += _rotationSpeed;
            }
            OnRotationEnd?.Invoke();
        }
    }
}


