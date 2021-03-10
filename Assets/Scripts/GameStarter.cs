using UnityEngine;
using Asteroids.ObjectPool;

namespace Asteroids
{
    internal sealed class GameStarter : MonoBehaviour
    {
        private void Start()
        {
            Enemy.CreateAsteroidEnemy(new Health(100f, 100f));

            IEnemyFactory factory = new AsteroidFactory();
            factory.Create(new Health(100f, 100f));

            Enemy.Factory = new AsteroidFactory();
            Enemy.Factory.Create(new Health(100f, 100f));


            Enemy.CreateEnemyShip(new Health(200f, 200f));

            factory = new EnemyShipFactory();
            factory.Create(new Health(200f, 200f));

            Enemy.Factory = new EnemyShipFactory();
            Enemy.Factory.Create(new Health(200f, 200f));

            //EnemyPool enemyPool = new EnemyPool(5);
            //var enemy = enemyPool.GetEnemy("Asteroid");
            //enemy.transform.position = Vector3.one;
            //enemy.gameObject.SetActive(true);
        }
    }
}
