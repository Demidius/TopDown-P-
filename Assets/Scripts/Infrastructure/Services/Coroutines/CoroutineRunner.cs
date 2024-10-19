using UnityEngine;

namespace Infrastructure.Services.Coroutines
{
    public class CoroutineRunner : MonoBehaviour
    {
        private void Awake() => 
            DontDestroyOnLoad(gameObject);
    }
}
