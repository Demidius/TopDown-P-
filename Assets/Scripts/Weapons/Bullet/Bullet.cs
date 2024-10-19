using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Weapons.Gun;

namespace Weapons.Bullet
{
    public class Bullet : MonoBehaviour, IBullet
    {
        [SerializeField] private float lifetime = 2f;
        private Vector3 _direction;
        private float _speed;


        public void GetParameters(Vector3 direction, float speed)
        {
            _direction = direction;
            _speed = speed;
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
            gameObject.SetActive(false);
        }
    }
}