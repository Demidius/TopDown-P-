using Infrastructure.Factories;
using UnityEngine;
using Zenject;

namespace Infrastructure.Installers
{
    public class FactoryInstaller : MonoInstaller
    {
        [SerializeField]
        private FactoryComponent factoryComponent;
      
        public override void InstallBindings()
        {
            Container
                .Bind<IFactoryComponent>()
                .To<FactoryComponent>()
                .FromInstance(factoryComponent) 
                .AsSingle();
        }
    }
}