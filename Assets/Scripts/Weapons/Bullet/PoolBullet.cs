using UnityEngine;
using UnityEngine.Serialization;

using Zenject;

namespace Weapons.Bullet
{
    public class PoolBullet : MonoBehaviour, IPoolBullet
    {
    //[SerializeField] private int _poolSize = 10;
   [SerializeField] private Bullet2 bullet2Prefab;

    private PoolComponent<Bullet2> _poolComponent;
 
    [Inject]
    public void Construct(PoolComponent<Bullet2> poolComponent)
    {
        _poolComponent = poolComponent;
    }
  
    public void GetBullet(Vector3 direction, float speed )
    {
        var bullet = _poolComponent.GetElement();
    //    bullet.transform.position = direction;
    // bullet.SetParameters(speed, _poolComponent);
    }

    }
}