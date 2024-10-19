using Core.Health;
using UnityEngine;
using Zenject;

namespace Infrastructure.Installers
{
    public class HealthInstaller : MonoInstaller
    {
        [SerializeField]
        private Health _health;
      
        public override void InstallBindings()
        {
            Container
                .Bind<IHealth>()
                .To<Health>()
                .FromInstance(_health) 
                .AsTransient();  
        }
    }
}