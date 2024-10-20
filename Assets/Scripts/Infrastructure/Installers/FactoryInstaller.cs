using Infrastructure.Factories;
using UnityEngine;
using UnityEngine.Serialization;
using Weapons.Bullet;
using Zenject;
using Bullet = Code_Base.Bullet;

namespace Infrastructure.Installers
{
    public class FactoryInstaller : MonoInstaller
    {
     
        [SerializeField] private Bullet2 bulletComponent;
        [FormerlySerializedAs("_poolSize")] [SerializeField] private int _poolCount = 10;

        public override void InstallBindings()
        {
       
            Container
                .Bind<IFactoryComponent>()
                .To<FactoryComponent>()
                .AsSingle();
            

          
            Container.Bind<PoolServices<Bullet2>>()
                .To<PoolServices<Bullet2>>()
                .AsSingle()
                .WithArguments(bulletComponent, _poolCount, this.transform);
            
           
        }
    }
}