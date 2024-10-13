using UnityEngine;
using Zenject;

namespace Code_Base
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Player : Sounds, IPlayer
    {
        [SerializeField] private int _moveSpeed = 1;

        private const string Horizontal = "Horizontal";
        private const string Vertical = "Vertical";

        private Rigidbody2D _rigidbody;
        private Vector2 _moveDirection;
        private IBulletsManager _bulletsManager;
        private IGameOver _gameOver;
        private ITimer _timer;
        public Transform Transform { get; set; }

        public float TimeModifare { get; set; }

        
        [Inject]
        private void Construct(IBulletsManager bulletsManager, IGameOver gameOver, ITimer timer)
        {
            this._bulletsManager = bulletsManager;
            this._gameOver = gameOver;
            this._timer = timer;
        }
        
        void Start()
        {
            Transform = GetComponent<Transform>();
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            MoveApllyer();

            InputDirection();

            TimeModifireHandle();
        }

        private void TimeModifireHandle()
        {
            float playerMoveSpeed = _rigidbody.velocity.magnitude;
            if (playerMoveSpeed < 1 && playerMoveSpeed >= 0.1f)
                TimeModifare = playerMoveSpeed;
            else if (playerMoveSpeed < 0.1f)
                TimeModifare = 0.1f;
            else
            {
                TimeModifare = 1;
            }
        }

        private void InputDirection()
        {
            _moveDirection = new Vector2(Input.GetAxis(Horizontal), Input.GetAxis(Vertical));
        }

        public void AddBullet()
        {
            _bulletsManager.Reload();
        }
        

        private void MoveApllyer()
        {
            _rigidbody.velocity = _moveDirection * _moveSpeed;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Enemy")) 
            {
                _timer.StopTimer();
                _gameOver.OnGameOver();
                gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                Destroy(gameObject);
            }
        }
    }
}