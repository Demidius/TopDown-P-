using Unity.VisualScripting;
using UnityEngine;
using Zenject;

namespace Code_Base
{
    public class Bullet : Sounds
    {
        [SerializeField] private GameObject lootPrefab;

        private float speed = 15f;
        private float lifetime = 7f;
        public Vector2 direction;
        private IPlayer _player;
        private IKillCounter _killCounter;


        public void Launch(Vector2 launchDirection)
        {
            direction = launchDirection;
            Destroy(gameObject, lifetime); 
        }
        private void Update()
        {
            if (_player == null)
                _player = FindAnyObjectByType(typeof(Player)) as IPlayer;

            if (_killCounter == null)
            {
                _killCounter = FindAnyObjectByType(typeof(KillCounter)) as IKillCounter;
            }

            transform.Translate(direction * (speed * _player.TimeModifare * Time.deltaTime), Space.World);
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Enemy")) 
            {
                SpawnLoot(collision);
                DestroyHandler(collision);
            }
        }
        private void DestroyHandler(Collider2D collision)
        {
            Destroy(collision.gameObject); 
            _killCounter.AddKill();
            PlaySound(0, destroyed: true, volume: 0.8f);
            Destroy(gameObject); 
        }
        private void SpawnLoot(Collider2D collision)
        {
            GameObject loot = Instantiate(lootPrefab, collision.GameObject().transform.position,
                collision.GameObject().transform.rotation);
            LootHandler lootHandlerScript = loot.GetComponent<LootHandler>();
           
        }
    }
}