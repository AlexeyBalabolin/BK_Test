using UnityEngine;

namespace Gameplay
{
    public class MazeRotationTrigger : BallTrigger
    {
        [SerializeField]
        private CubeRotator _cubeRotator;

        [SerializeField]
        private RotationDirections RotationDirection;

        protected override void OnTriggerEnter(Collider other)
        {
            base.OnTriggerEnter(other);
            _cubeRotator.RotateCube(RotationDirection);
        }
    }
}


