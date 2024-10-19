using Infrastructure.Services.Time;
using Player.Movement;
using UnityEngine;

namespace Player
{
    public class PlayerSpeedProvider : IPlayerSpeedProvider
    {
        private readonly ITimeService _timeService;
        private readonly PlayerSpeedConfig _config;

        private float _accelerationProgress;

        public PlayerSpeedProvider(PlayerSpeedConfig config, ITimeService timeService)
        {
            _timeService = timeService;
            _config = config;
        }

        public float GetSpeed(Vector2 direction)
        {
            float sqrMagnitude = direction.sqrMagnitude;
            float maxSpeed = _config.MaxSpeed;

            _accelerationProgress += sqrMagnitude > 0
                ? CalculateAcceleration(_config.AccelerationTime)
                : -CalculateAcceleration(_config.DecelerationTime);

            _accelerationProgress = Mathf.Clamp01(_accelerationProgress);

            return maxSpeed * GetEvaluate();
        }

        private float CalculateAcceleration(float timeAcceleration) =>
            _timeService.DeltaTime / timeAcceleration;

        private float GetEvaluate() =>
            _config.AccelerationCurve.Evaluate(_accelerationProgress);
    }
}