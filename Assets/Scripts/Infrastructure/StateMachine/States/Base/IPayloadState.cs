namespace Infrastructure.StateMachine.States.Base
{
	public interface IPayloadState<in TPayload> : IExcitableState
	{
		public void Enter(TPayload payload);
	}
}