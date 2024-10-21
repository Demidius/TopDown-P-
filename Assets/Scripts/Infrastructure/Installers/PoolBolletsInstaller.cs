using UnityEngine;
using Weapons.Bullet;
using Zenject;

namespace Infrastructure.Installers
{
    public class PoolBolletsInstaller : MonoInstaller
    {
        [SerializeField] private PoolBullet poolBullet;


        public override void InstallBindings()
        {

            Container
                .Bind<IPoolBullet>()
                .To<PoolBullet>()
                .FromInstance(this.poolBullet)
                .AsTransient();
        }
    }
}