using UnityEngine;

namespace Gameplay
{
    public class BallTeleport : MonoBehaviour
    {
        public void TeleportTo(Transform target) => transform.position = target.position;
    }
}


