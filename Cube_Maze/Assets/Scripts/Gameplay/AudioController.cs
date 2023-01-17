using UnityEngine;

namespace Gameplay
{
    public class AudioController : MonoBehaviour
    {
        [SerializeField]
        private AudioSource _soundsSource;

        [SerializeField]
        private AudioClip _mazeRotationSound, _winSound;

        public void PlayRotationSound() => _soundsSource.PlayOneShot(_mazeRotationSound);
        public void PlayWinSound() => _soundsSource.PlayOneShot(_winSound);
    }
}

