using System;
using Core.Move;
using Infrastructure.Factories;
using Infrastructure.Services.Inputs;
using UnityEngine;

namespace Player.Movement
{
    public class PlayerBodyRotation : MonoBehaviour, IRotatable
    {
        [field: SerializeField] public float RotationSpeedInDegrees { get; private set; }
        public Transform Target => transform;

        private IInputService _inputService;
        private IRotation _rotation;

        private void Construct(IInputService service, IFactoryMovement factoryMovement)
        {
            _inputService = service;
            _rotation = factoryMovement.CreatRotation(this);
        }

        private void Update()
        {
            Vector3 direction = (_inputService.MousePositionInWorld - transform.position).normalized;
            _rotation.Rotate(direction);
        }
    }
}