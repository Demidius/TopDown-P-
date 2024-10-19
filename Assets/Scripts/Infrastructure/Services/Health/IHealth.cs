using System;

namespace Infrastructure.Services.Health
{
    public interface IHealth : IService
    {
        float Value { get; }
        event Action <float> Damaged;
        event Action HealthIsDepleted; 
        void GetDamage(int damage);
    }
}
