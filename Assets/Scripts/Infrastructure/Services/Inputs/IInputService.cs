using System;
using UnityEngine;

namespace Infrastructure.Services.Inputs
{
    public interface IInputService : ISwitchableService
    {
        event Action TimeFreezeActivated;

        Vector3 MousePositionInWorld { get; }
        Vector2 MoveAxes { get; }
    }
}