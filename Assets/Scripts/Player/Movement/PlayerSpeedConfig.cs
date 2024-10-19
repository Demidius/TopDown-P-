using UnityEngine;

namespace Player
{
    [CreateAssetMenu(
        fileName = nameof(PlayerSpeedConfig),
        menuName = nameof(ScriptableObject) + "/" + nameof(PlayerSpeedConfig),
        order = 51)]
    public class PlayerSpeedConfig : ScriptableObject 
    {
        [field: SerializeField] public AnimationCurve AccelerationCurve { get; private set; }
        [field: SerializeField] public float AccelerationTime { get; private set; }
        [field: SerializeField] public float DecelerationTime { get; private set; }
        [field: SerializeField] public float MaxSpeed { get; set; }
    }
}