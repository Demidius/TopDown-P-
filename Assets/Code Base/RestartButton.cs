using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code_Base
{
    public class RestartButton : MonoBehaviour
    {
        public void RestartScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}