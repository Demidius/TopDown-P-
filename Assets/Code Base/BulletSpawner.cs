using System.Collections;
using System;
using UnityEngine;
using Zenject;


namespace Code_Base
{
    public class BulletSpawner : Sounds, IBulletSpawner
    {
        [SerializeField] private Transform bulletSpawnPoint; 
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private GunHandler gunHandler;

        public event Action Shooting;

        private IBulletsManager _bulletsManager;
        
        [Inject]
        private void Construct( IBulletsManager bulletsManager )
        {
            this._bulletsManager = bulletsManager;
        }
        
        private void Update()
        {
            
            if (Input.GetMouseButtonDown(0) && _bulletsManager.BulletsScore > 0) 
            {
                SpawnBullet();
                PlaySound(0, volume: 0.7f);
            }
        }

        private void SpawnBullet()
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            Bullet bulletScript = bullet.GetComponent<Bullet>();
        
            if (bulletScript != null)
            {
                bulletScript.Launch(gunHandler.direction);
                Shooting?.Invoke();
            }
        }
    }

   
}