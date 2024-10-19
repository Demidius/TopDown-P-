using System;
using UnityEngine;
using Weapons.Bullet;

namespace Weapons.Gun
{
    public class Gun : IWeapon
    {
        [SerializeField] private Transform _bulletSpawnPoint; 
        [SerializeField] private IBullet _bulletPrefab;
        private float _bulletSpeed;

     


     private void Shoot()
     {
         
     }





    }
}