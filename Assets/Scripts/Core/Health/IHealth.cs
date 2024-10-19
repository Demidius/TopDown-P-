using System;

namespace Core.Health
{
    public interface IHealth
    {
        float Value { get; }
        event Action <float> ChangeHealth;
        event Action HealthIsDepleted; 
        void GetDamage(int _healthValue);
    }
}


