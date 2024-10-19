using UnityEngine;

namespace Infrastructure.Factories
{
    public interface IFactoryComponent
    {
        T Create<T>(T prefab) where T : Component;
    }
}