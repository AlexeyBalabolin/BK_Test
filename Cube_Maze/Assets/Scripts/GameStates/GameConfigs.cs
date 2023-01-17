using Gameplay;
using UnityEngine;
namespace Configs
{
    [CreateAssetMenu(fileName ="GameConfigs", menuName ="Data/Configs")]
    public class GameConfigs: ScriptableObject
    {
        public GameObject Menu;

        public GameObject Game;

        public GameObject Win;

        public AudioController AudioController;
    }
}

