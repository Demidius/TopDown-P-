using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Infrastructure.Services.SceneLoader
{
    [Serializable]
    public class SceneData
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public LoadSceneMode Mode { get; private set; } = LoadSceneMode.Single;
    }
}