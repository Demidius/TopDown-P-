using UnityEngine;

namespace Player
{
    public interface IPlayerSpeedCalculate
    {
        float GetSpeed(Vector2 direction);
    }
}