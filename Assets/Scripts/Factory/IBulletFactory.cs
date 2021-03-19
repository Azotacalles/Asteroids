using UnityEngine;

namespace Asteroids
{
    internal interface IBulletFactory
    {
        Bullet Create(Transform position);
    }
}
