using System.Numerics;

namespace Weapons.Bullet
{
    internal interface IBullet
    {
        void SetParameters(float speed, PoolServices<Bullet2> pool);
    }
}