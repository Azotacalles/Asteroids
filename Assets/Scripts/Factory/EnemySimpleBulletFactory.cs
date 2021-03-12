using UnityEngine;

namespace Asteroids
{
    internal sealed class EnemySimpleBulletFactory : IBulletFactory
    {
        public Bullet Create(Transform position)
        {
            var bullet = Object.Instantiate(Resources.Load<Bullet>("Weapon/SimpleBullet"), position);
            return bullet;
        }
    }
}
