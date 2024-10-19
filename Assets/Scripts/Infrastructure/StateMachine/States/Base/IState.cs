namespace Infrastructure.StateMachine.States.Base
{
    public interface IState : IExcitableState
    {
        public void Enter();
    }
}