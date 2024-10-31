using Infrastructure.StateMachine;
using Infrastructure.StateMachine.States;
using Infrastructure.StateMachine.States.Base;
using Zenject;

namespace Infrastructure.Installers
{
    public class GameStateInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            // Регистрация основного интерфейса состояния игры
            Container.Bind<IGameStateMachine>().To<GameStateMachine>().AsSingle();

            // Регистрация различных состояний
            Container.Bind<IState>().To<BootstrapState>().AsTransient();
            Container.Bind<IState>().To<GameLoopState>().AsTransient();
            Container.Bind<IState>().To<LoadLevelState>().AsTransient();
            Container.Bind<IState>().To<LoadProgressState>().AsTransient();

            // Если у вас есть состояния с параметрами (IPayloadState), регистрируем их как следует
           //    Container.Bind<IPayloadState<string>>().To<SomePayloadState>().AsTransient();

            // Если интерфейс IExcitableState нужен, регистрируем его
            //   Container.Bind<IExcitableState>().To<ExcitableStateImplementation>().AsTransient();
        }
    }
}