using UnityEngine;

namespace Code_Base
{
    public class LootHandler : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("Player"))
            {
                collision.GetComponent<Player>().AddBullet();
                DestroyHandler(collision);
            }
        }
        
        private void DestroyHandler(Collider2D collision)
        {
            Destroy(gameObject);
        }
    }
}
