using UnityEngine;

namespace Asteroids
{
    internal sealed class EnemySimpleBulletFactory : IBulletFactory
    {
        public Bullet Create(Transform position)
        {
            var bullet = Object.Instantiate(Resources.Load<Bullet>("Weapon/SimpleBullet"), position);
            bullet.Force = -bullet.Force;
            bullet.Barell = position;
            return bullet;
        }
    }
}
