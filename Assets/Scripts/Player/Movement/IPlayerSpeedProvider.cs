using UnityEngine;

namespace Player.Movement
{
    public interface IPlayerSpeedProvider
    {
        float GetSpeed(Vector2 direction);
    }
}