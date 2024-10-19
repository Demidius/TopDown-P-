using Infrastructure.Services.Time;
using UnityEngine;

namespace Core.Move
{
    public class Movement : IMovement
    {
        private readonly IMovable _movable;
        private readonly ITimeService _timeService;

        public Movement(IMovable movable, ITimeService timeService)
        {
            _timeService = timeService;
            _movable = movable;
        }

        public void Move(Vector3 direction) =>
            _movable.SetPosition(_movable.Position + _movable.Speed * _timeService.DeltaTime * direction);
    }
}