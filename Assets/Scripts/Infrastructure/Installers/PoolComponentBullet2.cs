using UnityEngine;
using Weapons.Bullet;
using Zenject;

namespace Infrastructure.Installers
{
    public class PoolComponentBullet2 : MonoInstaller
    {
        [SerializeField] private Bullet2 bulletComponent;
        [SerializeField] private int _poolCount = 10;

        public override void InstallBindings()
        {
            Container.Bind<PoolComponent<Bullet2>>()
                .To<PoolComponent<Bullet2>>()
                .AsSingle()
                .WithArguments(bulletComponent, _poolCount, this.transform);
        }
    }
}