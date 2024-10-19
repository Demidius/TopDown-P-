using System;
using UnityEngine;

namespace Core.Health
{
    public class Health : IHealth
    {
        private int _healthValue;
        private bool _isLife;
        public event Action<float> ChangeHealth;
        public event Action HealthIsDepleted;


        public Health(int healthValue)
        {
            this._healthValue = healthValue;
        }

        public float Value => _healthValue;

        public void GetDamage(int damage)
        {
            if (_isLife== false)
                return;

            if (damage <= 0)
                throw new Exception("Damage must be greater than 0");
                

            _healthValue -= damage;
            ChangeHealth?.Invoke(_healthValue);
                
            if (_healthValue <= 0)
            {
                _isLife = false;
            
            
            
                HealthIsDepleted?.Invoke();
            }
            
        }
    }
}