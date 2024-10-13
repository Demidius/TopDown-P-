using UnityEngine;

namespace Code_Base
{
    [RequireComponent(typeof(AudioSource))]
    public class Sounds : MonoBehaviour
    {
        [Header("Настройки звука")]
        public AudioClip[] sounds;
        public SoundsArrays[] randSound;

        private AudioSource _audioSource;

        public bool loopSound = false;

        private AudioSource AudioSource
        {
            get
            {
                if (_audioSource == null)
                    _audioSource = GetComponent<AudioSource>();
                return _audioSource;
            }
        }

        public void PlaySound(int index, float volume = 1f, bool random = false, bool destroyed = false, float p1 = 0.85f, float p2 = 1.2f)
        {
            if (!IsValidIndex(index, random))
            {
                Debug.LogWarning($"Неверный индекс звука: {index}");
                return;
            }

            AudioClip clip = random ? GetRandomClip(index) : sounds[index];
            AudioSource.pitch = Random.Range(p1, p2);

            if (destroyed)
            {
                AudioSource.PlayClipAtPoint(clip, transform.position, volume);
            }
            else
            {
                AudioSource.loop = loopSound;
                AudioSource.clip = clip;
                AudioSource.volume = volume;

                if (loopSound)
                {
                    AudioSource.Play();
                }
                else
                {
                    AudioSource.PlayOneShot(clip, volume);
                }
            }
        }

        private AudioClip GetRandomClip(int index)
        {
            return randSound[index].soundArray[Random.Range(0, randSound[index].soundArray.Length)];
        }

        private bool IsValidIndex(int index, bool random)
        {
            if (random)
            {
                return index >= 0 && index < randSound.Length && randSound[index].soundArray.Length > 0;
            }
            else
            {
                return index >= 0 && index < sounds.Length;
            }
        }
        
        public void StopSound()
        {
            if (AudioSource.isPlaying)
            {
                AudioSource.Stop();
            }
        }

        [System.Serializable]
        public class SoundsArrays
        {
            public AudioClip[] soundArray;
        }
    }
}