using UnityEngine;

namespace Code_Base
{
    public class RotateTowardsMovement : MonoBehaviour
    {
        private Rigidbody2D rb;
    
        void Start()
        {
            // Получаем компонент Rigidbody2D объекта
            rb = GetComponent<Rigidbody2D>();
        }

        void Update()
        {
            // Если объект движется, то поворачиваем его в сторону его скорости
            if (rb.velocity != Vector2.zero)
            {
                float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90f));
            }
        }
    }
}