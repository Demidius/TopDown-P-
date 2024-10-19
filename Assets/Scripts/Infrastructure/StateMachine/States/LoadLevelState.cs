using Data;
using Infrastructure.Services.SceneLoader;
using Infrastructure.StateMachine.States.Base;


namespace Infrastructure.StateMachine.States
{
    public class LoadLevelState : IPayloadState<SceneData>
    {
        public void Enter(SceneData payload)
        {
            throw new System.NotImplementedException();
        }

        public void Exit()
        {
            throw new System.NotImplementedException();
        }
    }
}