using Infrastructure.Factories;
using Zenject;


namespace Infrastructure.Installers
{
    public class FactoryInstaller : MonoInstaller
    {
     
        public override void InstallBindings()
        {
       
            Container
                .Bind<IFactoryComponent>()
                .To<FactoryComponent>()
                .AsSingle();
            

          
           
        }
    }
}