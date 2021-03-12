﻿using UnityEngine;
using Object = UnityEngine.Object;

namespace Asteroids
{
    internal sealed class PlayerSimpleBulletFactory : IBulletFactory
    {
        public Bullet Create(Transform position)
        {
            var bullet = Object.Instantiate(Resources.Load<Bullet>("Weapon/SimpleBullet"), position);
            bullet.Barell = position;
            return bullet;
        }
    }
}
