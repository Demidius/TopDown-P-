using Data;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Infrastructure.Services.SceneLoader
{
    public abstract class SceneLoaderBase
    {
        protected string CurrentScene =>
            SceneManager.GetActiveScene().name;

        protected bool IsCurrentScene(SceneData scene) =>
            CurrentScene == scene.Name;

        protected AsyncOperation GetAsyncLoad(SceneData scene) =>
            SceneManager.LoadSceneAsync(scene.Name, scene.Mode);

        protected AsyncOperation GetAsyncUnLoad(SceneData scene) =>
            SceneManager.UnloadSceneAsync(scene.Name);
    }
}


