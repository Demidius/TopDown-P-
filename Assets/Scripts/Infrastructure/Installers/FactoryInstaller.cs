using Infrastructure.Factories;
using UnityEngine;
using Weapons.Bullet;
using Zenject;
using Bullet = Code_Base.Bullet;

namespace Infrastructure.Installers
{
    public class FactoryInstaller : MonoInstaller
    {
        [SerializeField]
        public FactoryComponent factoryComponent;
        
        [SerializeField] private Bullet bulletComponent;
        [SerializeField] private int _poolSize = 10;

        public override void InstallBindings()
        {
       
            Container
                .Bind<IFactoryComponent>()
                .To<FactoryComponent>()
                .FromInstance(factoryComponent)
                .AsSingle();

          
            Container.Bind<PoolServices<Bullet>>()
                .AsSingle()
                .WithArguments(bulletComponent, _poolSize, this.transform);
        }
    }
}