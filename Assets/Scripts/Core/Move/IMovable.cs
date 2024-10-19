using UnityEngine;

namespace Core.Move
{
    public interface IMovable
    {
        float Speed { get; set; }
        Vector3 Position { get;  }
        void SetPosition(Vector3 position);
    }
}