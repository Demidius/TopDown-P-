using System;

namespace Infrastructure.Services.SceneLoader
{
    public interface ISceneLoaderCoroutine : IService
    {
        void Load(SceneData scene, Action completed = null);
        void UnLoad(SceneData scene, Action completed = null);
    }
}