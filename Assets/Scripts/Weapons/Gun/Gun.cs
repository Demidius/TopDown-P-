using System;
using UnityEngine;

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