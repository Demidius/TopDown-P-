using System;
using System.Collections.Generic;
using Infrastructure.Factories;
using UnityEngine;
using Zenject;
using Object = UnityEngine.Object;

namespace Weapons.Bullet
{
    public class PoolServices<T> where T : Component
    {
        public T PrefabObject { get; }
        public Transform Container { get; }

        private Queue<T> pool;

        private IFactoryComponent _factoryComponent;

        public PoolServices(T prefab, int count, Transform container)
        {
            PrefabObject = prefab;
            Container = container;
            CreatePool(count);
        }

        [Inject]
        private void Construct(IFactoryComponent factoryComponent)
        {
            _factoryComponent = factoryComponent;
        }

        private void CreatePool(int count)
        {
            pool = new Queue<T>();
            for (int i = 0; i < count; i++)
                CreateObject();
        }

        private T CreateObject(bool isActiveByDefault = false)
        {
            var createdObject = _factoryComponent.Create(PrefabObject);
            createdObject.gameObject.SetActive(isActiveByDefault);
            this.pool.Enqueue(createdObject);
            return createdObject;
        }

        public T GetElement()
        {
            T element;
            if (pool.Count > 0)
            {
                element = pool.Dequeue();
            }
            else
            {
                element = CreateObject(isActiveByDefault: true);
            }
            return element;
        }
        
        public void ReturnToPool(T element)
        {
            element.gameObject.SetActive(false);
            pool.Enqueue(element);
        }
    }
}