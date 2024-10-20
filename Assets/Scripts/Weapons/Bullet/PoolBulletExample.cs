using UnityEngine;
using Weapons.Gun;
using Zenject;

namespace Weapons.Bullet
{
    public class PoolBulletExample : MonoBehaviour
    {
    //[SerializeField] private int _poolSize = 10;
    [SerializeField] private Bullet _bulletPrefab;

    private PoolServices<Bullet> _pool;
 
    
    [Inject]
    public void Construct(PoolServices<Bullet> pool)
    {
        _pool = pool;
    }
  
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
            GetBullet(Vector3.zero, 2 ); 
        
    }

    private void GetBullet(Vector3 direction, float speed )
    {
        var bullet = _pool.GetElement();
        bullet.transform.position = direction;
        bullet.SetParameters(speed, _pool);


    }

    }
}