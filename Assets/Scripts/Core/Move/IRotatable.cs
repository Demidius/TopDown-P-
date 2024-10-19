using UnityEngine;

namespace Core.Move
{
    public interface IRotatable
    {
        Transform Target { get; }
        float RotationSpeedInDegrees { get; }
    }
}