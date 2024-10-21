using Infrastructure.Services.Inputs;
using UnityEngine;
using Zenject;

namespace Infrastructure.Installers
{
    public class InputInstaller : MonoInstaller
    {
        [SerializeField] private PcInputService pcInputService;
        public override void InstallBindings()
        {
            Container
                .Bind<IInputService>()
                .To<PcInputService>()
                .AsSingle();
        }
    }
}
