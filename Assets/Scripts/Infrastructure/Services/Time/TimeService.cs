using System;
using UnityEngine;

namespace Infrastructure.Services.Time
{
    public class TimeService : ITimeService
    {
        private const float TimeFactor = 1f;

        private float _timeScale;

        public event Action ChangeTimeScale;

        public TimeService() =>
            _timeScale = TimeFactor;

        public float TimeScale
        {
            get =>
                _timeScale;
            set
            {
                _timeScale = Mathf.Clamp(value, 0, TimeFactor);
                ChangeTimeScale?.Invoke();
            }
        }

        public float DeltaTime =>
            UnityEngine.Time.deltaTime * TimeScale;
    }
}