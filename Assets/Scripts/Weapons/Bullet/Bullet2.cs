using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapons.Gun;

namespace Weapons.Bullet
{
    public class Bullet2 : MonoBehaviour, IBullet
    {
        [SerializeField] private float lifetime = 2f;
     //   private Vector3 _direction;
      //  private float _speed;
        private PoolComponent<Bullet2> _poolComponent;

        public void SetParameters(float speed, PoolComponent<Bullet2> poolComponent)
        {
            _poolComponent = poolComponent;
     //       _speed = speed;
        }

        private void OnEnable()
        {
            StartCoroutine(LifeRoutine());
        }

        private void OnDisable()
        {
            StopCoroutine(LifeRoutine());
        }

        private IEnumerator LifeRoutine()
        {
            yield return new WaitForSeconds(lifetime);
            Deactivate();
        }

        private void Deactivate()
        {
            _poolComponent?.ReturnToPool(this);
        }
    }
}