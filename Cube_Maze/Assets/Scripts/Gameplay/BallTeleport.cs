using UnityEngine;

namespace Gameplay
{
    public class BallTeleport : MonoBehaviour
    {
        private CharacterController _characterController;

        private void Start() => _characterController = GetComponent<CharacterController>();

        public void TeleportTo(Transform target)
        {
            _characterController.enabled = false;
            transform.position = target.position;
            _characterController.enabled = true;
        }
    }
}


