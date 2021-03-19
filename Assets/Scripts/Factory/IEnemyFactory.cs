using UnityEngine;

namespace Asteroids
{
    interface IEnemyFactory
    {
        Enemy Create(Health hp);
    }
}
