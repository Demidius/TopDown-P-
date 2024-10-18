namespace Enemy
{
    public interface IState
    {
    }

    public interface IEnterState
    {
        void Enter();
    }

    public interface IExitState
    {
        void Exit();
    }

    public interface IUpdatableState
    {
        void Update();
    }

    public class EnemyStateMachine
    {
    }
}