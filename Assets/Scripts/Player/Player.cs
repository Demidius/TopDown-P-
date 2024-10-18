using Core.Move;
using Infrastructure.Services.Inputs;
using UnityEngine;
using Zenject;

namespace Player
{
    public class PlayerMovement : MonoBehaviour, IMovable
    {
        [field: SerializeField] public float Speed { get; set; }

        private IMovement _movement;
        private IRotation _rotation;
        private IInputService _inputService;

        [Inject]
        private void Construct(IMovement movement, IRotation rotation, IInputService inputService)
        {
            _movement = movement;
            _rotation = rotation;
            _inputService = inputService;
        }

        private void Update()
        {
            Vector3 direction = (transform.position - _inputService.MousePositionInWorld).normalized;
            _movement.Move(direction);
            _rotation.Rotate(direction);
        }
    }
}