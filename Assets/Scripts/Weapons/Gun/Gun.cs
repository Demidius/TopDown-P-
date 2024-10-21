using System;
using Infrastructure.Installers;
using Infrastructure.Services.Inputs;
using UnityEngine;
using Weapons.Bullet;
using Zenject;

namespace Weapons.Gun
{
    public class Gun : MonoBehaviour ,IWeapon
    {
        [SerializeField] private Transform _bulletSpawnPoint;

     //   private IInputService _pcInputService;
     //   [SerializeField] private IBullet _bulletPrefab;
        private float _bulletSpeed;
       private IPoolBullet _poolBullet;
        private Vector3 direction;
        
        //private float _speedBullet = 2;

        [Inject]
        public void Construct(IPoolBullet poolBullet)
        {
            _poolBullet = poolBullet;
        }
       
        

        private void Update()
        {
            TestInput();
            RotateGunToMouse();
        }

        private void TestInput() //work
        {
            if (Input.GetKeyDown(KeyCode.C))
                    Shoot();
        }

       private void RotateGunToMouse() //work
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = (mousePosition - transform.position).normalized;
            direction.z = 0;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }

        private void Shoot()
        {
            Debug.Log("piu");
            _poolBullet.GetBullet(Vector3.zero, 2);
        }
    }
}