using UnityEngine;

namespace Code_Base
{
    public class GunHandler : MonoBehaviour
    {
        public Vector3 direction;
    void Update()
        {
            RotateGunToMouse();
        }

        void RotateGunToMouse()
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = (mousePosition - transform.position).normalized;
            direction.z = 0;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }
    }
}