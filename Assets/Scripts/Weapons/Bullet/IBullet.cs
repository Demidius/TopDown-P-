using System.Numerics;

namespace Weapons.Bullet
{
    internal interface IBullet
    {
        void SetParameters(float speed, PoolComponent<Bullet2> poolComponent);
    }
}