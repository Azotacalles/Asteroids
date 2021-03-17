using UnityEngine;

namespace Asteroids
{
    internal sealed class EnemyShipFactory : IEnemyFactory
    {
        public Enemy Create(Health hp)
        {
            var enemy = Object.Instantiate(Resources.Load<EnemyShip>("Enemy/EnemyShip"));
            enemy.DependencyInjectHealth(hp);
            (enemy as EnemyShip).InitPosition();
            return enemy;
        }
    }
}
