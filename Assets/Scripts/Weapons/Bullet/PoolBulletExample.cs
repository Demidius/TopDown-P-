using UnityEngine;
using Weapons.Gun;

namespace Weapons.Bullet
{
    public class PoolBulletExample : MonoBehaviour

    {
    [SerializeField] private int _poolSize = 10;
    [SerializeField] private bool _autoExpand = false;
    [SerializeField] private Bullet _bulletPrefab;

    private PoolServices<Bullet> _pool;
 
    private void Start()
    {
        _pool = new PoolServices<Bullet>(_bulletPrefab, _poolSize, this.gameObject.transform);
        this._pool.AutoExpand = _autoExpand;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
            this.GetBullet(Vector3.zero); 
    }

    private void GetBullet(Vector3 direction )
    {
        var bullet = _pool.GetFreeElement();
        
    }

    }
}