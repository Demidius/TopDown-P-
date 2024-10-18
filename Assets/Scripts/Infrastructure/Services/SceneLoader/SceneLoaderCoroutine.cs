using System;
using System.Collections;
using Infrastructure.Services.Coroutines;
using UnityEngine;
using Zenject;

namespace Infrastructure.Services.SceneLoader
{
    public class SceneLoaderCoroutine : SceneLoaderBase, ISceneLoaderCoroutine
    {
        private readonly ICoroutineService _coroutineService;

        [Inject]
        public SceneLoaderCoroutine(ICoroutineService coroutineService) =>
            _coroutineService = coroutineService;

        public void Load(SceneData scene, Action completed = null)
        {
            if (IsCurrentScene(scene))
            {
                completed?.Invoke();
                return;
            }

            AsyncOperation asyncOperation = GetAsyncLoad(scene);
            _coroutineService.StartCoroutine(ProcessSceneOperation(scene, completed, asyncOperation));
        }

        public void UnLoad(SceneData scene, Action completed = null)
        {
            AsyncOperation asyncOperation = GetAsyncUnLoad(scene);
            _coroutineService.StartCoroutine(ProcessSceneOperation(scene, completed, asyncOperation));
        }

        private IEnumerator ProcessSceneOperation(SceneData scene, Action completed, AsyncOperation asyncOperation)
        {
            while (!asyncOperation.isDone)
                yield return null;

            completed?.Invoke();
        }
    }
}