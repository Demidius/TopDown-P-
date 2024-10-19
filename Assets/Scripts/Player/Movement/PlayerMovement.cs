using Core.Move;
using Infrastructure.Factories;
using Infrastructure.Services.Inputs;
using UnityEngine;
using Zenject;

namespace Player.Movement
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovement : MonoBehaviour, IMovable, IRotatable
    {
        [field: SerializeField] public float Speed { get; set; }
        [field: SerializeField] public float RotationSpeedInDegrees { get; private set; }

        private Rigidbody2D _rigidbody;

        private IRotation _rotation;
        private IMovement _movement;
        private IPlayerSpeedProvider _playerSpeed;
        private IInputService _inputService;

        public Vector3 Position =>
            _rigidbody.position;

        public Transform Target
            => transform;

        [Inject]
        public void Construct(IFactoryMovement factoryMovement, IPlayerSpeedProvider playerSpeedProvider,
            IInputService inputService)
        {
            _playerSpeed = playerSpeedProvider;
            _movement = factoryMovement.CreatMovement(this);
            _rotation = factoryMovement.CreatRotation(this);
            _inputService = inputService;
        }

        private void Start() =>
            _rigidbody = GetComponent<Rigidbody2D>();

        private void Update()
        {
            Vector3 position = transform.position;
            Vector3 direction = (_inputService.MoveAxes - new Vector2(position.x,position.y).normalized);
            Speed = _playerSpeed.GetSpeed(direction);

            _movement.Move(direction);
            _rotation.Rotate(direction);
        }

        public void SetPosition(Vector3 position) =>
            _rigidbody.MovePosition(position);
    }
}