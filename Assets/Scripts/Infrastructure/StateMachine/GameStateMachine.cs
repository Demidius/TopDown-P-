using System;
using System.Collections.Generic;
using Infrastructure.StateMachine.States.Base;

namespace Infrastructure.StateMachine
{
	public abstract class Transition
	{
		public bool Ready;
	}

	public abstract class StateMachine
	{
		private readonly Dictionary<Type, IExcitableState> _states = new();

		private IExcitableState _activeState = new IExcitableState.Empty();

		

		public void Enter() 
		{
		}

		

		private TState ChangeState<TState>() where TState : class, IExcitableState
		{
			_activeState.Exit();

			TState state = GetState<TState>();
			_activeState = state;

			return state;
		}

		private TState GetState<TState>() where TState : class, IExcitableState =>
			_states[typeof(TState)] as TState;
		
	}

	public class GameStateMachine : IGameStateMachine
	{
		private readonly Dictionary<Type, IExcitableState> _states = new();

		private IExcitableState _activeState = new IExcitableState.Empty();

		public GameStateMachine()
		{
		}

		public void Enter<TState>() where TState : class, IState
		{
			TState state = ChangeState<TState>();
			state.Enter();
		}

		public void Enter<TState, TPayload>(TPayload payload) where TState : class, IPayloadState<TPayload>
		{
			TState state = ChangeState<TState>();
			state.Enter(payload);
		}

		private TState ChangeState<TState>() where TState : class, IExcitableState
		{
			_activeState.Exit();

			TState state = GetState<TState>();
			_activeState = state;

			return state;
		}

		private TState GetState<TState>() where TState : class, IExcitableState =>
			_states[typeof(TState)] as TState;
	}
}