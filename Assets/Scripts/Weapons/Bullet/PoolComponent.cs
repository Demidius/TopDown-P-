using System;
using System.Collections.Generic;
using Infrastructure.Factories;
using UnityEngine;
using Zenject;
using Object = UnityEngine.Object;

namespace Weapons.Bullet
{
    public class PoolComponent<T> where T : Component
    {
        public T PrefabObject { get; }
        public Transform Container { get; }

        private readonly Queue<T> pool = new();

        private IFactoryComponent _factoryComponent;

        private int poolCount;

        public PoolComponent(T prefab, int count, Transform container, IFactoryComponent factoryComponent)
        {
            _factoryComponent = factoryComponent;
            PrefabObject = prefab;
            Container = container;
            poolCount = count;
            Instantiate(poolCount);
        }


        private void Instantiate(int count)
        {
            for (int i = 0; i < count; i++)
                pool.Enqueue(CreateComponent());
        }

        private T CreateComponent(bool isActiveByDefault = false)
        {
            var createdObject = _factoryComponent.Create(PrefabObject);
            createdObject.transform.SetParent(Container);
            createdObject.gameObject.SetActive(isActiveByDefault);
            return createdObject;
        }

        public T GetElement() => 
            pool.Count <= 0 ? CreateComponent(isActiveByDefault: true) : GetAndActivate();

        private T GetAndActivate()
        {
            var obj = pool.Dequeue();
            obj.gameObject.SetActive(true);
            return obj;
        }

        public void ReturnToPool(T element)
        {
            element.gameObject.SetActive(false);
            pool.Enqueue(element); 
        }
    }
}