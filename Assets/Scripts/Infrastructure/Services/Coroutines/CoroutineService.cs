using System.Collections;
using UnityEngine;
using Zenject;

namespace Infrastructure.Services.Coroutines
{
    public class CoroutineService : ICoroutineService
    {
        private readonly CoroutineRunner _coroutineRunner;

        [Inject]
        public CoroutineService(CoroutineRunner coroutineRunner) =>
            _coroutineRunner = coroutineRunner;

        public Coroutine StartCoroutine(IEnumerator coroutine) =>
            _coroutineRunner.StartCoroutine(coroutine);

        public void StopCoroutine(Coroutine coroutine) => 
            _coroutineRunner.StopCoroutine(coroutine);
    }
}
