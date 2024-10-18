using Infrastructure.Services.Time;
using UnityEngine;

namespace Core.Move
{
    public class Rotation : IRotation
    {
        private readonly Transform _transform;
        private readonly float _rotationSpeedInDegrees;
        private readonly ITimeService _timeService;

        public Rotation(Transform transform, float rotationSpeedInDegrees, ITimeService timeService)
        {
            _timeService = timeService;
            _transform = transform;
            _rotationSpeedInDegrees = rotationSpeedInDegrees;
        }

        public void Rotate(Vector2 direction)
        {
            float rotationStep = CalculateRotationStep(_timeService.DeltaTime);
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            Quaternion newRotation = Quaternion.Euler(0, 0, angle);
            _transform.rotation = Quaternion.Slerp(_transform.rotation, newRotation, rotationStep);
        }

        private float CalculateRotationStep(float deltaTime)
        {
            float rotationStep = deltaTime * _rotationSpeedInDegrees;
            return Mathf.Clamp01(rotationStep);
        }
    }
}