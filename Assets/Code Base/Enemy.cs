using UnityEngine;
using Zenject;

namespace Code_Base
{
    [RequireComponent(typeof(Rigidbody2D))]

    public class Enemy : MonoBehaviour, IEnemy
    {
        private Vector3 _moveDirection;
        private Rigidbody2D _rigidbody;
    
        
        private Player _player;
        public Transform Transform => transform;

        [SerializeField] private float _moveSpeed = 1;



        void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        
            _player = GameObject.FindObjectOfType<Player>();
            
            if (_player == null)
            {
                Destroy(gameObject); 
            }


        }

        // Update is called once per frame
        void Update()
        {
            if (_player)
            {
                Direction();
                MoveApllyer();
            }
        }

        private void MoveApllyer()
        {
            _rigidbody.velocity = _moveDirection * (_moveSpeed * _player.TimeModifare);
        }

        private void Direction()
        {
            _moveDirection =  _player.Transform.position - transform.position ;
            _moveDirection.Normalize();
        }
    }

    
}
