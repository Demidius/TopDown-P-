using Enemy;

namespace Infrastructure.StateMachine.States.Base
{
	public interface IUpdatableState : IExcitableState, IEnterState
	{
		void Update();
	}

	public interface IExcitableState
	{
		public void Exit();

		public class Empty : IExcitableState
		{
			public void Exit() { }
		}
	}
}