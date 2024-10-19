using System;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Weapons.Bullet
{
    public class PoolServices<T> where T : MonoBehaviour
    {
        public T PrefabObject { get; }
        public bool AutoExpand { get; set; }
        public Transform Container { get; }

        private List<T> pool;

        public PoolServices(T prefab, int count, Transform container)
        {
            this.PrefabObject = prefab;
            this.Container = container;
            this.CreatePool(count);
        }

        private void CreatePool(int count)
        {
            this.pool = new List<T>();

            for (int i = 0; i < count; i++)
                this.CreateObject();
        }

        private T CreateObject(bool isActiveByDefault = false)
        {
            var createdObject = Object.Instantiate(this.PrefabObject, this.Container);
            createdObject.gameObject.SetActive(isActiveByDefault);
            this.pool.Add(createdObject);
            return createdObject;
        }

        public bool HasFreeElement(out T element)
        {
            foreach (var mono in pool)
            {
                if (!mono.gameObject.activeInHierarchy)
                {
                    element = mono;
                    return true;
                }
            }

            element = null;
            return false;
        }

        public T GetFreeElement()
        {
            if (this.HasFreeElement(out var element))
                return element;
            
            if(this.AutoExpand)
                return this.CreateObject(isActiveByDefault: true);
            
            throw new Exception($"Cannot get free element in pool of type {typeof(T).Name}");
        }
    }
}