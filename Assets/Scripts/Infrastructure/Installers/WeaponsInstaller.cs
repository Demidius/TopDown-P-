using Infrastructure.Services.Inputs;
using UnityEngine;
using Weapons;
using Weapons.Gun;
using Zenject;

namespace Infrastructure.Installers
{
    public class WeaponsInstaller : MonoInstaller
    {
        [SerializeField] private Gun _gun; 
        public override void InstallBindings()
        {
            Container
                .Bind<IWeapon>()
                .To<Gun>()
                .FromInstance(_gun)
                .AsSingle();
        }
    }
}