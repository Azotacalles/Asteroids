using UnityEngine;
using Asteroids.ObjectPool;

namespace Asteroids
{
    internal abstract class Enemy : MonoBehaviour
    {
        public static IEnemyFactory Factory;
        private Transform rotPool;
        private Health health;
        [SerializeField] protected Vector3 spawnArea;

        public Health Health
        {
            get
            {
                if (health.Current <= 0.0f)
                {
                    ReturnToPool();
                }
                return health;
            }
            protected set => health = value;
        }

        public Transform RotPool
        {
            get
            {
                if (rotPool == null)
                {
                    var find = GameObject.Find(NameManager.POOL_AMMUNITION);
                    rotPool = find == null ? null : find.transform;
                }

                return rotPool;
            }
        }

        public static Asteroid CreateAsteroidEnemy(Health hp)
        {
            var enemy = Instantiate(Resources.Load<Asteroid>("Enemy/Asteroid"));
            enemy.Health = hp;
            return enemy;
        }

        public static EnemyShip CreateEnemyShip(Health hp)
        {
            var enemy = Instantiate(Resources.Load<EnemyShip>("Enemy/EnemyShip"));
            enemy.health = hp;
            return enemy;
        }

        public void DependencyInjectHealth(Health hp)
        {
            Health = hp;
        }

        public static Enemy CreateAsteroidEnemyWithPool(EnemyPool enemyPool, Health hp)
        {
            var enemy = enemyPool.GetEnemy("Asteroid");
            enemy.transform.position = Vector3.one;
            enemy.gameObject.SetActive(true);
            enemy.health = hp;

            return enemy;
        }

        private void ActiveEnemy(Vector3 position, Quaternion rotation)
        {
            transform.localPosition = position;
            transform.localRotation = rotation;
            gameObject.SetActive(true);
            transform.SetParent(null);
        }

        protected void ReturnToPool()
        {
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            gameObject.SetActive(false);
            transform.SetParent(RotPool);

            if (!RotPool)
            {
                Destroy(gameObject);
            }
        }

        public abstract void InitPosition();

        private void OnCollisionExit2D(Collision2D collision)
        {
            Destroy(gameObject);
        }
    }
}
