using Infrastructure.Services.Time;
using UnityEngine;

namespace Core.Move
{
    public class Rotation : IRotation
    {
        private readonly IRotatable _rotatable;
        private readonly ITimeService _timeService;

        public Rotation(IRotatable rotatable, ITimeService timeService)
        {
            _rotatable = rotatable;
            _timeService = timeService;
        }

        public void Rotate(Vector2 direction)
        {
            float rotationStep = CalculateRotationStep(_timeService.DeltaTime);
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            Quaternion newRotation = Quaternion.Euler(0, 0, angle);
            _rotatable.Target.rotation = Quaternion.Slerp(_rotatable.Target.rotation, newRotation, rotationStep);
        }

        private float CalculateRotationStep(float deltaTime)
        {
            float rotationStep = deltaTime * _rotatable.RotationSpeedInDegrees;
            return Mathf.Clamp01(rotationStep);
        }
    }
}