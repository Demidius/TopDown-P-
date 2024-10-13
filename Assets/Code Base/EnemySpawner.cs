using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;
using Zenject;

namespace Code_Base
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private GameObject prefab;
        [SerializeField] private Collider2D spawnArea;
        [SerializeField] private float spawnInterval = 2f;
        [SerializeField] private float timeMod;
        [SerializeField] private float minDistansForEnemy;

        private IPlayer _player;
        private float _timer = 0f;

        [Inject]
        private void Construct(IPlayer player)
        {
            this._player = player;
        }

        private void Start()
        {
            StartCoroutine(SpawnObjects());
        }


        private IEnumerator SpawnObjects()
        {
            while (true)
            {
                timeMod = _player.TimeModifare;
                _timer += Time.deltaTime * timeMod;

                if (_timer >= spawnInterval && _player != null)
                {
                    SpawnObjectInCollider();
                    _timer = 0f;
                }
                else
                {
                    ReduseWait();
                }

                yield return null;
            }
        }

        private void ReduseWait()
        {
            if (spawnInterval > 0.9f)
                spawnInterval -= 0.1f * timeMod * Time.deltaTime;
            else if (spawnInterval > 0.5f)
                spawnInterval -= 0.01f * timeMod * Time.deltaTime;
            else
                spawnInterval = 0.5f;
        }

        private void SpawnObjectInCollider()
        {
            Vector3 randomPosition;
            if (_player != null)
            {
                do
                {
                    randomPosition = GetRandomPointInCollider(spawnArea);
                } while (Vector3.Distance(randomPosition, _player.Transform.position) < minDistansForEnemy);

                Instantiate(prefab, randomPosition, Quaternion.identity);
            }
        }

        private Vector3 GetRandomPointInCollider(Collider2D collider)
        {
            Vector3 point = new Vector3(
                Random.Range(collider.bounds.min.x, collider.bounds.max.x),
                Random.Range(collider.bounds.min.y, collider.bounds.max.y),
                Random.Range(collider.bounds.min.z, collider.bounds.max.z)
            );

            if (collider.bounds.Contains(point))
            {
                return point;
            }

            return GetRandomPointInCollider(collider);
        }
    }
}