using System;
using Infrastructure.Services.Providers;
using InputActionsMaps;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Infrastructure.Services.Inputs
{
    public class PcInputService : IInputService, IDisposable
    {
        private readonly ICameraProvider _cameraProvider;
        private readonly InputActionPlayer _inputActionPlayer;

        public PcInputService(InputActionPlayer inputActionPlayer, ICameraProvider cameraProvider)
        {
            _cameraProvider = cameraProvider;
            _inputActionPlayer = inputActionPlayer;
        }

        private bool _isActive;

        public void SetActive(bool active)
        {
            if (_isActive == active)
                return;

            if (active)
                Enable();
            else
                Disable();

            _isActive = active;
        }

        public event Action TimeFreezeActivated;

        public Vector2 MoveAxes =>
            _inputActionPlayer.PlayerActions.Mosuse.ReadValue<Vector2>();

        public Vector3 MousePositionInWorld
        {
            get
            {
                var position = _inputActionPlayer.PlayerActions.Move.ReadValue<Vector2>();
                return _cameraProvider.Camera.ScreenToWorldPoint(position);
            }
        }

        public void Dispose()
        {
            Disable();
            _inputActionPlayer?.Dispose();
        }

        private void Enable()
        {
            _inputActionPlayer.Enable();
            _inputActionPlayer.AbilitiesActions.TimeFreeze.performed += OnTimeFreezePerformed;
        }

        private void Disable()
        {
            _inputActionPlayer.AbilitiesActions.TimeFreeze.performed -= OnTimeFreezePerformed;
            _inputActionPlayer.Disable();
        }

        private void OnTimeFreezePerformed(InputAction.CallbackContext callbackContext) =>
            TimeFreezeActivated?.Invoke();
    }
}