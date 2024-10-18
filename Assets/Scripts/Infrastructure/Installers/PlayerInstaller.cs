using Core.Move;
using Player;
using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

namespace Infrastructure.Installers
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private float _rotationSpeedInDegrees;
        [SerializeField] private PlayerMovement _playerMovement;
        [SerializeField] private Rigidbody2D _playerRigidbody2D;

        public override void InstallBindings()
        {
        }
    }
}
