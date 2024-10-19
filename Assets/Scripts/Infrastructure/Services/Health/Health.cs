using System;

namespace Infrastructure.Services.Health
{
    public class Health : IHealth
    {
        private int _healthValue;
        
        public event Action<float> Damaged;
        public event Action HealthIsDepleted;
        

        public Health(int healthValue)
        {
            this._healthValue = healthValue;
        }

        public float Value => _healthValue;

        public void GetDamage(int damage)
        {
            _healthValue -= damage;
            Damaged?.Invoke(damage);

            if (_healthValue <= 0) HealthIsDepleted?.Invoke();
        }
    }
}