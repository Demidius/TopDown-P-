using UnityEngine;
using Zenject;

namespace Infrastructure.Factories
{
    public class FactoryComponent : IFactoryComponent
    {
        private DiContainer _container;

        public FactoryComponent(DiContainer container)
        {
            _container = container;
        }

        public T Create<T>(T prefab) where T : Component
        {
            return _container.InstantiatePrefab(prefab).GetComponent<T>();
        }

    }
}