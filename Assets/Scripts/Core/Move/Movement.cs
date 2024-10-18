using Infrastructure.Services.Time;
using UnityEngine;

namespace Core.Move
{
    public class Movement : IMovement
    {
        private readonly IMovable _movable;
        private readonly ITimeService _timeService;
        private readonly Rigidbody2D _rigidbody;

        public Movement(Rigidbody2D rigidbody, IMovable movable, ITimeService timeService)
        {
            _rigidbody = rigidbody;
            _timeService = timeService;
            _movable = movable;
        }

        public void Move(Vector2 direction) =>
            _rigidbody.MovePosition(_rigidbody.position + _movable.Speed * _timeService.DeltaTime * direction);
    }
}