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
        private PoolServices<Bullet2> _pool;

        public void SetParameters(float speed, PoolServices<Bullet2> pool)
        {
            _pool = pool;
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
            _pool?.ReturnToPool(this);
        }
    }
}